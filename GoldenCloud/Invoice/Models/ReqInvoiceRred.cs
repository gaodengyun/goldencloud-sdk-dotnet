/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 21:43:21
 * Name ReqInvoiceRred
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

using System.Collections.Generic;

namespace GoldenCloud.Invoice.Models
{
    /// <summary>
    /// 发票冲红
    /// </summary>
    internal class ReqInvoiceRred
    {
        /// <summary>
        /// 冲红发票信息
        /// </summary>
        public List<InvoiceRred> invoices { get; set; }
    }

    /// <summary>
    /// 红冲发票信息
    /// </summary>
    public class InvoiceRred
    {
        /// <summary>
        /// 销方纳税人识别号（销方票面信息）
        /// <![CDATA[即统一社会信用代码（一般是15、17、18、20位长度位数字或大写字母，字母I、O、S、V、Z除外）]]>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-</para>
        /// </summary>
        public string seller_taxpayer_num { get; set; }

        /// <summary>
        /// 发票结果回传地址
        /// <![CDATA[接收平台推送的开票结果消息地址，可参见【开票结果异步通知】]]>
        /// <para>必选-是</para>
        /// <para>长度-500</para>
        /// <para>示例-</para>
        /// </summary>
        public string callback_url { get; set; }

        /// <summary>
        /// 高灯方商户订单号
        /// <![CDATA[开发者商户订单号对应的高灯方商户订单唯一标识((开具蓝票时返回值)]]>
        /// <para>此字段与order_id不能同时为空</para>
        /// <para>必选-否</para>
        /// <para>长度-64</para>
        /// <para>示例-</para>
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 商户订单号
        /// <![CDATA[开发者接入方业务订单唯一标识(开具蓝票开具时填入值)]]>
        /// <para>必选-否</para>
        /// <para>长度-64</para>
        /// <para>示例-</para>
        /// </summary>
        public string order_id { get; set; }

        /// <summary>
        /// 红字信息表编码
        /// <![CDATA[专票红冲时需申请红字信息表，此字段专票红冲时必填]]>
        /// <para>此字段与order_sn不能同时为空</para>
        /// <para>必选-否</para>
        /// <para>长度-64</para>
        /// <para>示例-</para>
        /// </summary>
        public string red_serial_no { get; set; }
    }
}