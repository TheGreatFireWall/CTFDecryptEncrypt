using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTFDecryptEncrypt
{
    public partial class FM_Conversion : Form
    {
        public FM_Conversion()
        {
            InitializeComponent();
            fromNum.SelectedIndex = 0;
            toNum.SelectedIndex = 0;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                int from = Convert.ToInt32(fromNum.Text);
                int to = Convert.ToInt32(toNum.Text);
                if (check(text_ConversionInput.Text, from))
                    text_ConversionOutput.Text = 
                        Conversion(text_ConversionInput.Text, from, to);
                //text_ConversionOutput.Text = 
                //    ConverHex(ConverHexToTen(text_ConversionInput.Text, from), to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private static bool check(string str, int from)
        {
            str = str.ToUpper();
            string max = str.Max().ToString();
            try
            {
                int maxint = Convert.ToInt32(max);
                return true;
            }
            catch (FormatException ex)
            {
                if (!"ABCDEF".Contains(max))
                {
                    //MessageBox.Show(ex.Message);
                    return false;
                }
                else
                    return true;
            }
        }

        static private string Conversion(string str, int from, int to)
        {
            string res = "";
            return res;
        }

        static private string ConverseTen(string str, int from)
        {
            return Convert.ToString(str, 10);
        }

        ////以下代码来自http://www.jb51.net/article/42776.htm
        //private static string ThreeSix = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        ///// <summary>
        ///// 根据字符,获取对应的十进制数据
        ///// </summary>
        ///// <param name="c"></param>
        ///// <returns></returns>
        //private static Int32 GetNumberByStr(string c)
        //{
        //    int i = ThreeSix.IndexOf(c);
        //    if (i < 0)
        //        return i;
        //    return i + 10;
        //}
        ///// <summary>
        ///// 其他进制转化到10进制
        ///// </summary>
        ///// <param name="num">需转换字符</param>
        ///// <param name="format">转化到;如转换到2进制,这里键入2</param>
        ///// <returns></returns>
        //public static long ConverHexToTen(string num, int format)
        //{
        //    long allCount = 0;
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        string s = num.Substring(i, 1);
        //        int n = 0;
        //        if (!int.TryParse(s, out n))
        //        {
        //            n = GetNumberByStr(s);
        //        }
        //        if (n < 0)
        //            throw new Exception("输入字符有误,请确保该字符真实存在");
        //        if (n > 0)
        //        {
        //            long count = 1;
        //            for (int j = 0; j < num.Length - i - 1; j++)
        //            {
        //                count *= format;
        //            }
        //            count *= n;
        //            allCount += count;
        //        }
        //    }
        //    return allCount;
        //}
        ///// <summary>
        ///// 获取相应的字符,16进制与32进制需要使用
        ///// </summary>
        ///// <param name="num"></param>
        ///// <returns></returns>
        //private static string SixFont(long num)
        //{
        //    if (num < 10)
        //        return num + "";
        //    return ThreeSix.Substring((int)num - 10, 1);
        //}
        ///// <summary>
        ///// 10进制转化成其他进制
        ///// </summary>
        ///// <param name="number">需转换字符</param>
        ///// <param name="format">转化到;如转换到2进制,这里键入2</param>
        ///// <returns></returns>
        //public static string ConverHex(long number, int format)
        //{
        //    if (number == 0)
        //        return number + "";
        //    StringBuilder str = new StringBuilder();
        //    while (number > 0)
        //    {
        //        str.Insert(0, SixFont((number % format)));
        //        number /= format;
        //    }
        //    return str.ToString();
        //}

    }
}
