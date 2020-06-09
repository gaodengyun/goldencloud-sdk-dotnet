/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 19:42:43
 * Name GoldenSDK
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

using GoldenCloud.Common.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoldenCloud.Common
{
    /// <summary>
    /// 云票票SDK
    /// </summary>
    /// <![CDATA[
    /// var postData = new ReqInvoiceBlue()
    /// {
    /// };
    /// var conf = new Configs()
    /// {
    /// };
    ///
    /// var sdk = new GoldenSDK(conf);
    /// var resp = sdk.HttpRequest<ReqInvoiceBlue, RespInvoiceBlue>(ApiAddress.INVOICE_BLUE, postData);
    /// if (resp.code == (int)EReqErrCode.S0)
    /// {
    ///     //success
    ///
    ///     var result = resp.data;
    ///     Debug.WriteLine(result.invoice_id);
    ///     Debug.WriteLine(result.order_sn);
    ///     Debug.WriteLine(result.state);
    /// }
    /// else
    /// {
    ///     //error
    ///
    ///     Debug.WriteLine(resp.message);
    /// }
    /// ]]>
    public class GoldenSDK
    {
        private readonly Configs _conf;

        public GoldenSDK(Configs conf)
        {
#if RELEASE
            conf.Env = DTO.EApiEnv.Prod;
#else
            conf.Env = EApiEnv.Test;
#endif
            _conf = conf;
        }

        /// <summary>
        /// 获取Appkey
        /// </summary>
        /// <returns></returns>
        public string GetAppkey()
        {
            return _conf.Appkey;
        }

        /// <summary>
        /// 获取 Appsecret
        /// </summary>
        /// <returns></returns>
        public string GetAppsecret()
        {
            return _conf.Appsecret;
        }

        /// <summary>
        /// 获取 BaseUrl
        /// </summary>
        /// <returns></returns>
        public string GetBaseUrl()
        {
            return _conf.BaseUrl;
        }

        /// <summary>
        /// 获取环境变量
        /// </summary>
        /// <returns></returns>
        public EApiEnv GetEnv()
        {
            return _conf.Env;
        }

        /// <summary>
        /// 获取 Ver
        /// </summary>
        /// <returns></returns>
        public string GetVer()
        {
            return _conf.Ver;
        }

        /// <summary>
        /// 获取 Algorithm
        /// </summary>
        /// <returns></returns>
        public string GetAlgorithm()
        {
            return _conf.Algorithm;
        }

        /// <summary>
        /// 设置 Appkey
        /// </summary>
        /// <param name="appkey"></param>
        public void SetAppkey(string appkey)
        {
            _conf.Appkey = appkey;
        }

        /// <summary>
        /// 设置 Appsecret
        /// </summary>
        /// <param name="appsecret"></param>
        public void SetAppsecret(string appsecret)
        {
            _conf.Appsecret = appsecret;
        }

        /// <summary>
        /// 设置 Log
        /// </summary>
        /// <returns></returns>
        [Obsolete("暂未使用", true)]
        public void SetLog()
        {
            throw new NullReferenceException();
        }

        /// <summary>
        /// 设置 Ver
        /// </summary>
        /// <param name="ver"></param>
        public void SetVer(string ver)
        {
            _conf.Ver = ver;
        }

        /// <summary>
        /// 取时间戳，高并发情况下会有重复。想要解决这问题请使用sleep线程睡眠1毫秒。
        /// </summary>
        /// <param name="accurateToMilliseconds">精确到毫秒</param>
        /// <returns>返回一个长整数时间戳</returns>
        public static long GetTimeStamp(bool accurateToMilliseconds = false)
        {
            if (accurateToMilliseconds)
            {
                //使用当前时间计时周期数（636662920472315179）减去1970年01月01日计时周期数（621355968000000000）除去（删掉）后面4位计数（后四位计时单位小于毫秒，快到不要不要）再取整（去小数点）。
                //备注：DateTime.Now.ToUniversalTime不能缩写成DateTime.Now.Ticks，会有好几个小时的误差。
                //621355968000000000计算方法 long ticks = (new DateTime(1970, 1, 1, 8, 0, 0)).ToUniversalTime().Ticks;
                return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            }
            else
            {
                //上面是精确到毫秒，需要在最后除去（10000），这里只精确到秒，只要在10000后面加三个0即可（1秒等于1000毫米）。
                return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            }
        }

        /// <summary>
        /// 时间戳反转为时间，有很多中翻转方法，但是，请不要使用过字符串（string）进行操作，大家都知道字符串会很慢！
        /// </summary>
        /// <param name="timeStamp">时间戳</param>
        /// <param name="accurateToMilliseconds">是否精确到毫秒</param>
        /// <returns>返回一个日期时间</returns>
        public static DateTime GetTime(long timeStamp, bool accurateToMilliseconds = false)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
            if (accurateToMilliseconds)
            {
                return startTime.AddTicks(timeStamp * 10000);
            }
            else
            {
                return startTime.AddTicks(timeStamp * 10000000);
            }
        }

        /// <summary>
        /// 拼接签名串
        /// 生成请求体
        /// 发起请求，返回请求结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public RespPubParm<R> HttpRequest<T, R>(string url, T data)
        {
            //步骤1 生成签名串
            //*

            //步骤2 生成的签名请求字符串。把排序好的 公共参数 格式化成 参数名称=参数值 的形式，加上signature=[步骤1] 中的签名串，用 "," (英文半角逗号) 拼接在一起。
            //形如:algorithm=签名算法,appkey=应用ID,nonce=随机数字,timestamp=时间戳,signature=签名串

            //步骤3 把[步骤2]中生成的签名请求字符串，放在 Authorization字段中，通过 Http header 方法，向服务器发起请求。
            //*

            var publicParams = GetPublicParamDic();
            var sign = Sign<T>(url, publicParams, data);
            var postStr = JsonConvert.SerializeObject(data);
            var publicString = string.Join(",", publicParams.OrderBy(e => e.Key).Select(e => e.Key + "=" + e.Value));

            var requestSignString = $"{publicString},signature={sign}";
            var postUrl = $"{_conf.BaseUrl}{url}";

            Debug.WriteLine($"postjson={postStr}");
            Debug.WriteLine($"sign={sign}");
            Debug.WriteLine($"requestUrl={requestSignString}");

            var respStr = WebServiceRequest.PostJson(postUrl, postStr, requestSignString);
            var result = JsonTools.Deserialize<RespPubParm<R>>(respStr);

            Debug.WriteLine($"respStr={respStr}");
            return result;
        }

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="timeStamp"></param>
        /// <param name="data"></param>
        /// <exception cref="Exception"/>
        /// <returns></returns>
        private string Sign<T>(string url,Dictionary<string,string> publicParams,T data)
        {
            //步骤1 对公共参数按参数名的字典序（ ASCII 码）升序排序
            //*

            //步骤2 把[步骤1]中排序好的 公共参数 格式化成 参数名称=参数值（key = value） 的形式，格式化后的各个参数用"|"拼接在一起,然后再拼接 URL路径、业务参数 payload
            //形如：algorithm=签名算法|appkey=应用ID|nonce=随机数字|timestamp=时间戳|URL路径|业务参数payload 
            //例如：algorithm=HMAC-SHA256|appkey=gd_abcdefghijklmn|nonce=398888|timestamp=1590719810|/invoice/v1|{"name":"高灯云"}

            //步骤3 使用 HMAC-SHA256 或 RSA-SHA256 算法对[步骤2]中获得的签名原文字符串进行签名，然后将生成的签名串使用 Base64 进行编码，即可获得最终的签名串
            //*

            var result = string.Empty;
            var publicString = string.Join("|", publicParams.OrderBy(e=>e.Key).Select(e => e.Key + "=" + e.Value));
            var payload = JsonConvert.SerializeObject(data);

            var originStr = $"{publicString}|{url}|{payload}";

            if (_conf.Algorithm == "HMAC-SHA256")
            {
                result = SHA256Crypt.HMACSHA256Encrypt(originStr,_conf.Appsecret);
            }
         
            Debug.WriteLine("整个原串");
            Debug.WriteLine("");
            Debug.WriteLine(originStr);

            Debug.WriteLine("签名算法");
            Debug.WriteLine("");
            Debug.WriteLine(_conf.Algorithm);

            Debug.WriteLine($"生成签名值 {result}");

            return result;
        }

        /// <summary>
        /// 公共参数
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> GetPublicParamDic()
        {
            var timeStamp = GetTimeStamp();
            var randomNum = GetRandomNum();

            var result = new Dictionary<string, string>();
            result.Add("algorithm", _conf.Algorithm);
            result.Add("appkey", _conf.Appkey);
            result.Add("nonce", randomNum);
            result.Add("timestamp", timeStamp.ToString());

            return result;
        }

        /// <summary>
        /// 生成6位随机数
        /// </summary>
        /// <returns></returns>
        private string GetRandomNum()
        {
            var result = string.Empty;
            var strBuilder = new StringBuilder();

            //循环的次数     
            Random random = new Random();
            for (var i = 0; i < 6; i++)
            {
                strBuilder.Append(random.Next(0, 10));
            }
            result = strBuilder.ToString();

            return result;
        }

        /// <summary>
        /// UrlEncode
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string UrlEncode(string str)
        {
            var urlStr = HttpUtility.UrlEncode(str, System.Text.Encoding.UTF8);
            var urlCode = Regex.Matches(urlStr, "%[a-f0-9]{2}", RegexOptions.Compiled).Cast<Match>().Select(m => m.Value).Distinct();
            foreach (string item in urlCode)
            {
                urlStr = urlStr.Replace(item, item.ToUpper());
            }
            return urlStr;
        }
    }
}