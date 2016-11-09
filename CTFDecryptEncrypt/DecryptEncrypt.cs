using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CTFDecryptEncrypt
{
    static class DecryptEncrypt
    {
        /// <summary>
        /// base64加密解密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public string Base64Decode(string str)  //base64->string
        {
            try
            {
                return System.Text.ASCIIEncoding.Default.GetString(Convert.FromBase64String(str));
            }
            catch
            {
                MessageBox.Show("输入有误");
                return "";
            }
        }
        static public string Base64Encode(string str)  //string->base64
        {
            try
            {
                System.Text.Encoding encode = System.Text.Encoding.ASCII;
                byte[] bytedata = encode.GetBytes(str);
                return Convert.ToBase64String(bytedata, 0, bytedata.Length);
            }
            catch
            {
                MessageBox.Show("输入有误");
                return "";
            }
        }
        //https://github.com/koike/Base32
        public static string Base32Encode(string str)
        {
            var bin = "";
            foreach (var _ in str.Select(c => Convert.ToString(c, 16)))
            {
                bin += Convert.ToString(Convert.ToInt32(_[0] + "", 16), 2).PadLeft(4, '0');
                bin += Convert.ToString(Convert.ToInt32(_[1] + "", 16), 2).PadLeft(4, '0');
            }
            while (bin.Length % 5 != 0)
            {
                bin += '0';
            }

            var bins = new string[bin.Length / 5];
            for (var i = 0; i < bins.Length; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    bins[i] += bin[i * 5 + j];
                }
            }

            str = "";
            foreach (var n in bins.Select(t => Convert.ToInt32(t, 2)))
            {
                if (n < 26)
                {
                    str += (char)(n + 0x41);
                }
                else
                {
                    str += (char)(n + 0x32 - 26);
                }
            }

            while (str.Length % 8 != 0)
            {
                str += '=';
            }

            return str;
        }
        public static string Base32Decode(string str)
        {
            str = Regex.Replace(str, "=", "");
            var bin = "";
            foreach (var t in str)
            {
                var n = 0;
                if (t < 0x38)
                {
                    n = t - 0x30 + 24;
                }
                else
                {
                    n = t - 0x41;
                }
                bin += Convert.ToString(n, 2).PadLeft(5, '0');
            }

            while (bin.Length % 4 != 0 && bin[bin.Length - 1].Equals('0'))
            {
                bin = bin.Remove(bin.Length - 1);
            }

            var s = "";

            for (var i = 0; i < bin.Length / 4; i++)
            {
                var _ = "";
                for (var j = 0; j < 4; j++)
                {
                    _ += bin[i * 4 + j];
                }
                s += Convert.ToString(Convert.ToInt32(_, 2), 16);
            }

            str = "";

            for (var i = 0; i < s.Length / 2; i++)
            {
                var _ = s[i * 2] + "" + s[i * 2 + 1];
                str += (char)Convert.ToInt32(_, 16);
            }

            return str;
        }
       
        /// <summary>
        /// Caesar加密解密
        /// </summary>
        /// <param name="text">原文</param>
        /// <param name="num">移动位数</param>
        /// <param name="symbol">是否保留符号</param>
        /// <returns></returns>
        static public string caesar(string text,int num,bool symbol)
        {
            //a-z:97-122;A-Z:65-90;0-9:48-57
            string output = "";int length = text.Length;
            if (symbol) //带符号加解密
            {
                for (int i = 0; i < length; i++)
                {
                    char temp = text[i];
                    temp = (char)(temp + num);
                    output += temp;
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    char temp = text[i];
                    int asciinum = temp + num;
                    if (temp < 58 && temp > 47) //数字
                    {
                        if (asciinum > 77)
                            asciinum = asciinum - 30;
                        if (asciinum > 67)
                            asciinum = asciinum - 20;
                        if (asciinum > 57)
                            asciinum = asciinum - 10;
                    }
                    else if (temp < 91 && temp > 64) //A-Z
                    {
                        if (asciinum > 90)
                            asciinum = asciinum - 26;
                    }
                    else if (temp < 123 && temp > 96) //a-z
                    {
                        if (asciinum > 122)
                            asciinum = asciinum - 26;
                    }
                    else //对不是字母和阿拉伯数字的字符保留
                    {
                        asciinum = temp;
                    }
                    temp = (char)(asciinum);
                    output += temp;
                }
            }
            return output;
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public string md5(string text)
        {
            byte[] result = Encoding.Default.GetBytes(text);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            string encryptResult = BitConverter.ToString(output).Replace("-", "");
            return encryptResult;
        }


    }
   


}
