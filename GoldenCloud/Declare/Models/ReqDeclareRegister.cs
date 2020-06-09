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
    /// 申报登记-基础信息登记
    /// </summary>
    public class ReqDeclareRegister
    {
        /// <summary>
        /// 纳税人识别号
        /// <![CDATA[]]>
        /// <para>示例-"税号"</para>
        /// </summary>
        public string nsrsbh { get; set; }

        /// <summary>
        /// 公司名称
        /// <![CDATA[]]>
        /// <para>示例-xxxx</para>
        /// </summary>
        public string qymc { get; set; }

        /// <summary>
        /// 地区编码
        /// <![CDATA[]]>
        /// <para>示例-34</para>
        /// </summary>
        public string dqbm { get; set; }

        /// <summary>
        /// 非必填 财务联系人,江苏必须传,其他地区
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string cwlxr { get; set; }

        /// <summary>
        /// 非必填 财务联系人联系电话,江苏必须传,其他地区
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string cwlxrlxfs { get; set; }

        /// <summary>
        /// 地税登录方式, 1 CA  2 用户名密码,此处传递枚举值:[1,2]
        /// <![CDATA[]]>
        /// <para>示例-1</para>
        /// </summary>
        public string dsdlfs { get; set; }

        /// <summary>
        /// 地税CA密码:CA方式需要
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string dscsdlmm { get; set; }

        /// <summary>
        /// 地税登录账号名称
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string dsdlyhm { get; set; }

        /// <summary>
        /// 地税登录密码
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string dsdlmm { get; set; }

        /// <summary>
        /// 国税登录方式, 1 CA  2 用户名密码,此处传递枚举值:[1,2]
        /// <![CDATA[]]>
        /// <para>示例-2</para>
        /// </summary>
        public string gsdlfs { get; set; }

        /// <summary>
        /// 国税纳税人识别号
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string gsnsrsbh { get; set; }

        /// <summary>
        /// 国税CA密码:CA方式需要
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string gscamm { get; set; }

        /// <summary>
        /// 国税登录账号名称:用户名密码方式需要
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string gsnsyhm { get; set; }

        /// <summary>
        /// 国税登录密码:用户名密码方式需要
        /// <![CDATA[]]>
        /// <para>示例-xxxx</para>
        /// </summary>
        public string gsnsmm { get; set; }

        /// <summary>
        /// 会计制度,必须传
        /// <![CDATA[]]>
        /// <para>示例-1</para>
        /// </summary>
        public string kjzd { get; set; }

        /// <summary>
        /// 纳税资格代码:001增值税一般纳税人 101增值税小规模纳税人,只有这两种,必须传枚举值[001、101]
        /// <![CDATA[]]>
        /// <para>示例-101</para>
        /// </summary>
        public string nsrzgdm { get; set; }

        /// <summary>
        /// 启用年份,必须传
        /// <![CDATA[]]>
        /// <para>示例-2019</para>
        /// </summary>
        public string qynf { get; set; }

        /// <summary>
        /// 启用月份,必须传
        /// <![CDATA[]]>
        /// <para>示例-09</para>
        /// </summary>
        public string qyyf { get; set; }

        /// <summary>
        /// 山东地区必填,公司所在国税税务局名称地区编码:37
        /// <![CDATA[]]>
        /// <para>示例-国家税务总局合肥高新技术产业开发区税务局</para>
        /// </summary>
        public string swjmc { get; set; }

        /// <summary>
        /// 登录身份 备注:传递编码【1:财务负责人 2:法定代表人 3:办税人 4:购票员】
        /// <![CDATA[]]>
        /// <para>示例-3</para>
        /// </summary>
        public string dlsf { get; set; }

        /// <summary>
        /// 手机号码
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string sjhm { get; set; }

        /// <summary>
        /// 身份证件号码
        /// <![CDATA[]]>
        /// <para>示例-""</para>
        /// </summary>
        public string sfzjhm { get; set; }
    }
}