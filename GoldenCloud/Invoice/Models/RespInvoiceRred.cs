/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 22:03:37
 * Name RespInvoiceRred
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

namespace GoldenCloud.Invoice.Models
{
    public class RespInvoiceRred
    {
        /// <summary>
        /// 红冲状态
        /// <![CDATA[]]>
        /// <para>0：提交红冲成功【开票结果会通过异步通知，开发者可以通过查询接口手动进行查询】</para>
        /// <para>1：提交红冲失败</para>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 提交红冲描述
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public int message { get; set; }

        /// <summary>
        /// 高灯方商户订单号
        /// <![CDATA[开发者商户订单号对应的高灯方商户订单唯一标识((开具蓝票时返回值)]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public int order_sn { get; set; }

        /// <summary>
        /// 高灯红票发票唯一标识
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public int invoice_id { get; set; }
    }
}