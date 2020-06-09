/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/26 19:56:07
 * Name ReqInvoiceBlue
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

using System.Collections.Generic;

namespace GoldenCloud.Declare.Models
{
    /// <summary>
    /// 申报提交-用于客户提交申报请求报文
    /// </summary>
    public class ReqDeclareSubmit
    {
        /// <summary>
        /// 纳税人识别号
        /// <![CDATA[]]>
        /// <para>示例-"税号"</para>
        /// </summary>
        public string nsrsbh { get; set; }

        /// <summary>
        /// 申报种类编码,具体值参考码表
        /// <![CDATA[]]>
        /// <para>示例-10101</para>
        /// </summary>
        public string sbzlbh { get; set; }

        /// <summary>
        /// 纳税期限代码
        /// <![CDATA[01:按次、02:月度、03:季度、04:年度、05:半年度]]>
        /// <para>示例-02</para>
        /// </summary>
        public string nsqxdm { get; set; }

        /// <summary>
        /// 所属期起
        /// <![CDATA[格式yyyy-MM-dd]]>
        /// <para>示例-2019-10-01</para>
        /// </summary>
        public string skssqq { get; set; }

        /// <summary>
        /// 所属期止
        /// <![CDATA[格式yyyy-MM-dd]]>
        /// <para>示例-2019-10-31</para>
        /// </summary>
        public string skssqz { get; set; }

        /// <summary>
        /// 提交报文
        /// <![CDATA[内容参考:报表管理->报表前置->报文查询（选择地区+税种编码+报文类型）]]>
        /// <para>示例-"提交报文Base64加密字符串"</para>
        /// </summary>
        public string bizXml { get; set; }
    }
}