/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 22:08:12
 * Name RespInvoiceBlue
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

namespace GoldenCloud.Invoice.Models
{
    /// <summary>
    ///
    /// </summary>
    public class RespInvoiceBlue
    {
        /// <summary>
        /// 开票状态
        /// <para>1：已提交(如果订单已提交开票请求并且没有开票成功，平台会根据策略进行重试开票，此时本状态表示重试开票已提交， 开票结果会通过异步通知，邮箱等方式返回， 也可以通过查询接口手动进行查询)</para>
        /// <para>2：已开票成功 （表示已经成功开过票了，不能再进行重复开票）</para>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 高灯方商户订单号
        /// <![CDATA[开发者商户订单号对应的高灯方商户订单唯一标识]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 商户订单号
        /// <![CDATA[高灯发票唯一识别号]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string invoice_id { get; set; }
    }
}