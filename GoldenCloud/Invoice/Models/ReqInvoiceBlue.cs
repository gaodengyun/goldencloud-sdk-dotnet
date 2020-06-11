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

namespace GoldenCloud.Invoice.Models
{
    /// <summary>
    /// 发票开具对象
    /// </summary>
    public class ReqInvoiceBlue
    {
        /// <summary>
        /// 销方名称（销方票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业名称填入 【名称不含有特殊符号：’<’ ‘>’ ‘转义符’ ‘双引号’ 逗号’等特殊符号】]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-海南高灯科技有限公司</para>
        /// </summary>
        public string seller_name { get; set; }

        /// <summary>
        /// 销方纳税人识别号（销方票面信息）
        /// <![CDATA[即统一社会信用代码（一般是15、17、18、20位长度位数字或大写字母，字母I、O、S、V、Z除外）]]>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-91469027MA5RH09M0R</para>
        /// </summary>
        public string seller_taxpayer_num { get; set; }

        /// <summary>
        /// 销方地址（销方票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业地址填入]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-海南省老城高新技术产业示范区海南生态软件园</para>
        /// </summary>
        public string seller_address { get; set; }

        /// <summary>
        /// 销方电话（销方票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业电话填入]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-0755-86888888（若无座机可输入手机号：18285162583）</para>
        /// </summary>
        public string seller_tel { get; set; }

        /// <summary>
        /// 销方银行名称（销方票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业银行名称填入]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-中国工商银行深圳南山科苑分行</para>
        /// </summary>
        public string seller_bank_name { get; set; }

        /// <summary>
        /// 销方银行账号（销方票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业银行账号填入【纯数字，不能有汉字、字母或其它字符，首位数字不能为0】]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-62128124020000300000</para>
        /// </summary>
        public string seller_bank_account { get; set; }

        /// <summary>
        /// 抬头类型：1：个人/政府事业单位；2：企业
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-1</para>
        /// <para>示例-Exp：1</para>
        /// </summary>
        public int title_type { get; set; }

        /// <summary>
        /// 购方名称
        /// <![CDATA[【购方票面信息，名称不含有特殊符号：’<’ ‘>’ ‘转义符’ ‘双引号’ ‘逗号’等特殊符号】]]>
        /// <para>必选-是</para>
        /// <para>长度-100</para>
        /// <para>示例-海南高灯科技有限公司</para>
        /// </summary>
        public string buyer_title { get; set; }

        /// <summary>
        /// 购方纳税人识别号（购方票面信息）
        /// <![CDATA[若抬头类型为2时，必传;即统一社会信用代码（一般是15、17、18、20位长度位数字或大写字母，字母I、O、S、V、Z除外）]]>
        /// <para>必选-否</para>
        /// <para>长度-20</para>
        /// <para>示例-91469027MA5RH09M0R</para>
        /// </summary>
        public string buyer_taxpayer_num { get; set; }

        /// <summary>
        /// 购方地址（购方票面信息）
        /// <![CDATA[若开具增值税专用发票时必传]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-海南省老城高新技术产业示范区海南生态软件园</para>
        /// </summary>
        public string buyer_address { get; set; }

        /// <summary>
        /// 购方银行名称（购方票面信息）
        /// <![CDATA[若开具增值税专用发票时必填]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-中国工商银行</para>
        /// </summary>
        public string buyer_bank_name { get; set; }

        /// <summary>
        /// 购方银行账号（购方票面信息）
        /// <![CDATA[若开具增值税专用发票时必填]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-62128124020000300000</para>
        /// </summary>
        public string buyer_bank_account { get; set; }

        /// <summary>
        /// 购方电话（购方票面信息）
        /// <![CDATA[若开具增值税专用发票时必传]]>
        /// <para>必选-否</para>
        /// <para>长度-30</para>
        /// <para>示例-0755-86888888（若无座机可输入手机号：18285162583）</para>
        /// </summary>
        public string buyer_phone { get; set; }

        /// <summary>
        /// 收票人邮箱（发票推送）
        /// <![CDATA[如果填入平台将推送发票至收票方邮箱，如果不填入，则由开发者自行推送发票]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-yunpiaoer@wetax.com.cn</para>
        /// </summary>
        public string buyer_email { get; set; }

        /// <summary>
        /// 收票人手机号
        /// <![CDATA[如果填入平台将推送开票结果短信至收票人手机号；如果不填入，则不推送]]>
        /// <para>必选-否</para>
        /// <para>长度-30</para>
        /// <para>示例-18285162583</para>
        /// </summary>
        public string taker_phone { get; set; }

        /// <summary>
        /// 商户订单号
        /// <![CDATA[开发者接入方业务订单唯一标识]]>
        /// <para>必选-是</para>
        /// <para>长度-64</para>
        /// <para>示例-gd_1904242006002627690</para>
        /// </summary>
        public string order_id { get; set; }

        /// <summary>
        /// 开具发票类型
        /// <![CDATA[默认为026，004：增值税专用发票 ,007：增值税普通发票 ,026：增值税电子发票 ,025：增值税卷式发票 ,032：区块链电子发票]]>
        /// <para>必选-否</para>
        /// <para>长度-3</para>
        /// <para>示例-26</para>
        /// </summary>
        public string invoice_type_code { get; set; }

        /// <summary>
        /// 发票结果回传地址
        /// <![CDATA[接收平台推送的开票结果消息地址，可参见【开票结果异步通知】]]>
        /// <para>必选-是</para>
        /// <para>长度-500</para>
        /// <para>示例-开发者服务器地址</para>
        /// </summary>
        public string callback_url { get; set; }

        /// <summary>
        /// 开票人姓名（票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业默认开票人填入]]>
        /// <para>必选-否</para>
        /// <para>长度-16</para>
        /// <para>示例-覃高</para>
        /// </summary>
        public string drawer { get; set; }

        /// <summary>
        /// 收款人姓名（票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业默认收款人填入]]>
        /// <para>必选-否</para>
        /// <para>长度-16</para>
        /// <para>示例-戴灯</para>
        /// </summary>
        public string payee { get; set; }

        /// <summary>
        /// 复核人姓名（票面信息）
        /// <![CDATA[如果填入则根据填入信息填入票面，如果不填入，则默认读取商户平台销方企业默认复核人填入]]>
        /// <para>必选-否</para>
        /// <para>长度-16</para>
        /// <para>示例-刘强</para>
        /// </summary>
        public string checker { get; set; }

        /// <summary>
        /// 税盘号：
        /// 1、使用电脑PC云票儿助手客户端时必填，要区别航信金税盘(白色)、百旺税控盘(黑色)和Ukey盘， [航信主盘传0，航信分盘传分机号，如：1.2.3等，百旺传12位盘号（前面的33-或44-不用输入），Ukey传盘背后12位的盘号]
        /// 2、使用高灯WCS时，如果不填入，则采用轮询当前在线托管的盘进行开票，如果填入，则指定对应盘进行开票，航信和百旺均填入12位的盘号（前面的33-或44-不用输入），不支持Ukey盘
        /// 3、使用区块链进行开票时，无需填入。
        /// <![CDATA[]]>
        /// <para>必选-否</para>
        /// <para>长度-12</para>
        /// <para>示例-661234567789</para>
        /// </summary>
        public string terminal_code { get; set; }

        /// <summary>
        /// 商家用户标识
        /// <![CDATA[用户在商户侧的唯一标识，如果填入开发者可通过这个ID请求这个ID在这个商户下开具的发票]]>
        /// <para>必选-否</para>
        /// <para>长度-40</para>
        /// <para>示例-user123456</para>
        /// </summary>
        public string user_openid { get; set; }

        /// <summary>
        /// 特殊票种标识
        /// <![CDATA[开具成品油发票时必填（08：成品油），开具其他票时可以为空]]>
        /// <para>必选-否</para>
        /// <para>长度-2</para>
        /// <para>示例-空</para>
        /// </summary>
        public string special_invoice_kind { get; set; }

        /// <summary>
        /// 征收方式
        /// <![CDATA[开具差额征税发票时必填 2：差额征税 开具普通征税发票时可以为空]]>
        /// <para>必选-否</para>
        /// <para>长度-1</para>
        /// <para>示例-2</para>
        /// </summary>
        public string zsfs { get; set; }

        /// <summary>
        /// 差额征税扣除额【单位：元（精确到小数点后2位）】
        /// <![CDATA[当 zsfs 为 2 时，此项必填]]>
        /// <para>必选-否</para>
        /// <para>长度-20</para>
        /// <para>示例-66.66</para>
        /// </summary>
        public string deduction { get; set; }

        /// <summary>
        /// 含税总金额【单位：元（精确到小数点后2位）】
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-66.66</para>
        /// </summary>
        public string amount_has_tax { get; set; }

        /// <summary>
        /// 总税额【单位：元（精确到小数点后2位）】
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-66.66</para>
        /// </summary>
        public string tax_amount { get; set; }

        /// <summary>
        /// 不含税总金额【单位：元（精确到小数点后2位）】
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-66.66</para>
        /// </summary>
        public string amount_without_tax { get; set; }

        /// <summary>
        /// 备注（票面信息）
        /// <para>1、正常发票备注不超过180字节，如是差额征税或红字发票等，系统默认会填入备注信息，默认信息长度加用户填入长度不超过180字节；</para>
        /// <para>2、差额征税默认信息长度最少18字节（即金额1.00）（例：差额征税：1.00）；</para>
        /// <para>3、电子红字发票默认信息长度最少46字节（即发票代码12位，发票号码8位）（例：对应正式发票代码：012345678912、号码：01234567）</para>
        /// <para>4、专用红字发票默认信息长度最少50字节（即信息表编号16位）（例：开具红字增值税专用发票信息表编号0123456789012345）</para>
        /// <![CDATA[]]>
        /// <para>必选-否</para>
        /// <para>长度-180</para>
        /// <para>示例-行程详情：2019年10月1日 15：30 深圳-北京高速</para>
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 门店编码
        /// <![CDATA[通过登录商户服务平台门店端可查看门店编码，云南区块链商户若需开具冠名发票必填，非云南区块链商户不传]]>
        /// <para>必选-否</para>
        /// <para>长度-100</para>
        /// <para>示例-FFX001</para>
        /// </summary>
        public string store_no { get; set; }

        /// <summary>
        /// 发票模板
        /// <![CDATA[普通区块链电子发票样（默认）.2．丽江 3．石林 4．新版自定义模板，云南区块链商户若需开具冠名发票必填，非云南区块链商户不传]]>
        /// <para>必选-否</para>
        /// <para>长度-1</para>
        /// <para>示例-1</para>
        /// </summary>
        public int template { get; set; }

        /// <summary>
        /// 预留字段、云南区块链商户，使用冠名票发票模板时必填
        /// <para>(json object)</para>
        /// <para>否</para>
        /// </summary>
        public ReqInvoiceBlueYunnan info { get; set; }

        /// <summary>
        /// 项目商品明细
        /// <para>专普票明细不超过8行,清单不超过2000行,电子发票明细不超过100行</para>
        /// </summary>
        public List<ReqInvoiceBlueGoods> items { get; set; }
    }

    /// <summary>
    /// 预留字段对象
    /// </summary>
    public class ReqInvoiceBlueYunnan
    {
        /// <summary>
        /// 入园日期
        /// <para>使用冠名票发票模板时必填</para>
        /// <para>必选-否</para>
        /// <para>示例：20200217</para>
        /// </summary>
        public string use_date { get; set; }

        /// <summary>
        /// 票据名称
        /// <para>使用冠名模板时必填</para>
        /// <para>必选-否</para>
        /// <para>示例：石林风景区门票</para>
        /// </summary>
        public string ticket_name { get; set; }
    }

    /// <summary>
    /// 项目商品明细对象
    /// </summary>
    public class ReqInvoiceBlueGoods
    {
        /// <summary>
        /// 商品名称
        /// <![CDATA[【名称不含有特殊符号：‘<’ ‘>’ ‘/’ ‘&’ 等特殊符号】]]>
        /// <para>必选-是</para>
        /// <para>长度-50</para>
        /// <para>示例-农夫山泉</para>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 税收商品编码
        /// <![CDATA[商品所属分类商品编码，详见[税收商品编码税率表]，如果通过简易接口可不填入，默认读取商户平台配置的商品名称下编码]]>
        /// <para>必选-是</para>
        /// <para>长度-40</para>
        /// <para>示例-3040201030000000000</para>
        /// </summary>
        public string tax_code { get; set; }

        /// <summary>
        /// 税收商品类别
        /// <![CDATA[指商品在商品编码中的分类名称]]>
        /// <para>必选-否</para>
        /// <para>长度-50</para>
        /// <para>示例-餐饮服务</para>
        /// </summary>
        public string tax_type { get; set; }

        /// <summary>
        /// 商品规格（商品票面信息）
        /// <![CDATA[指商品规格型号，如果填入将显示在发票票面“规格型号”栏目]]>
        /// <para>必选-否</para>
        /// <para>长度-36</para>
        /// <para>示例-MWN82CH/A</para>
        /// </summary>
        public string models { get; set; }

        /// <summary>
        /// 商品单位（商品票面信息）
        /// <![CDATA[如果填入将显示在发票票面“单位”栏目]]>
        /// <para>必选-否</para>
        /// <para>长度-14</para>
        /// <para>示例-个</para>
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// 不含税商品总价= 商品含税价总金额 / (1+税率)【单位：元（精确到小数点后2位）】
        /// <![CDATA[]]>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-66.66</para>
        /// </summary>
        public string total_price { get; set; }

        /// <summary>
        /// 商品数量
        /// <para>精确到8位，和price成对存在</para>
        /// <para>必选-否</para>
        /// <para>长度-20</para>
        /// <para>示例-1</para>
        /// </summary>
        public string total { get; set; }

        /// <summary>
        /// 不含税商品单价
        /// <para>不含税商品单价=不含税商品总价 / 数量【单位：元，精确到8位小数，和total成对存在】</para>
        /// <para>必选-否</para>
        /// <para>长度-20</para>
        /// <para>示例-66.66</para>
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 商品税率
        /// <para>请参照【税收商品编码税率表】或咨询财务【最多保留小数点后3位】</para>
        /// <para>必选-是</para>
        /// <para>长度-6</para>
        /// <para>示例-0.03</para>
        /// </summary>
        public string tax_rate { get; set; }

        /// <summary>
        /// 商品税额
        /// <para>税额 = 不含税商品总价 * 税率【单位：元（精确到小数点后2位）】</para>
        /// <para>必选-是</para>
        /// <para>长度-20</para>
        /// <para>示例-66.66</para>
        /// </summary>
        public string tax_amount { get; set; }

        /// <summary>
        /// 含税折扣总金额
        /// <para>金额必须是负数【单位：元（精确到小数点后2位）】</para>
        /// <para>必选-否</para>
        /// <para>长度-20</para>
        /// <para>示例-"-66.66"</para>
        /// </summary>
        public string discount { get; set; }

        /// <summary>
        /// 优惠政策标志 0：不使用优惠政策，1：使用优惠政策
        /// <para>1、若商品为零税率，需在零税率标识（zero_tax_flag）填写相应零税率标识，并且在增值税特殊管理（vat_special_management）填写相应的优惠说明</para>
        /// <para>2、若商品不为零税率，则仅需在增值税特殊管理中填入</para>
        /// <para>必选-否</para>
        /// <para>长度-1</para>
        /// <para>示例-0</para>
        /// </summary>
        public string preferential_policy_flag { get; set; }

        /// <summary>
        /// 零税率标识
        /// <para>0：出口零税率</para>
        /// <para>1：免税</para>
        /// <para>2：不征税</para>
        /// <para>3：普通零税率 （0\1\2时优惠政策标识应为1，空和3时优惠政策标识应为0，填入时商品税率需设置为0%）</para>
        /// <para>必选-否</para>
        /// <para>长度-1</para>
        /// <para>示例-空</para>
        /// </summary>
        public string zero_tax_flag { get; set; }

        /// <summary>
        /// 增值税特殊管理：优惠政策为1时该字段必传，根据“版本V33.0税收编码下载”显示，目前为：
        /// <para>100%先征后退</para>
        /// <para>50%先征后退</para>
        /// <para>不征税</para>
        /// <para>先征后退</para>
        /// <para>免税</para>
        /// <para>即征即退100%</para>
        /// <para>即征即退30%</para>
        /// <para>即征即退50%</para>
        /// <para>即征即退70%</para>
        /// <para>按3%简易征收</para>
        /// <para>按5%简易征收</para>
        /// <para>按5%简易征收减按1.5%计征</para>
        /// <para>按5%简易征收减按3%计征</para>
        /// <para>稀土产品</para>
        /// <para>简易征收</para>
        /// <para>超税负12%即征即退</para>
        /// <para>超税负3%即征即退</para>
        /// <para>超税负8%即征即退</para>
        /// <para>【目前仅支持按5%（3% 2% 1.5%）简易征收、免税、不征税）,preferential_policy_flag 优惠政策标识位 1 时必填】</para>
        /// <para>必选-否</para>
        /// <para>长度-50</para>
        /// <para>示例-免税</para>
        /// </summary>
        public string vat_special_management { get; set; }
    }
}