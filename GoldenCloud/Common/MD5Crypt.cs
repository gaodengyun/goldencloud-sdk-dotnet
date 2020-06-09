/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/27 11:38:23
 * Name MD5Crypt
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

using System;
using System.Security.Cryptography;
using System.Text;

namespace GoldenCloud.Common
{
    /// <summary>
    /// MD5加密类
    /// </summary>
    public class MD5Crypt
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="strText">需要进行加密的字符串</param>
        /// <returns>MD5加密结果</returns>
        public static string MD5Encrypt(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = Encoding.UTF8.GetBytes(strText);//将字符编码为一个字节序列
            byte[] md5data = md5.ComputeHash(data);//计算data字节数组的哈希值
            md5.Clear();
            string str = "";
            for (int i = 0; i < md5data.Length; i++)
            {
                str += md5data[i].ToString("x").PadLeft(2, '0');
            }
            return str;
        }

        /// <summary>
        /// MD5加密16位
        /// </summary>
        /// <param name="strText">需要进行加密的字符串</param>
        /// <returns>加密后的结果【大写】</returns>
        public static string MD5Encrypt16(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string str = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(strText)), 4, 8);
            md5.Clear();
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Replace("-", "").ToLower();
            }

            return str;
        }

        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="pwd">密码</param>
        /// <param name="scal">随机码</param>
        /// <returns>返回加密后的密码字符</returns>
        public static string MD5EncryptPwd(string pwd, string scal)
        {
            return MD5Encrypt(pwd + scal);
        }
    }
}