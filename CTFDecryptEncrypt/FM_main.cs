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
    public partial class FM_main : Form
    {
        public FM_main()
        {
            InitializeComponent();
        }
        #region Base64/32模块
        private void btn_DeBase64_Click(object sender, EventArgs e)
        {
            text_Base_output.Text = DecryptEncrypt.d_base64(text_Base_input.Text);
        }

        private void btn_EnBase64_Click(object sender, EventArgs e)
        {
            text_Base_output.Text = DecryptEncrypt.e_base64(text_Base_input.Text);
        }

        private void btn_DeBase32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tools.deamwork.com/crypt/decrypt/base32decode.html");
        }

        private void btn_Base642Pic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vgot.net/test/image2base64.php");
        }

        private void btn_Pic2Base64_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tool.oschina.net/encrypt?type=4");
        }
        #endregion
        #region JS模块
        private void btn_JS_mix_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tool.chinaz.com/js.aspx");
        }
        #endregion
        #region Caesar模块
        private void btn_Caesar_start_Click(object sender, EventArgs e)
        {
            if(Caesar_compar.Checked == false)
            {
                text_Caesar_output.Text = 
                    DecryptEncrypt.caesar(text_Caesar_input.Text, (int)Caesar_choice.Value, Caesar_AllAscii.Checked);
            }
            if (Caesar_compar.Checked == true)
            {
                string str1= "-------------\r\n原文:"+ text_Caesar_input.Text; ;
                text_Caesar_output.Text += str1;
                string str2= "  +" + Caesar_choice.Value + "为：";
                text_Caesar_output.Text += str2;
                text_Caesar_output.Text += 
                    DecryptEncrypt.caesar(text_Caesar_input.Text, (int)Caesar_choice.Value, Caesar_AllAscii.Checked);
                text_Caesar_output.Text += "\r\n";
            }
        }

        private void btn_Caesar_clear_Click(object sender, EventArgs e)
        {
            text_Caesar_output.Text = "";
        }
        #endregion
        #region MD5模块
        private void btn_cmd5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cmd5.com/");
        }

        private void btn_chamd5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.chamd5.org/");
        }

        private void btn_pmd5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://pmd5.com/");
        }

        private void btn_md5_Click(object sender, EventArgs e)
        {
            text_md5.Text = DecryptEncrypt.md5(text_md5.Text);
        }
        #endregion

    }
}
