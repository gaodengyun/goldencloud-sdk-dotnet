using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoldenCloud.Invoice;

namespace GoldenCloudExamples.Invoice
{
    class Program
    {
        /// <summary>
        /// 注：要调试该Program中的Main函数时，需把Main1改成Main,并且把其他Program中的Main改为Main1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //发票相关接口
            var invoiceExp = new InvoiceExamples();
            invoiceExp.InvoiceBlue();
        }
    }
}
