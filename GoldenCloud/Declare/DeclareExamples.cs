/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 23:14:40
 * Name Examples
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

using System;
using System.Diagnostics;

using GoldenCloud.Common;
using GoldenCloud.Common.Models;
using GoldenCloud.Declare.Models;

using Newtonsoft.Json;

namespace GoldenCloud.Declare
{
    public class DeclareExamples
    {
        /// <summary>
        /// 申报作废
        /// </summary>
        public void DeclareCancel()
        {
            var postData = new ReqDeclareCancel() {
                nsqxdm = "02",
                nsrsbh = "税号",
                sbzlbh = "10101",
                skssqq = "2019-10-01",
                skssqz = "2019-10-31"
            };

            var conf = new Configs();
            var sdk = new GoldenSDK(conf);
            var resp = sdk.HttpRequest<ReqDeclareCancel, RespPubParm<object>>(DeclareApiAddress.DECLARE_CANCEL, postData);
            Debug.WriteLine("DeclareCancel:");
            if (resp.code == (int)EReqErrCode.S0)
            {
                //success
                var result = resp.data;
                Debug.WriteLine(JsonConvert.SerializeObject(result));
            }
            else
            {
                //error
                Debug.WriteLine(resp.message);
            }
        }

        /// <summary>
        /// 申报初始化
        /// </summary>
        public void DeclareInit()
        {
            var postData = new ReqDeclareInit() {
                isRenew = "0",
                nsqxdm = "02",
                nsrsbh = "税号",
                sbzlbh = "10101",
                skssqq = "2019-10-01",
                skssqz = "2019-10-31"
            };

            var conf = new Configs();
            var sdk = new GoldenSDK(conf);
            var resp = sdk.HttpRequest<ReqDeclareInit, RespPubParm<object>>(DeclareApiAddress.DECLARE_INIT, postData);
            Debug.WriteLine("DeclareInit");
            if (resp.code == (int)EReqErrCode.S0)
            {
                //success
                var result = resp.data;
                Debug.WriteLine(JsonConvert.SerializeObject(result));
            }
            else
            {
                //error
                Debug.WriteLine(resp.message);
            }
        }

        /// <summary>
        /// 申报缴款
        /// </summary>
        public void DeclarePay()
        {
            var postData = new ReqDeclarePay() {
                nsqxdm = "02",
                nsrsbh = "税号",
                sbzlbh = "10101",
                skssqq = "2019-10-01",
                skssqz = "2019-10-31",
                sfxyh = "xxxxx",
                sfxyyhzh = "xxxxxxxxxxx"
            };

            var conf = new Configs();
            var sdk = new GoldenSDK(conf);
            var resp = sdk.HttpRequest<ReqDeclarePay, RespPubParm<object>>(DeclareApiAddress.DECLARE_PAY, postData);
            Debug.WriteLine("DeclarePay");
            if (resp.code == (int)EReqErrCode.S0)
            {
                //success
                var result = resp.data;
                Debug.WriteLine(JsonConvert.SerializeObject(result));
            }
            else
            {
                //error
                Debug.WriteLine(resp.message);
            }
        }

        /// <summary>
        /// 申报查询
        /// </summary>
        public void DeclareQuery()
        {
            var postData = new ReqDeclareQuery() {
                nsqxdm = "02",
                nsrsbh = "税号",
                sbzlbh = "10101",
                skssqq = "2019-10-01",
                skssqz = "2019-10-31"
            };

            var conf = new Configs();
            var sdk = new GoldenSDK(conf);
            var resp = sdk.HttpRequest<ReqDeclareQuery, RespPubParm<object>>(DeclareApiAddress.DECLARE_QUERY, postData);
            Debug.WriteLine("DeclareQuery");
            if (resp.code == (int)EReqErrCode.S0)
            {
                //success
                var result = resp.data;
                Debug.WriteLine(JsonConvert.SerializeObject(result));
            }
            else
            {
                //error
                Debug.WriteLine(resp.message);
            }
        }

        /// <summary>
        /// 申报登记
        /// </summary>
        public void DeclareRegister()
        {
            var postData = new ReqDeclareRegister() {
                nsrsbh = "税号",
                qymc = "公司名称",
                dqbm = "34",
                cwlxr = "",
                cwlxrlxfs = "",
                dsdlfs = "",
                dscsdlmm = "",
                dsdlyhm = "",
                dsdlmm = "",
                gsdlfs = "2",
                gsnsrsbh = "",
                gscamm = "",
                gsnsyhm = "",
                gsnsmm = "密码",
                dlsf = "",
                sjhm = "",
                sfzjhm = "",
                swjmc = "国家税务总局合肥高新技术产业开发区税务局",
                kjzd = "1",
                nsrzgdm = "101",
                qynf = "2020",
                qyyf = "04"
            };

            var conf = new Configs();
            var sdk = new GoldenSDK(conf);
            var resp = sdk.HttpRequest<ReqDeclareRegister, RespPubParm<object>>(DeclareApiAddress.DECLARE_REGISTER, postData);
            Debug.WriteLine("DeclareRegister");
            if (resp.code == (int)EReqErrCode.S0)
            {
                //success
                var result = resp.data;
                Debug.WriteLine(JsonConvert.SerializeObject(result));
            }
            else
            {
                //error
                Debug.WriteLine(resp.message);
            }
        }

        /// <summary>
        /// 申报提交
        /// </summary>
        public void DeclareSubmit()
        {
            var postData = new ReqDeclareSubmit() {
                bizXml = "提交报文Base64加密字符串",
                nsqxdm = "02",
                nsrsbh = "税号",
                sbzlbh = "10101",
                skssqq = "2019-10-01",
                skssqz = "2019-10-31"
            };

            var conf = new Configs();
            var sdk = new GoldenSDK(conf);
            var resp = sdk.HttpRequest<ReqDeclareSubmit, RespPubParm<object>>(DeclareApiAddress.DECLARE_SUBMIT, postData);
            Debug.WriteLine("DeclareSubmit");
            if (resp.code == (int)EReqErrCode.S0)
            {
                //success
                var result = resp.data;
                Debug.WriteLine(JsonConvert.SerializeObject(result));
            }
            else
            {
                //error
                Debug.WriteLine(resp.message);
            }
        }
    }
}














