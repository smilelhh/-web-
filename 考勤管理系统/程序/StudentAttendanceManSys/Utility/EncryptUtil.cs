using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Utility
{
    public class EncryptUtil
    {
        public static string MD5Encrypt(string encryptString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] data = System.Text.Encoding.Default.GetBytes(encryptString);//将字符编码为一个字节序列 
            byte[] md5data = md5.ComputeHash(data);//计算data字节数组的哈希值 
            md5.Clear();
            string str = "";
            for (int i = 0; i < md5data.Length - 1; i++)
            {
                str += md5data[i].ToString("x").PadLeft(2, '0');
            }

            return str; 
        }
    }
}
