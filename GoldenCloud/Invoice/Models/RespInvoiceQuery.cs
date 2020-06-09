/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 22:00:08
 * Name RespInvoiceQuery
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

namespace GoldenCloud.Invoice.Models
{
    public class RespInvoiceQuery
    {
        /// <summary>
        /// 商户订单号
        /// <![CDATA[开发者接入方业务订单唯一标识，此字段与order_sn不会同时为空]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string order_id { get; set; }

        /// <summary>
        /// 高灯方商户订单号
        /// <![CDATA[开发者商户订单号对应的高灯方商户订单唯一标识，此字段与order_id不会同时为空]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 发票状态
        /// <para>0：无效状态</para>
        /// <para>1：开票中</para>
        /// <para>2：开票失败</para>
        /// <para>3：已开票待签章</para>
        /// <para>4：签章失败</para>
        /// <para>5：开票成功</para>
        /// <para>6：待作废</para>
        /// <para>7：作废失败</para>
        /// <para>8：作废成功</para>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// <para>注意：此字段定义与开票接口异步通知结果中的 staus 的定义不一样 ，注意区分</para>
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 开票描述
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 开票日期
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string ticket_date { get; set; }

        /// <summary>
        /// 发票号码
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string ticket_sn { get; set; }

        /// <summary>
        /// 发票代码
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string ticket_code { get; set; }

        /// <summary>
        /// 检验码
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string check_code { get; set; }

        /// <summary>
        /// 含税金额(元)
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string amount_with_tax { get; set; }

        /// <summary>
        /// 不含税金额(元)
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string amount_without_tax { get; set; }

        /// <summary>
        /// 税额(元)
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string tax_amount { get; set; }

        /// <summary>
        /// 是否被红冲
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string is_red_washed { get; set; }

        /// <summary>
        /// pdf地址
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-</para>
        /// <para>示例-</para>
        /// </summary>
        public string pdf_url { get; set; }
    }
}