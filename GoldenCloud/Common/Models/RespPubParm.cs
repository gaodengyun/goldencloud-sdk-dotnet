/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 22:43:02
 * Name RespPubParm
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

namespace GoldenCloud.Common.Models
{
    /// <summary>
    /// 公共返回参数
    /// </summary>
    public class RespPubParm<T>
    {
        /// <summary>
        /// 返回code
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 数据体
        /// </summary>
        public T data { get; set; }
    }
}