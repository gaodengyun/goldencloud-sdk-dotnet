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

namespace GoldenCloud.Declare
{
    /// <summary>
    /// API地址集合
    /// </summary>
    public class DeclareApiAddress
    {
        /// <summary>
        /// 申报作废
        /// </summary>
        public const string DECLARE_CANCEL = "/declare-api/cancel/v1";

        /// <summary>
        /// 申报初始化
        /// </summary>
        public const string DECLARE_INIT = "/declare-api/init/v1";

        /// <summary>
        /// 申报缴款
        /// </summary>
        public const string DECLARE_PAY = "/declare-api/pay/v1";

        /// <summary>
        /// 申报查询
        /// </summary>
        public const string DECLARE_QUERY = "/declare-api/query/v1";

        /// <summary>
        /// 申报登记
        /// </summary>
        public const string DECLARE_REGISTER = "/declare-api/register/v1";

        /// <summary>
        /// 申报提交
        /// </summary>
        public const string DECLARE_SUBMIT = "/declare-api/submit/v1";
    }
}