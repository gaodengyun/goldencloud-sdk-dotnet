/*
 * Copyright (c) 2020 WeiKe
 * Revision: 5.*.*.*
 * CLR: 4.0.30319.42000
 * Date 2020/5/27 11:38:23
 * Name SHA256Crypt
 * Create on device ZPS.ZPS
 * Author Create By ZPAN
 * Describe something
 *
 */

using System;
using System.Security.Cryptography;
using System.Text;

using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace GoldenCloud.Common
{
    /// <summary>
    /// SHA256加密类
    /// </summary>
    public class SHA256Crypt
    {
        /// <summary>
        /// SHA256加密
        /// </summary>
        /// <param name="message">需要进行加密的字符串</param>
        /// <returns>SHA256加密结果</returns>
        public static string SHA256Encrypt(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);//将字符编码为一个字节序列
            byte[] hash = SHA256Managed.Create().ComputeHash(bytes);//计算bytes字节数组的哈希值

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("x").PadLeft(2, '0'));
            }
            return builder.ToString();
        }

        /// <summary>
        /// HMAC-SHA256加密
        /// </summary>
        /// <param name="message">需要进行加密的字符串</param>
        /// <param name="secret">密钥</param>
        /// <returns></returns>
        public static string HMACSHA256Encrypt(string message, string secret)
        {
            var encoding = Encoding.UTF8;
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }

        /// <summary>
        /// RSA-SHA256加签
        /// </summary>
        /// <param name="str">需签名的数据</param>
        /// <param name="privateKey">私钥</param>
        /// <returns>签名后的值</returns>
        public static string RSASHA256Encrypt(string content, string privateKey)
        {
            var result = string.Empty;
            try
            {
                //SHA256withRSA
                //根据需要加签时的哈希算法转化成对应的hash字符节
                byte[] bt = Encoding.UTF8.GetBytes(content);
                var sha256 = new SHA256CryptoServiceProvider();
                byte[] rgbHash = sha256.ComputeHash(bt);

                RSACryptoServiceProvider key = new RSACryptoServiceProvider();
                key.FromXmlString(privateKey);
                RSAPKCS1SignatureFormatter formatter = new RSAPKCS1SignatureFormatter(key);
                formatter.SetHashAlgorithm("SHA256");//此处是你需要加签的hash算法，需要和上边你计算的hash值的算法一致，不然会报错。
                byte[] inArray = formatter.CreateSignature(rgbHash);
                result = Convert.ToBase64String(inArray);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="str">待验证的字符串</param>
        /// <param name="sign">加签之后的字符串</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>签名是否符合</returns>
        public static bool RSASHA256SignCheck(string content, string sign, string publicKey)
        {
            try
            {
                byte[] bt = Encoding.UTF8.GetBytes(content);
                var sha256 = new SHA256CryptoServiceProvider();
                byte[] rgbHash = sha256.ComputeHash(bt);

                RSACryptoServiceProvider key = new RSACryptoServiceProvider();
                key.FromXmlString(publicKey);
                RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(key);
                deformatter.SetHashAlgorithm("SHA256");
                byte[] rgbSignature = Convert.FromBase64String(sign);
                if (deformatter.VerifySignature(rgbHash, rgbSignature))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}