using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTFDecryptEncrypt
{
    static class DecryptEncrypt
    {
        /// <summary>
        /// base64加密解密
        /// http://blog.163.com/li_wangyuan/blog/static/52060062009113042559573/
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public string d_base64(string text)  //base64->string
        {
            try
            {
                return System.Text.ASCIIEncoding.Default.GetString(Convert.FromBase64String(text));
            }
            catch
            {
                MessageBox.Show("输入有误");
                return "";
            }
        }
        static public string e_base64(string text)  //string->base64
        {
            try
            {
                System.Text.Encoding encode = System.Text.Encoding.ASCII;
                byte[] bytedata = encode.GetBytes(text);
                return Convert.ToBase64String(bytedata, 0, bytedata.Length);
            }
            catch
            {
                MessageBox.Show("输入有误");
                return "";
            }
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
            if (symbol) //保留符号
            {
                for (int i = 0; i < length; i++)
                {
                    char temp = text[i];
                    temp = (char)(temp + num);
                    output += temp;
                }
            }

            return output;
        }


    }
}
