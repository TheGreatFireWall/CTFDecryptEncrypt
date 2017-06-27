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
            text_Base_output.Text = DecryptEncrypt.Base64Decode(text_Base_input.Text);
        }

        private void btn_EnBase64_Click(object sender, EventArgs e)
        {
            text_Base_output.Text = DecryptEncrypt.Base64Encode(text_Base_input.Text);
        }
        
        private void btn_Base642Pic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vgot.net/test/image2base64.php");
        }

        private void btn_Pic2Base64_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tool.oschina.net/encrypt?type=4");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            text_Base_input.Text = text_Base_output.Text;
            text_Base_output.Text = "";
        }
        private void btn_Base32Decode_Click(object sender, EventArgs e)
        {
            text_Base_output.Text = DecryptEncrypt.Base32Decode(text_Base_input.Text);
        }

        private void btn_Base32Encode_Click(object sender, EventArgs e)
        {
            text_Base_output.Text = DecryptEncrypt.Base32Encode(text_Base_input.Text);
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

        private void btn_Word_Click(object sender, EventArgs e)
        {
            FM_word son = new FM_word();
            son.Owner = this;
            son.Show();
        }

        private void btn_Conversion_Click(object sender, EventArgs e)
        {
            FM_Conversion son = new FM_Conversion();
            son.Owner = this;
            son.Show();
        }

        private void 进制转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_Conversion son = new FM_Conversion();
            son.Owner = this;
            son.Show();
        }

        private void 文本处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_word son = new FM_word();
            son.Owner = this;
            son.Show();
        }

        private void 文本处理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FM_word pipe= new FM_word();
            pipe.getPipe(text_Base_output.Text);
        }
    }
}
