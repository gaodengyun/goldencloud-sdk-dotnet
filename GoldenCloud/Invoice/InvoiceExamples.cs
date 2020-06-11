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
using Newtonsoft.Json;
using GoldenCloud.Common;
using GoldenCloud.Common.Models;
using GoldenCloud.Invoice.Models;

namespace GoldenCloud.Invoice
{
    public class InvoiceExamples
    {
        public void InvoiceBlue()
        {
            var postData = new ReqInvoiceBlue() {
                seller_address = null,
                seller_tel = null,
                seller_bank_account = null,
                seller_bank_name = null,

                buyer_taxpayer_num = null,
                buyer_address = null,
                buyer_bank_account = null,
                buyer_bank_name = null,
                buyer_phone = null,
                buyer_email = null,
                taker_phone = null,

                special_invoice_kind = null,
                terminal_code = null,
                zsfs = null,
                store_no = null,

                seller_name = "wkbb invoice blue test",
                seller_taxpayer_num = "your seller_taxpayer_num",

                title_type = 1,
                buyer_title = "海南高灯科技",
                order_id = Guid.NewGuid().ToString("N"),
                invoice_type_code = "032",
                callback_url = "http://www.test.com",
                drawer = "TEST",
                payee = "TEST",
                checker = "TEST",
                user_openid = Guid.NewGuid().ToString("N"),
                amount_has_tax = "66.66",
                tax_amount = "99.80",
                amount_without_tax = "88.64",
                remark = "readme",
            };

            postData.items = new System.Collections.Generic.List<ReqInvoiceBlueGoods>();
            postData.items.Add(new ReqInvoiceBlueGoods() {
                name = "海鲜真划算",
                tax_code = "your tax_code",
                models = "zyx",
                unit = "个",
                total_price = "88.46",
                total = "5",
                price = "17.22",
                tax_rate = "0.03",
                tax_amount = "8.46",
                discount = "-32.33",

                tax_type = null,
                zero_tax_flag = null,
                preferential_policy_flag = null,
                vat_special_management = null,
            });

            var conf = new Configs();
            var sdk = new GoldenSDK(conf);
            var resp = sdk.HttpRequest<ReqInvoiceBlue, RespInvoiceBlue>(InvoiceApiAddress.INVOICE_BLUE, postData);
            if (resp.code == (int)EReqErrCode.S0)
            {
                //success
                var result = resp.data;
                Debug.WriteLine(JsonConvert.SerializeObject(result));
                Debug.WriteLine(result.invoice_id);
                Debug.WriteLine(result.order_sn);
                Debug.WriteLine(result.state);
            }
            else
            {
                //error
                Debug.WriteLine(resp.message);
            }
        }
    }
}