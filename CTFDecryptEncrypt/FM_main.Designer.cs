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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Tab_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭该标签页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Base_re = new System.Windows.Forms.TabPage();
            this.send_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.发送结果到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编码解码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.加密解密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.其它工具ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.进制转换ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.文本处理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.插件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Base32Encode = new System.Windows.Forms.Button();
            this.btn_Base32Decode = new System.Windows.Forms.Button();
            this.btn_BaseSend = new System.Windows.Forms.Button();
            this.btn_Pic2Base64 = new System.Windows.Forms.Button();
            this.btn_Base642Pic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Base64Encode = new System.Windows.Forms.Button();
            this.btn_Base64Decode = new System.Windows.Forms.Button();
            this.text_Base_output = new System.Windows.Forms.TextBox();
            this.text_Base_input = new System.Windows.Forms.TextBox();
            this.Morse = new System.Windows.Forms.TabPage();
            this.webBrowser_morse = new System.Windows.Forms.WebBrowser();
            this.Caesar = new System.Windows.Forms.TabPage();
            this.btn_Caesar_clear = new System.Windows.Forms.Button();
            this.Caesar_AllAscii = new System.Windows.Forms.CheckBox();
            this.Caesar_compar = new System.Windows.Forms.CheckBox();
            this.Caesar_choice = new System.Windows.Forms.NumericUpDown();
            this.btn_Caesar_start = new System.Windows.Forms.Button();
            this.text_Caesar_output = new System.Windows.Forms.TextBox();
            this.text_Caesar_input = new System.Windows.Forms.TextBox();
            this.JS = new System.Windows.Forms.TabPage();
            this.btn_JS_mix = new System.Windows.Forms.Button();
            this.Brainfuck = new System.Windows.Forms.TabPage();
            this.webBrowser_Brainfuck = new System.Windows.Forms.WebBrowser();
            this.Url = new System.Windows.Forms.TabPage();
            this.UnicodeAscii = new System.Windows.Forms.TabPage();
            this.Hash = new System.Windows.Forms.TabPage();
            this.RailFence = new System.Windows.Forms.TabPage();
            this.Bacon = new System.Windows.Forms.TabPage();
            this.Pig = new System.Windows.Forms.TabPage();
            this.AES = new System.Windows.Forms.TabPage();
            this.MD5 = new System.Windows.Forms.TabPage();
            this.btn_md5 = new System.Windows.Forms.Button();
            this.text_md5 = new System.Windows.Forms.TextBox();
            this.btn_pmd5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_chamd5 = new System.Windows.Forms.Button();
            this.btn_cmd5 = new System.Windows.Forms.Button();
            this.webBrowser_md5 = new System.Windows.Forms.WebBrowser();
            this.others = new System.Windows.Forms.TabPage();
            this.btn_Conversion = new System.Windows.Forms.Button();
            this.btn_Word = new System.Windows.Forms.Button();
            this.menu_top = new System.Windows.Forms.MenuStrip();
            this.编码解码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加密解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进制转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文本处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其它工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插件编写ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者网站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.Tab_Menu.SuspendLayout();
            this.btn_Base_re.SuspendLayout();
            this.send_Menu.SuspendLayout();
            this.Morse.SuspendLayout();
            this.Caesar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caesar_choice)).BeginInit();
            this.JS.SuspendLayout();
            this.Brainfuck.SuspendLayout();
            this.MD5.SuspendLayout();
            this.others.SuspendLayout();
            this.menu_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.ContextMenuStrip = this.Tab_Menu;
            this.tabControl.Controls.Add(this.btn_Base_re);
            this.tabControl.Controls.Add(this.Morse);
            this.tabControl.Controls.Add(this.Caesar);
            this.tabControl.Controls.Add(this.JS);
            this.tabControl.Controls.Add(this.Brainfuck);
            this.tabControl.Controls.Add(this.Url);
            this.tabControl.Controls.Add(this.UnicodeAscii);
            this.tabControl.Controls.Add(this.Hash);
            this.tabControl.Controls.Add(this.RailFence);
            this.tabControl.Controls.Add(this.Bacon);
            this.tabControl.Controls.Add(this.Pig);
            this.tabControl.Controls.Add(this.AES);
            this.tabControl.Controls.Add(this.MD5);
            this.tabControl.Controls.Add(this.others);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(809, 403);
            this.tabControl.TabIndex = 0;
            // 
            // Tab_Menu
            // 
            this.Tab_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭该标签页ToolStripMenuItem});
            this.Tab_Menu.Name = "Tab_Menu";
            this.Tab_Menu.Size = new System.Drawing.Size(149, 26);
            this.Tab_Menu.Text = "标签页";
            // 
            // 关闭该标签页ToolStripMenuItem
            // 
            this.关闭该标签页ToolStripMenuItem.Name = "关闭该标签页ToolStripMenuItem";
            this.关闭该标签页ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.关闭该标签页ToolStripMenuItem.Text = "关闭该标签页";
            // 
            // btn_Base_re
            // 
            this.btn_Base_re.ContextMenuStrip = this.send_Menu;
            this.btn_Base_re.Controls.Add(this.btn_Base32Encode);
            this.btn_Base_re.Controls.Add(this.btn_Base32Decode);
            this.btn_Base_re.Controls.Add(this.btn_BaseSend);
            this.btn_Base_re.Controls.Add(this.btn_Pic2Base64);
            this.btn_Base_re.Controls.Add(this.btn_Base642Pic);
            this.btn_Base_re.Controls.Add(this.label1);
            this.btn_Base_re.Controls.Add(this.btn_Base64Encode);
            this.btn_Base_re.Controls.Add(this.btn_Base64Decode);
            this.btn_Base_re.Controls.Add(this.text_Base_output);
            this.btn_Base_re.Controls.Add(this.text_Base_input);
            this.btn_Base_re.Location = new System.Drawing.Point(4, 26);
            this.btn_Base_re.Name = "btn_Base_re";
            this.btn_Base_re.Padding = new System.Windows.Forms.Padding(3);
            this.btn_Base_re.Size = new System.Drawing.Size(801, 373);
            this.btn_Base_re.TabIndex = 0;
            this.btn_Base_re.Text = "Base64/32";
            this.btn_Base_re.UseVisualStyleBackColor = true;
            // 
            // send_Menu
            // 
            this.send_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送结果到ToolStripMenuItem});
            this.send_Menu.Name = "send_Menu";
            this.send_Menu.Size = new System.Drawing.Size(137, 26);
            // 
            // 发送结果到ToolStripMenuItem
            // 
            this.发送结果到ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编码解码ToolStripMenuItem1,
            this.加密解密ToolStripMenuItem1,
            this.其它工具ToolStripMenuItem1,
            this.插件ToolStripMenuItem1});
            this.发送结果到ToolStripMenuItem.Name = "发送结果到ToolStripMenuItem";
            this.发送结果到ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.发送结果到ToolStripMenuItem.Text = "发送结果到";
            // 
            // 编码解码ToolStripMenuItem1
            // 
            this.编码解码ToolStripMenuItem1.Name = "编码解码ToolStripMenuItem1";
            this.编码解码ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.编码解码ToolStripMenuItem1.Text = "编码解码";
            // 
            // 加密解密ToolStripMenuItem1
            // 
            this.加密解密ToolStripMenuItem1.Name = "加密解密ToolStripMenuItem1";
            this.加密解密ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.加密解密ToolStripMenuItem1.Text = "加密解密";
            // 
            // 其它工具ToolStripMenuItem1
            // 
            this.其它工具ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进制转换ToolStripMenuItem1,
            this.文本处理ToolStripMenuItem1});
            this.其它工具ToolStripMenuItem1.Name = "其它工具ToolStripMenuItem1";
            this.其它工具ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.其它工具ToolStripMenuItem1.Text = "其它工具";
            // 
            // 进制转换ToolStripMenuItem1
            // 
            this.进制转换ToolStripMenuItem1.Name = "进制转换ToolStripMenuItem1";
            this.进制转换ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.进制转换ToolStripMenuItem1.Text = "进制转换";
            // 
            // 文本处理ToolStripMenuItem1
            // 
            this.文本处理ToolStripMenuItem1.Name = "文本处理ToolStripMenuItem1";
            this.文本处理ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.文本处理ToolStripMenuItem1.Text = "文本处理";
            this.文本处理ToolStripMenuItem1.Click += new System.EventHandler(this.文本处理ToolStripMenuItem1_Click);
            // 
            // 插件ToolStripMenuItem1
            // 
            this.插件ToolStripMenuItem1.Name = "插件ToolStripMenuItem1";
            this.插件ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.插件ToolStripMenuItem1.Text = "插件";
            // 
            // btn_Base32Encode
            // 
            this.btn_Base32Encode.Location = new System.Drawing.Point(509, 145);
            this.btn_Base32Encode.Name = "btn_Base32Encode";
            this.btn_Base32Encode.Size = new System.Drawing.Size(86, 32);
            this.btn_Base32Encode.TabIndex = 10;
            this.btn_Base32Encode.Text = "Base32加密";
            this.btn_Base32Encode.UseVisualStyleBackColor = true;
            this.btn_Base32Encode.Click += new System.EventHandler(this.btn_Base32Encode_Click);
            // 
            // btn_Base32Decode
            // 
            this.btn_Base32Decode.Location = new System.Drawing.Point(417, 145);
            this.btn_Base32Decode.Name = "btn_Base32Decode";
            this.btn_Base32Decode.Size = new System.Drawing.Size(86, 32);
            this.btn_Base32Decode.TabIndex = 9;
            this.btn_Base32Decode.Text = "Base32解密";
            this.btn_Base32Decode.UseVisualStyleBackColor = true;
            this.btn_Base32Decode.Click += new System.EventHandler(this.btn_Base32Decode_Click);
            // 
            // btn_BaseSend
            // 
            this.btn_BaseSend.Location = new System.Drawing.Point(325, 145);
            this.btn_BaseSend.Name = "btn_BaseSend";
            this.btn_BaseSend.Size = new System.Drawing.Size(86, 32);
            this.btn_BaseSend.TabIndex = 8;
            this.btn_BaseSend.Text = "↑";
            this.btn_BaseSend.UseVisualStyleBackColor = true;
            this.btn_BaseSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Pic2Base64
            // 
            this.btn_Pic2Base64.Location = new System.Drawing.Point(174, 348);
            this.btn_Pic2Base64.Name = "btn_Pic2Base64";
            this.btn_Pic2Base64.Size = new System.Drawing.Size(101, 30);
            this.btn_Pic2Base64.TabIndex = 7;
            this.btn_Pic2Base64.Text = "图片->Base64";
            this.btn_Pic2Base64.UseVisualStyleBackColor = true;
            this.btn_Pic2Base64.Click += new System.EventHandler(this.btn_Pic2Base64_Click);
            // 
            // btn_Base642Pic
            // 
            this.btn_Base642Pic.Location = new System.Drawing.Point(67, 348);
            this.btn_Base642Pic.Name = "btn_Base642Pic";
            this.btn_Base642Pic.Size = new System.Drawing.Size(101, 30);
            this.btn_Base642Pic.TabIndex = 6;
            this.btn_Base642Pic.Text = "Base64->图片";
            this.btn_Base642Pic.UseVisualStyleBackColor = true;
            this.btn_Base642Pic.Click += new System.EventHandler(this.btn_Base642Pic_Click);
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
            // btn_Base64Encode
            // 
            this.btn_Base64Encode.Location = new System.Drawing.Point(693, 146);
            this.btn_Base64Encode.Name = "btn_Base64Encode";
            this.btn_Base64Encode.Size = new System.Drawing.Size(86, 31);
            this.btn_Base64Encode.TabIndex = 3;
            this.btn_Base64Encode.Text = "Base64加密";
            this.btn_Base64Encode.UseVisualStyleBackColor = true;
            this.btn_Base64Encode.Click += new System.EventHandler(this.btn_EnBase64_Click);
            // 
            // btn_Base64Decode
            // 
            this.btn_Base64Decode.Location = new System.Drawing.Point(601, 145);
            this.btn_Base64Decode.Name = "btn_Base64Decode";
            this.btn_Base64Decode.Size = new System.Drawing.Size(86, 32);
            this.btn_Base64Decode.TabIndex = 2;
            this.btn_Base64Decode.Text = "Base64解密";
            this.btn_Base64Decode.UseVisualStyleBackColor = true;
            this.btn_Base64Decode.Click += new System.EventHandler(this.btn_DeBase64_Click);
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
            this.Morse.Size = new System.Drawing.Size(801, 373);
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
            this.webBrowser_morse.Size = new System.Drawing.Size(795, 367);
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
            this.Caesar.Size = new System.Drawing.Size(801, 373);
            this.Caesar.TabIndex = 2;
            this.Caesar.Text = "凯撒密码";
            this.Caesar.UseVisualStyleBackColor = true;
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
            // Caesar_AllAscii
            // 
            this.Caesar_AllAscii.AutoSize = true;
            this.Caesar_AllAscii.Location = new System.Drawing.Point(353, 170);
            this.Caesar_AllAscii.Name = "Caesar_AllAscii";
            this.Caesar_AllAscii.Size = new System.Drawing.Size(99, 21);
            this.Caesar_AllAscii.TabIndex = 5;
            this.Caesar_AllAscii.Text = "带符号加解密";
            this.Caesar_AllAscii.UseVisualStyleBackColor = true;
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
            // text_Caesar_input
            // 
            this.text_Caesar_input.Location = new System.Drawing.Point(21, 20);
            this.text_Caesar_input.Multiline = true;
            this.text_Caesar_input.Name = "text_Caesar_input";
            this.text_Caesar_input.Size = new System.Drawing.Size(755, 122);
            this.text_Caesar_input.TabIndex = 0;
            // 
            // JS
            // 
            this.JS.Controls.Add(this.btn_JS_mix);
            this.JS.Location = new System.Drawing.Point(4, 26);
            this.JS.Name = "JS";
            this.JS.Size = new System.Drawing.Size(801, 373);
            this.JS.TabIndex = 3;
            this.JS.Text = "JS系列";
            this.JS.UseVisualStyleBackColor = true;
            // 
            // btn_JS_mix
            // 
            this.btn_JS_mix.Location = new System.Drawing.Point(21, 24);
            this.btn_JS_mix.Name = "btn_JS_mix";
            this.btn_JS_mix.Size = new System.Drawing.Size(75, 23);
            this.btn_JS_mix.TabIndex = 0;
            this.btn_JS_mix.Text = "JS混淆";
            this.btn_JS_mix.UseVisualStyleBackColor = true;
            this.btn_JS_mix.Click += new System.EventHandler(this.btn_JS_mix_Click);
            // 
            // Brainfuck
            // 
            this.Brainfuck.Controls.Add(this.webBrowser_Brainfuck);
            this.Brainfuck.Location = new System.Drawing.Point(4, 26);
            this.Brainfuck.Name = "Brainfuck";
            this.Brainfuck.Padding = new System.Windows.Forms.Padding(3);
            this.Brainfuck.Size = new System.Drawing.Size(801, 373);
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
            this.webBrowser_Brainfuck.Size = new System.Drawing.Size(795, 367);
            this.webBrowser_Brainfuck.TabIndex = 0;
            this.webBrowser_Brainfuck.Url = new System.Uri("http://esoteric.sange.fi/brainfuck/impl/interp/i.html", System.UriKind.Absolute);
            // 
            // Url
            // 
            this.Url.Location = new System.Drawing.Point(4, 26);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(801, 373);
            this.Url.TabIndex = 4;
            this.Url.Text = "URL";
            this.Url.UseVisualStyleBackColor = true;
            // 
            // UnicodeAscii
            // 
            this.UnicodeAscii.Location = new System.Drawing.Point(4, 26);
            this.UnicodeAscii.Name = "UnicodeAscii";
            this.UnicodeAscii.Size = new System.Drawing.Size(801, 373);
            this.UnicodeAscii.TabIndex = 5;
            this.UnicodeAscii.Text = "Unicode/Ascii";
            this.UnicodeAscii.UseVisualStyleBackColor = true;
            // 
            // Hash
            // 
            this.Hash.Location = new System.Drawing.Point(4, 26);
            this.Hash.Name = "Hash";
            this.Hash.Size = new System.Drawing.Size(801, 373);
            this.Hash.TabIndex = 6;
            this.Hash.Text = "Hash";
            this.Hash.UseVisualStyleBackColor = true;
            // 
            // RailFence
            // 
            this.RailFence.Location = new System.Drawing.Point(4, 26);
            this.RailFence.Name = "RailFence";
            this.RailFence.Size = new System.Drawing.Size(801, 373);
            this.RailFence.TabIndex = 7;
            this.RailFence.Text = "栅栏密码";
            this.RailFence.UseVisualStyleBackColor = true;
            // 
            // Bacon
            // 
            this.Bacon.Location = new System.Drawing.Point(4, 26);
            this.Bacon.Name = "Bacon";
            this.Bacon.Size = new System.Drawing.Size(801, 373);
            this.Bacon.TabIndex = 11;
            this.Bacon.Text = "培根密码";
            this.Bacon.UseVisualStyleBackColor = true;
            // 
            // Pig
            // 
            this.Pig.Location = new System.Drawing.Point(4, 26);
            this.Pig.Name = "Pig";
            this.Pig.Size = new System.Drawing.Size(801, 373);
            this.Pig.TabIndex = 13;
            this.Pig.Text = "猪圈密码";
            this.Pig.UseVisualStyleBackColor = true;
            // 
            // AES
            // 
            this.AES.Location = new System.Drawing.Point(4, 26);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(801, 373);
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
            this.MD5.Size = new System.Drawing.Size(801, 373);
            this.MD5.TabIndex = 9;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
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
            // text_md5
            // 
            this.text_md5.Location = new System.Drawing.Point(353, 8);
            this.text_md5.Name = "text_md5";
            this.text_md5.Size = new System.Drawing.Size(249, 23);
            this.text_md5.TabIndex = 5;
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
            // webBrowser_md5
            // 
            this.webBrowser_md5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_md5.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_md5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_md5.Name = "webBrowser_md5";
            this.webBrowser_md5.Size = new System.Drawing.Size(801, 373);
            this.webBrowser_md5.TabIndex = 0;
            this.webBrowser_md5.Url = new System.Uri("http://www.cmd5.com/", System.UriKind.Absolute);
            // 
            // others
            // 
            this.others.Controls.Add(this.btn_Conversion);
            this.others.Controls.Add(this.btn_Word);
            this.others.Location = new System.Drawing.Point(4, 26);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(801, 373);
            this.others.TabIndex = 10;
            this.others.Text = "其它";
            this.others.UseVisualStyleBackColor = true;
            // 
            // btn_Conversion
            // 
            this.btn_Conversion.Location = new System.Drawing.Point(127, 16);
            this.btn_Conversion.Name = "btn_Conversion";
            this.btn_Conversion.Size = new System.Drawing.Size(86, 32);
            this.btn_Conversion.TabIndex = 8;
            this.btn_Conversion.Text = "进制转换";
            this.btn_Conversion.UseVisualStyleBackColor = true;
            this.btn_Conversion.Click += new System.EventHandler(this.btn_Conversion_Click);
            // 
            // btn_Word
            // 
            this.btn_Word.Location = new System.Drawing.Point(19, 16);
            this.btn_Word.Name = "btn_Word";
            this.btn_Word.Size = new System.Drawing.Size(86, 32);
            this.btn_Word.TabIndex = 7;
            this.btn_Word.Text = "文本处理";
            this.btn_Word.UseVisualStyleBackColor = true;
            this.btn_Word.Click += new System.EventHandler(this.btn_Word_Click);
            // 
            // menu_top
            // 
            this.menu_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编码解码ToolStripMenuItem,
            this.加密解密ToolStripMenuItem,
            this.插件ToolStripMenuItem,
            this.其它工具ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menu_top.Location = new System.Drawing.Point(0, 0);
            this.menu_top.Name = "menu_top";
            this.menu_top.Size = new System.Drawing.Size(809, 25);
            this.menu_top.TabIndex = 1;
            this.menu_top.Text = "menu_top";
            // 
            // 编码解码ToolStripMenuItem
            // 
            this.编码解码ToolStripMenuItem.Name = "编码解码ToolStripMenuItem";
            this.编码解码ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.编码解码ToolStripMenuItem.Text = "编码解码";
            // 
            // 加密解密ToolStripMenuItem
            // 
            this.加密解密ToolStripMenuItem.Name = "加密解密ToolStripMenuItem";
            this.加密解密ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.加密解密ToolStripMenuItem.Text = "加密解密";
            // 
            // 插件ToolStripMenuItem
            // 
            this.插件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进制转换ToolStripMenuItem,
            this.文本处理ToolStripMenuItem});
            this.插件ToolStripMenuItem.Name = "插件ToolStripMenuItem";
            this.插件ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.插件ToolStripMenuItem.Text = "其它工具";
            // 
            // 进制转换ToolStripMenuItem
            // 
            this.进制转换ToolStripMenuItem.Name = "进制转换ToolStripMenuItem";
            this.进制转换ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.进制转换ToolStripMenuItem.Text = "进制转换";
            this.进制转换ToolStripMenuItem.Click += new System.EventHandler(this.进制转换ToolStripMenuItem_Click);
            // 
            // 文本处理ToolStripMenuItem
            // 
            this.文本处理ToolStripMenuItem.Name = "文本处理ToolStripMenuItem";
            this.文本处理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.文本处理ToolStripMenuItem.Text = "文本处理";
            this.文本处理ToolStripMenuItem.Click += new System.EventHandler(this.文本处理ToolStripMenuItem_Click);
            // 
            // 其它工具ToolStripMenuItem
            // 
            this.其它工具ToolStripMenuItem.Name = "其它工具ToolStripMenuItem";
            this.其它工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其它工具ToolStripMenuItem.Text = "插件";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本工具ToolStripMenuItem,
            this.插件编写ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.作者网站ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 本工具ToolStripMenuItem
            // 
            this.本工具ToolStripMenuItem.Name = "本工具ToolStripMenuItem";
            this.本工具ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.本工具ToolStripMenuItem.Text = "本工具";
            // 
            // 插件编写ToolStripMenuItem
            // 
            this.插件编写ToolStripMenuItem.Name = "插件编写ToolStripMenuItem";
            this.插件编写ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.插件编写ToolStripMenuItem.Text = "插件编写";
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 作者网站ToolStripMenuItem
            // 
            this.作者网站ToolStripMenuItem.Name = "作者网站ToolStripMenuItem";
            this.作者网站ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.作者网站ToolStripMenuItem.Text = "作者网站";
            // 
            // FM_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 431);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menu_top);
            this.Name = "FM_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTFDecryptEncrypt";
            this.tabControl.ResumeLayout(false);
            this.Tab_Menu.ResumeLayout(false);
            this.btn_Base_re.ResumeLayout(false);
            this.btn_Base_re.PerformLayout();
            this.send_Menu.ResumeLayout(false);
            this.Morse.ResumeLayout(false);
            this.Caesar.ResumeLayout(false);
            this.Caesar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caesar_choice)).EndInit();
            this.JS.ResumeLayout(false);
            this.Brainfuck.ResumeLayout(false);
            this.MD5.ResumeLayout(false);
            this.MD5.PerformLayout();
            this.others.ResumeLayout(false);
            this.menu_top.ResumeLayout(false);
            this.menu_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage btn_Base_re;
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
        private System.Windows.Forms.Button btn_Base64Encode;
        private System.Windows.Forms.Button btn_Base64Decode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Pic2Base64;
        private System.Windows.Forms.Button btn_Base642Pic;
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
        private System.Windows.Forms.Button btn_BaseSend;
        private System.Windows.Forms.Button btn_Base32Encode;
        private System.Windows.Forms.Button btn_Base32Decode;
        private System.Windows.Forms.Button btn_Word;
        private System.Windows.Forms.Button btn_Conversion;
        private System.Windows.Forms.TabPage Pig;
        private System.Windows.Forms.MenuStrip menu_top;
        private System.Windows.Forms.ToolStripMenuItem 编码解码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加密解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其它工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制转换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文本处理ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Tab_Menu;
        private System.Windows.Forms.ToolStripMenuItem 关闭该标签页ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip send_Menu;
        private System.Windows.Forms.ToolStripMenuItem 发送结果到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编码解码ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 加密解密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 其它工具ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 进制转换ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 文本处理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 插件ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 本工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插件编写ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者网站ToolStripMenuItem;
    }
}

