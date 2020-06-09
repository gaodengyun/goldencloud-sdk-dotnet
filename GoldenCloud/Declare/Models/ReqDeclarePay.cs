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
    /// 申报缴款-申报成功之后进行缴款操作
    /// </summary>
    public class ReqDeclarePay
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
        /// 三方协议号
        /// <![CDATA[0 直接获取结果 1 重新发起请求,具体说明参考注意事项]]>
        /// <para>示例-xxxx</para>
        /// </summary>
        public string sfxyh { get; set; }

        /// <summary>
        /// 三方协议缴款时进行扣款的银行账号
        /// <![CDATA[]]>
        /// <para>示例-xxxxxxxxxxx</para>
        /// </summary>
        public string sfxyyhzh { get; set; }
    }
}