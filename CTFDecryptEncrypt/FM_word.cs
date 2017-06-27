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
    public partial class FM_word : Form
    {
        public FM_word()
        {
            InitializeComponent();
        }

        public void getPipe(string str)
        {
            text_WordInput.Text = str;
            this.Show();
        }

        private void btn_WordUp_Click(object sender, EventArgs e)
        {
            text_WordOutput.Text = text_WordInput.Text.ToUpper();
        }

        private void btn_WordLow_Click(object sender, EventArgs e)
        {
            text_WordOutput.Text = text_WordInput.Text.ToLower();
        }
        
        private void btn_WordReplace_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_WordInput.Text.Contains(text_WordFind.Text))
                    text_WordOutput.Text = text_WordInput.Text.Replace(text_WordFind.Text, text_WordReplace.Text);
                else
                    text_WordOutput.Text = "没有找到" + text_WordFind.Text;
            }
            catch
            {
            }
        }

        private void btn_WordFind_Click(object sender, EventArgs e)
        {
            try
            {
                string find = text_WordFind.Text;
                if (text_WordInput.Text.Contains(find))
                    text_WordOutput.Text = text_WordInput.Text.Replace(find, "【" + find + "】");
                else
                    text_WordOutput.Text = "没有找到" + find;
            }
            catch
            {
            }

        }
        
        private void text_WordInput_TextChanged(object sender, EventArgs e)
        {
            text_WordLength.Text = Convert.ToString(text_WordInput.Text.Length);
        }

        private void btn_WordReverse_Click(object sender, EventArgs e)
        {
            string res = "";
            for (int i = text_WordInput.Text.Length-1; i >= 0; i--)
            {
                res += text_WordInput.Text[i];
            }
            text_WordOutput.Text = res;
        }
    }
}
