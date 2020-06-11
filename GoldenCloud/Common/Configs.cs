/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 22:23:27
 * Name Configs
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

using System;
using System.Collections.Generic;

using GoldenCloud.Common.Models;

namespace GoldenCloud.Common
{
    /// <summary>
    /// SDK配置
    /// </summary>
    public class Configs
    {
        private Dictionary<EApiEnv, string> _baseUrl;

        /// <summary>
        /// Appkey
        /// </summary>
        public string Appkey { get; set; }

        /// <summary>
        /// Appsecret
        /// </summary>
        public string Appsecret { get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        public EApiEnv Env { get; set; }

        /// <summary>
        /// 接口版本号
        /// </summary>
        public string Ver { get; set; }

        /// <summary>
        /// 签名算法，支持 RSA-SHA256 和 HMAC-SHA256
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// PrivateKey 签名私钥
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// PublicKey 验签公钥
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// 接口地址
        /// </summary>
        public string BaseUrl
        {
            get
            {
                if (_baseUrl.TryGetValue(Env, out var baseUrl))
                {
                    return baseUrl;
                }
                else
                {
                    throw new Exception("not setting apiURL with env");
                }
            }
        }

        /// <summary>
        /// 开发者简写
        /// </summary>
        public string DevShorthand { get; set; }

        /// <summary>
        /// 官网
        /// </summary>
        public string Website { get; set; }

        public Configs()
        {
            _baseUrl = new Dictionary<EApiEnv, string>() { { EApiEnv.Test, "https://apigw-test.goldentec.com" }, { EApiEnv.Prod, "https://openapi.wetax.com.cn" }, };

            Ver = "1.0.0";
#if RELEASE
            Appkey = "";
            Appsecret = "";
            DevShorthand = "";
            Website = "";
            Algorithm="";
            PrivateKey="";
            PublicKey="";

#else
            Appkey = "";
            Appsecret = "";
            DevShorthand = "";
            Website = "";
            Algorithm = "HMAC-SHA256";
            PrivateKey = "";
            PublicKey = "";
#endif
        }
    }
}