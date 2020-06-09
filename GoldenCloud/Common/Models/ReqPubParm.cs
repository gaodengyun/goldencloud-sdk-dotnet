/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 22:36:22
 * Name ReqPubParm
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

namespace GoldenCloud.Common.Models
{
    /// <summary>
    /// 公共参数
    /// </summary>
    public class ReqPubParm
    {
        /// <summary>
        /// 签名算法 支持 RSA-SHA256 和 HMAC-SHA256，区分大小写
        /// </summary>
        public string algorithm { get; set; }

        /// <summary>
        /// appkey
        /// </summary>
        public string appkey { get; set; }

        /// <summary>
        /// 6位随机数字
        /// </summary>
        public string nonce { get; set; }

        /// <summary>
        /// 秒级时间戳
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string signature { get; set; }
    }
}