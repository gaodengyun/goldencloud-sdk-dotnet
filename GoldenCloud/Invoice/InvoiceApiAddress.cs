/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 23:07:49
 * Name ApiAddress
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

namespace GoldenCloud.Invoice
{
    /// <summary>
    /// API地址集合
    /// </summary>
    public class InvoiceApiAddress
    {
        /// <summary>
        /// 发票开具
        /// </summary>
        public const string INVOICE_BLUE = "/tax-api/invoice/blue/v1";

        /// <summary>
        /// 发票冲红
        /// </summary>
        public const string INVOICE_RED = "/tax-api/invoice/red/v1";

        /// <summary>
        /// 开具发票查询
        /// </summary>
        public const string INVOICE_QUERY = "/tax-api/invoice/query/v1";
    }
}