namespace CTFDecryptEncrypt
{
    partial class FM_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Base = new System.Windows.Forms.TabPage();
            this.btn_Pic2Base64 = new System.Windows.Forms.Button();
            this.btn_Base642Pic = new System.Windows.Forms.Button();
            this.btn_DeBase32 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EnBase64 = new System.Windows.Forms.Button();
            this.btn_DeBase64 = new System.Windows.Forms.Button();
            this.text_Base_output = new System.Windows.Forms.TextBox();
            this.text_Base_input = new System.Windows.Forms.TextBox();
            this.Morse = new System.Windows.Forms.TabPage();
            this.webBrowser_morse = new System.Windows.Forms.WebBrowser();
            this.Caesar = new System.Windows.Forms.TabPage();
            this.JS = new System.Windows.Forms.TabPage();
            this.btn_JS_mix = new System.Windows.Forms.Button();
            this.Url = new System.Windows.Forms.TabPage();
            this.UnicodeAscii = new System.Windows.Forms.TabPage();
            this.Hash = new System.Windows.Forms.TabPage();
            this.RailFence = new System.Windows.Forms.TabPage();
            this.Bacon = new System.Windows.Forms.TabPage();
            this.AES = new System.Windows.Forms.TabPage();
            this.MD5 = new System.Windows.Forms.TabPage();
            this.others = new System.Windows.Forms.TabPage();
            this.Brainfuck = new System.Windows.Forms.TabPage();
            this.webBrowser_Brainfuck = new System.Windows.Forms.WebBrowser();
            this.text_Caesar_input = new System.Windows.Forms.TextBox();
            this.text_Caesar_output = new System.Windows.Forms.TextBox();
            this.btn_Caesar_start = new System.Windows.Forms.Button();
            this.Caesar_choice = new System.Windows.Forms.NumericUpDown();
            this.Caesar_compar = new System.Windows.Forms.CheckBox();
            this.Caesar_AllAscii = new System.Windows.Forms.CheckBox();
            this.btn_Caesar_clear = new System.Windows.Forms.Button();
            this.webBrowser_md5 = new System.Windows.Forms.WebBrowser();
            this.btn_cmd5 = new System.Windows.Forms.Button();
            this.btn_chamd5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pmd5 = new System.Windows.Forms.Button();
            this.text_md5 = new System.Windows.Forms.TextBox();
            this.btn_md5 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Base.SuspendLayout();
            this.Morse.SuspendLayout();
            this.Caesar.SuspendLayout();
            this.JS.SuspendLayout();
            this.MD5.SuspendLayout();
            this.Brainfuck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caesar_choice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Base);
            this.tabControl.Controls.Add(this.Morse);
            this.tabControl.Controls.Add(this.Caesar);
            this.tabControl.Controls.Add(this.JS);
            this.tabControl.Controls.Add(this.Brainfuck);
            this.tabControl.Controls.Add(this.Url);
            this.tabControl.Controls.Add(this.UnicodeAscii);
            this.tabControl.Controls.Add(this.Hash);
            this.tabControl.Controls.Add(this.RailFence);
            this.tabControl.Controls.Add(this.Bacon);
            this.tabControl.Controls.Add(this.AES);
            this.tabControl.Controls.Add(this.MD5);
            this.tabControl.Controls.Add(this.others);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(811, 432);
            this.tabControl.TabIndex = 0;
            // 
            // Base
            // 
            this.Base.Controls.Add(this.btn_Pic2Base64);
            this.Base.Controls.Add(this.btn_Base642Pic);
            this.Base.Controls.Add(this.btn_DeBase32);
            this.Base.Controls.Add(this.label1);
            this.Base.Controls.Add(this.btn_EnBase64);
            this.Base.Controls.Add(this.btn_DeBase64);
            this.Base.Controls.Add(this.text_Base_output);
            this.Base.Controls.Add(this.text_Base_input);
            this.Base.Location = new System.Drawing.Point(4, 26);
            this.Base.Name = "Base";
            this.Base.Padding = new System.Windows.Forms.Padding(3);
            this.Base.Size = new System.Drawing.Size(803, 402);
            this.Base.TabIndex = 0;
            this.Base.Text = "Base64/32";
            this.Base.UseVisualStyleBackColor = true;
            // 
            // btn_Pic2Base64
            // 
            this.btn_Pic2Base64.Location = new System.Drawing.Point(266, 348);
            this.btn_Pic2Base64.Name = "btn_Pic2Base64";
            this.btn_Pic2Base64.Size = new System.Drawing.Size(101, 30);
            this.btn_Pic2Base64.TabIndex = 7;
            this.btn_Pic2Base64.Text = "图片->Base64";
            this.btn_Pic2Base64.UseVisualStyleBackColor = true;
            this.btn_Pic2Base64.Click += new System.EventHandler(this.btn_Pic2Base64_Click);
            // 
            // btn_Base642Pic
            // 
            this.btn_Base642Pic.Location = new System.Drawing.Point(159, 348);
            this.btn_Base642Pic.Name = "btn_Base642Pic";
            this.btn_Base642Pic.Size = new System.Drawing.Size(101, 30);
            this.btn_Base642Pic.TabIndex = 6;
            this.btn_Base642Pic.Text = "Base64->图片";
            this.btn_Base642Pic.UseVisualStyleBackColor = true;
            this.btn_Base642Pic.Click += new System.EventHandler(this.btn_Base642Pic_Click);
            // 
            // btn_DeBase32
            // 
            this.btn_DeBase32.Location = new System.Drawing.Point(67, 348);
            this.btn_DeBase32.Name = "btn_DeBase32";
            this.btn_DeBase32.Size = new System.Drawing.Size(86, 31);
            this.btn_DeBase32.TabIndex = 5;
            this.btn_DeBase32.Text = "Base32解密";
            this.btn_DeBase32.UseVisualStyleBackColor = true;
            this.btn_DeBase32.Click += new System.EventHandler(this.btn_DeBase32_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "其它：";
            // 
            // btn_EnBase64
            // 
            this.btn_EnBase64.Location = new System.Drawing.Point(693, 146);
            this.btn_EnBase64.Name = "btn_EnBase64";
            this.btn_EnBase64.Size = new System.Drawing.Size(86, 31);
            this.btn_EnBase64.TabIndex = 3;
            this.btn_EnBase64.Text = "Base64加密";
            this.btn_EnBase64.UseVisualStyleBackColor = true;
            this.btn_EnBase64.Click += new System.EventHandler(this.btn_EnBase64_Click);
            // 
            // btn_DeBase64
            // 
            this.btn_DeBase64.Location = new System.Drawing.Point(601, 145);
            this.btn_DeBase64.Name = "btn_DeBase64";
            this.btn_DeBase64.Size = new System.Drawing.Size(86, 32);
            this.btn_DeBase64.TabIndex = 2;
            this.btn_DeBase64.Text = "Base64解密";
            this.btn_DeBase64.UseVisualStyleBackColor = true;
            this.btn_DeBase64.Click += new System.EventHandler(this.btn_DeBase64_Click);
            // 
            // text_Base_output
            // 
            this.text_Base_output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_Base_output.Location = new System.Drawing.Point(20, 184);
            this.text_Base_output.Multiline = true;
            this.text_Base_output.Name = "text_Base_output";
            this.text_Base_output.ReadOnly = true;
            this.text_Base_output.Size = new System.Drawing.Size(759, 149);
            this.text_Base_output.TabIndex = 1;
            // 
            // text_Base_input
            // 
            this.text_Base_input.Location = new System.Drawing.Point(20, 16);
            this.text_Base_input.Multiline = true;
            this.text_Base_input.Name = "text_Base_input";
            this.text_Base_input.Size = new System.Drawing.Size(759, 124);
            this.text_Base_input.TabIndex = 0;
            // 
            // Morse
            // 
            this.Morse.Controls.Add(this.webBrowser_morse);
            this.Morse.Location = new System.Drawing.Point(4, 26);
            this.Morse.Name = "Morse";
            this.Morse.Padding = new System.Windows.Forms.Padding(3);
            this.Morse.Size = new System.Drawing.Size(803, 402);
            this.Morse.TabIndex = 1;
            this.Morse.Text = "摩斯密码";
            this.Morse.UseVisualStyleBackColor = true;
            // 
            // webBrowser_morse
            // 
            this.webBrowser_morse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_morse.Location = new System.Drawing.Point(3, 3);
            this.webBrowser_morse.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_morse.Name = "webBrowser_morse";
            this.webBrowser_morse.Size = new System.Drawing.Size(797, 396);
            this.webBrowser_morse.TabIndex = 0;
            this.webBrowser_morse.Url = new System.Uri("http://www.atool.org/morse.php", System.UriKind.Absolute);
            // 
            // Caesar
            // 
            this.Caesar.Controls.Add(this.btn_Caesar_clear);
            this.Caesar.Controls.Add(this.Caesar_AllAscii);
            this.Caesar.Controls.Add(this.Caesar_compar);
            this.Caesar.Controls.Add(this.Caesar_choice);
            this.Caesar.Controls.Add(this.btn_Caesar_start);
            this.Caesar.Controls.Add(this.text_Caesar_output);
            this.Caesar.Controls.Add(this.text_Caesar_input);
            this.Caesar.Location = new System.Drawing.Point(4, 26);
            this.Caesar.Name = "Caesar";
            this.Caesar.Padding = new System.Windows.Forms.Padding(3);
            this.Caesar.Size = new System.Drawing.Size(803, 402);
            this.Caesar.TabIndex = 2;
            this.Caesar.Text = "凯撒密码";
            this.Caesar.UseVisualStyleBackColor = true;
            // 
            // JS
            // 
            this.JS.Controls.Add(this.btn_JS_mix);
            this.JS.Location = new System.Drawing.Point(4, 26);
            this.JS.Name = "JS";
            this.JS.Size = new System.Drawing.Size(803, 402);
            this.JS.TabIndex = 3;
            this.JS.Text = "JS系列";
            this.JS.UseVisualStyleBackColor = true;
            // 
            // btn_JS_mix
            // 
            this.btn_JS_mix.Location = new System.Drawing.Point(52, 101);
            this.btn_JS_mix.Name = "btn_JS_mix";
            this.btn_JS_mix.Size = new System.Drawing.Size(75, 23);
            this.btn_JS_mix.TabIndex = 0;
            this.btn_JS_mix.Text = "JS混淆";
            this.btn_JS_mix.UseVisualStyleBackColor = true;
            this.btn_JS_mix.Click += new System.EventHandler(this.btn_JS_mix_Click);
            // 
            // Url
            // 
            this.Url.Location = new System.Drawing.Point(4, 26);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(803, 402);
            this.Url.TabIndex = 4;
            this.Url.Text = "URL";
            this.Url.UseVisualStyleBackColor = true;
            // 
            // UnicodeAscii
            // 
            this.UnicodeAscii.Location = new System.Drawing.Point(4, 26);
            this.UnicodeAscii.Name = "UnicodeAscii";
            this.UnicodeAscii.Size = new System.Drawing.Size(803, 402);
            this.UnicodeAscii.TabIndex = 5;
            this.UnicodeAscii.Text = "Unicode/Ascii";
            this.UnicodeAscii.UseVisualStyleBackColor = true;
            // 
            // Hash
            // 
            this.Hash.Location = new System.Drawing.Point(4, 26);
            this.Hash.Name = "Hash";
            this.Hash.Size = new System.Drawing.Size(803, 402);
            this.Hash.TabIndex = 6;
            this.Hash.Text = "Hash";
            this.Hash.UseVisualStyleBackColor = true;
            // 
            // RailFence
            // 
            this.RailFence.Location = new System.Drawing.Point(4, 26);
            this.RailFence.Name = "RailFence";
            this.RailFence.Size = new System.Drawing.Size(803, 402);
            this.RailFence.TabIndex = 7;
            this.RailFence.Text = "栅栏密码";
            this.RailFence.UseVisualStyleBackColor = true;
            // 
            // Bacon
            // 
            this.Bacon.Location = new System.Drawing.Point(4, 26);
            this.Bacon.Name = "Bacon";
            this.Bacon.Size = new System.Drawing.Size(803, 402);
            this.Bacon.TabIndex = 11;
            this.Bacon.Text = "培根密码";
            this.Bacon.UseVisualStyleBackColor = true;
            // 
            // AES
            // 
            this.AES.Location = new System.Drawing.Point(4, 26);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(803, 402);
            this.AES.TabIndex = 8;
            this.AES.Text = "AES/DES";
            this.AES.UseVisualStyleBackColor = true;
            // 
            // MD5
            // 
            this.MD5.Controls.Add(this.btn_md5);
            this.MD5.Controls.Add(this.text_md5);
            this.MD5.Controls.Add(this.btn_pmd5);
            this.MD5.Controls.Add(this.label2);
            this.MD5.Controls.Add(this.btn_chamd5);
            this.MD5.Controls.Add(this.btn_cmd5);
            this.MD5.Controls.Add(this.webBrowser_md5);
            this.MD5.Location = new System.Drawing.Point(4, 26);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(803, 402);
            this.MD5.TabIndex = 9;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            // 
            // others
            // 
            this.others.Location = new System.Drawing.Point(4, 26);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(803, 402);
            this.others.TabIndex = 10;
            this.others.Text = "其它";
            this.others.UseVisualStyleBackColor = true;
            // 
            // Brainfuck
            // 
            this.Brainfuck.Controls.Add(this.webBrowser_Brainfuck);
            this.Brainfuck.Location = new System.Drawing.Point(4, 26);
            this.Brainfuck.Name = "Brainfuck";
            this.Brainfuck.Padding = new System.Windows.Forms.Padding(3);
            this.Brainfuck.Size = new System.Drawing.Size(803, 402);
            this.Brainfuck.TabIndex = 12;
            this.Brainfuck.Text = "Brainfuck";
            this.Brainfuck.UseVisualStyleBackColor = true;
            // 
            // webBrowser_Brainfuck
            // 
            this.webBrowser_Brainfuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_Brainfuck.Location = new System.Drawing.Point(3, 3);
            this.webBrowser_Brainfuck.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Brainfuck.Name = "webBrowser_Brainfuck";
            this.webBrowser_Brainfuck.Size = new System.Drawing.Size(797, 396);
            this.webBrowser_Brainfuck.TabIndex = 0;
            this.webBrowser_Brainfuck.Url = new System.Uri("http://esoteric.sange.fi/brainfuck/impl/interp/i.html", System.UriKind.Absolute);
            // 
            // text_Caesar_input
            // 
            this.text_Caesar_input.Location = new System.Drawing.Point(21, 20);
            this.text_Caesar_input.Multiline = true;
            this.text_Caesar_input.Name = "text_Caesar_input";
            this.text_Caesar_input.Size = new System.Drawing.Size(755, 122);
            this.text_Caesar_input.TabIndex = 0;
            // 
            // text_Caesar_output
            // 
            this.text_Caesar_output.Location = new System.Drawing.Point(21, 215);
            this.text_Caesar_output.Multiline = true;
            this.text_Caesar_output.Name = "text_Caesar_output";
            this.text_Caesar_output.ReadOnly = true;
            this.text_Caesar_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Caesar_output.Size = new System.Drawing.Size(755, 166);
            this.text_Caesar_output.TabIndex = 1;
            // 
            // btn_Caesar_start
            // 
            this.btn_Caesar_start.Location = new System.Drawing.Point(598, 163);
            this.btn_Caesar_start.Name = "btn_Caesar_start";
            this.btn_Caesar_start.Size = new System.Drawing.Size(86, 32);
            this.btn_Caesar_start.TabIndex = 2;
            this.btn_Caesar_start.Text = "开始";
            this.btn_Caesar_start.UseVisualStyleBackColor = true;
            this.btn_Caesar_start.Click += new System.EventHandler(this.btn_Caesar_start_Click);
            // 
            // Caesar_choice
            // 
            this.Caesar_choice.Location = new System.Drawing.Point(526, 169);
            this.Caesar_choice.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Caesar_choice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Caesar_choice.Name = "Caesar_choice";
            this.Caesar_choice.Size = new System.Drawing.Size(55, 23);
            this.Caesar_choice.TabIndex = 3;
            this.Caesar_choice.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // Caesar_compar
            // 
            this.Caesar_compar.AutoSize = true;
            this.Caesar_compar.Checked = true;
            this.Caesar_compar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Caesar_compar.Location = new System.Drawing.Point(458, 170);
            this.Caesar_compar.Name = "Caesar_compar";
            this.Caesar_compar.Size = new System.Drawing.Size(51, 21);
            this.Caesar_compar.TabIndex = 4;
            this.Caesar_compar.Text = "对比";
            this.Caesar_compar.UseVisualStyleBackColor = true;
            // 
            // Caesar_AllAscii
            // 
            this.Caesar_AllAscii.AutoSize = true;
            this.Caesar_AllAscii.Location = new System.Drawing.Point(389, 170);
            this.Caesar_AllAscii.Name = "Caesar_AllAscii";
            this.Caesar_AllAscii.Size = new System.Drawing.Size(63, 21);
            this.Caesar_AllAscii.TabIndex = 5;
            this.Caesar_AllAscii.Text = "带符号";
            this.Caesar_AllAscii.UseVisualStyleBackColor = true;
            // 
            // btn_Caesar_clear
            // 
            this.btn_Caesar_clear.Location = new System.Drawing.Point(690, 163);
            this.btn_Caesar_clear.Name = "btn_Caesar_clear";
            this.btn_Caesar_clear.Size = new System.Drawing.Size(86, 32);
            this.btn_Caesar_clear.TabIndex = 6;
            this.btn_Caesar_clear.Text = "清空输出框";
            this.btn_Caesar_clear.UseVisualStyleBackColor = true;
            this.btn_Caesar_clear.Click += new System.EventHandler(this.btn_Caesar_clear_Click);
            // 
            // webBrowser_md5
            // 
            this.webBrowser_md5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_md5.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_md5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_md5.Name = "webBrowser_md5";
            this.webBrowser_md5.Size = new System.Drawing.Size(803, 402);
            this.webBrowser_md5.TabIndex = 0;
            this.webBrowser_md5.Url = new System.Uri("http://www.cmd5.com/", System.UriKind.Absolute);
            // 
            // btn_cmd5
            // 
            this.btn_cmd5.Location = new System.Drawing.Point(77, 3);
            this.btn_cmd5.Name = "btn_cmd5";
            this.btn_cmd5.Size = new System.Drawing.Size(86, 32);
            this.btn_cmd5.TabIndex = 1;
            this.btn_cmd5.Text = "cmd5";
            this.btn_cmd5.UseVisualStyleBackColor = true;
            this.btn_cmd5.Click += new System.EventHandler(this.btn_cmd5_Click);
            // 
            // btn_chamd5
            // 
            this.btn_chamd5.Location = new System.Drawing.Point(169, 3);
            this.btn_chamd5.Name = "btn_chamd5";
            this.btn_chamd5.Size = new System.Drawing.Size(86, 32);
            this.btn_chamd5.TabIndex = 2;
            this.btn_chamd5.Text = "chamd5";
            this.btn_chamd5.UseVisualStyleBackColor = true;
            this.btn_chamd5.Click += new System.EventHandler(this.btn_chamd5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "浏览器打开:";
            // 
            // btn_pmd5
            // 
            this.btn_pmd5.Location = new System.Drawing.Point(261, 3);
            this.btn_pmd5.Name = "btn_pmd5";
            this.btn_pmd5.Size = new System.Drawing.Size(86, 32);
            this.btn_pmd5.TabIndex = 4;
            this.btn_pmd5.Text = "pmd5";
            this.btn_pmd5.UseVisualStyleBackColor = true;
            this.btn_pmd5.Click += new System.EventHandler(this.btn_pmd5_Click);
            // 
            // text_md5
            // 
            this.text_md5.Location = new System.Drawing.Point(353, 8);
            this.text_md5.Name = "text_md5";
            this.text_md5.Size = new System.Drawing.Size(249, 23);
            this.text_md5.TabIndex = 5;
            // 
            // btn_md5
            // 
            this.btn_md5.Location = new System.Drawing.Point(608, 3);
            this.btn_md5.Name = "btn_md5";
            this.btn_md5.Size = new System.Drawing.Size(86, 32);
            this.btn_md5.TabIndex = 6;
            this.btn_md5.Text = "md5加密";
            this.btn_md5.UseVisualStyleBackColor = true;
            this.btn_md5.Click += new System.EventHandler(this.btn_md5_Click);
            // 
            // FM_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 432);
            this.Controls.Add(this.tabControl);
            this.Name = "FM_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTFDecryptEncrypt";
            this.tabControl.ResumeLayout(false);
            this.Base.ResumeLayout(false);
            this.Base.PerformLayout();
            this.Morse.ResumeLayout(false);
            this.Caesar.ResumeLayout(false);
            this.Caesar.PerformLayout();
            this.JS.ResumeLayout(false);
            this.MD5.ResumeLayout(false);
            this.MD5.PerformLayout();
            this.Brainfuck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Caesar_choice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Base;
        private System.Windows.Forms.TabPage Morse;
        private System.Windows.Forms.TabPage Caesar;
        private System.Windows.Forms.TabPage JS;
        private System.Windows.Forms.TabPage Url;
        private System.Windows.Forms.TabPage UnicodeAscii;
        private System.Windows.Forms.TabPage Hash;
        private System.Windows.Forms.TabPage RailFence;
        private System.Windows.Forms.TabPage AES;
        private System.Windows.Forms.TabPage MD5;
        private System.Windows.Forms.TabPage others;
        private System.Windows.Forms.TabPage Bacon;
        private System.Windows.Forms.TextBox text_Base_output;
        private System.Windows.Forms.TextBox text_Base_input;
        private System.Windows.Forms.Button btn_EnBase64;
        private System.Windows.Forms.Button btn_DeBase64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Pic2Base64;
        private System.Windows.Forms.Button btn_Base642Pic;
        private System.Windows.Forms.Button btn_DeBase32;
        private System.Windows.Forms.WebBrowser webBrowser_morse;
        private System.Windows.Forms.Button btn_JS_mix;
        private System.Windows.Forms.TabPage Brainfuck;
        private System.Windows.Forms.WebBrowser webBrowser_Brainfuck;
        private System.Windows.Forms.TextBox text_Caesar_input;
        private System.Windows.Forms.CheckBox Caesar_compar;
        private System.Windows.Forms.NumericUpDown Caesar_choice;
        private System.Windows.Forms.Button btn_Caesar_start;
        private System.Windows.Forms.TextBox text_Caesar_output;
        private System.Windows.Forms.CheckBox Caesar_AllAscii;
        private System.Windows.Forms.Button btn_Caesar_clear;
        private System.Windows.Forms.WebBrowser webBrowser_md5;
        private System.Windows.Forms.Button btn_cmd5;
        private System.Windows.Forms.Button btn_pmd5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_chamd5;
        private System.Windows.Forms.Button btn_md5;
        private System.Windows.Forms.TextBox text_md5;
    }
}

