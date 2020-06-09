/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 21:54:54
 * Name ReqInvoiceQuery
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

namespace GoldenCloud.Invoice.Models
{
    /// <summary>
    /// 开票查询
    /// </summary>
    public class ReqInvoiceQuery
    {
        /// <summary>
        /// 销方纳税人识别号（销方票面信息）
        /// <![CDATA[即统一社会信用代码（一般是15、17、18、20位长度位数字或大写字母，字母I、O、S、V、Z除外）]]>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-91469027MA5RH09M0R</para>
        /// </summary>
        public string seller_taxpayer_num { get; set; }

        /// <summary>
        /// 商户订单号
        /// <![CDATA[开发者接入方业务订单唯一标识(开具蓝票开具时填入值)此字段与order_sn不能同时为空]]>
        /// <para>必选-否</para>
        /// <para>长度-64</para>
        /// <para>示例-gd_1904242006002627690</para>
        /// </summary>
        public string order_id { get; set; }

        /// <summary>
        /// 高灯方商户订单号
        /// <![CDATA[开发者商户订单号对应的高灯方商户订单唯一标识((开具蓝票时返回值)此字段与order_id不能同时为空]]>
        /// <para>必选-否</para>
        /// <para>长度-64</para>
        /// <para>示例-6590128277141370000</para>
        /// </summary>
        public string order_sn { get; set; }

        /// <summary>
        /// 发票种类
        /// <![CDATA[0：蓝票 1：红票【该字段默认为0， 如果需要查询红票信息，本字段必须传1，否则可能查询不到需要的发票信息】]]>
        /// <para>必选-否</para>
        /// <para>长度-1</para>
        /// <para>示例-</para>
        /// </summary>
        public int is_red { get; set; }
    }
}