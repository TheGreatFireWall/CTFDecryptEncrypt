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
            this.Morse = new System.Windows.Forms.TabPage();
            this.Caesar = new System.Windows.Forms.TabPage();
            this.JS = new System.Windows.Forms.TabPage();
            this.Url = new System.Windows.Forms.TabPage();
            this.UnicodeAscii = new System.Windows.Forms.TabPage();
            this.Hash = new System.Windows.Forms.TabPage();
            this.RailFence = new System.Windows.Forms.TabPage();
            this.AES = new System.Windows.Forms.TabPage();
            this.MD5 = new System.Windows.Forms.TabPage();
            this.others = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Base);
            this.tabControl.Controls.Add(this.Morse);
            this.tabControl.Controls.Add(this.Caesar);
            this.tabControl.Controls.Add(this.JS);
            this.tabControl.Controls.Add(this.Url);
            this.tabControl.Controls.Add(this.UnicodeAscii);
            this.tabControl.Controls.Add(this.Hash);
            this.tabControl.Controls.Add(this.RailFence);
            this.tabControl.Controls.Add(this.AES);
            this.tabControl.Controls.Add(this.MD5);
            this.tabControl.Controls.Add(this.others);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(687, 432);
            this.tabControl.TabIndex = 0;
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(4, 26);
            this.Base.Name = "Base";
            this.Base.Padding = new System.Windows.Forms.Padding(3);
            this.Base.Size = new System.Drawing.Size(679, 402);
            this.Base.TabIndex = 0;
            this.Base.Text = "Base64/32";
            this.Base.UseVisualStyleBackColor = true;
            // 
            // Morse
            // 
            this.Morse.Location = new System.Drawing.Point(4, 26);
            this.Morse.Name = "Morse";
            this.Morse.Padding = new System.Windows.Forms.Padding(3);
            this.Morse.Size = new System.Drawing.Size(679, 402);
            this.Morse.TabIndex = 1;
            this.Morse.Text = "摩斯密码";
            this.Morse.UseVisualStyleBackColor = true;
            // 
            // Caesar
            // 
            this.Caesar.Location = new System.Drawing.Point(4, 26);
            this.Caesar.Name = "Caesar";
            this.Caesar.Padding = new System.Windows.Forms.Padding(3);
            this.Caesar.Size = new System.Drawing.Size(679, 402);
            this.Caesar.TabIndex = 2;
            this.Caesar.Text = "凯撒密码";
            this.Caesar.UseVisualStyleBackColor = true;
            // 
            // JS
            // 
            this.JS.Location = new System.Drawing.Point(4, 26);
            this.JS.Name = "JS";
            this.JS.Size = new System.Drawing.Size(679, 402);
            this.JS.TabIndex = 3;
            this.JS.Text = "JS系列";
            this.JS.UseVisualStyleBackColor = true;
            // 
            // Url
            // 
            this.Url.Location = new System.Drawing.Point(4, 26);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(679, 402);
            this.Url.TabIndex = 4;
            this.Url.Text = "URL";
            this.Url.UseVisualStyleBackColor = true;
            // 
            // UnicodeAscii
            // 
            this.UnicodeAscii.Location = new System.Drawing.Point(4, 26);
            this.UnicodeAscii.Name = "UnicodeAscii";
            this.UnicodeAscii.Size = new System.Drawing.Size(679, 402);
            this.UnicodeAscii.TabIndex = 5;
            this.UnicodeAscii.Text = "Unicode/Ascii";
            this.UnicodeAscii.UseVisualStyleBackColor = true;
            // 
            // Hash
            // 
            this.Hash.Location = new System.Drawing.Point(4, 26);
            this.Hash.Name = "Hash";
            this.Hash.Size = new System.Drawing.Size(679, 402);
            this.Hash.TabIndex = 6;
            this.Hash.Text = "Hash";
            this.Hash.UseVisualStyleBackColor = true;
            // 
            // RailFence
            // 
            this.RailFence.Location = new System.Drawing.Point(4, 26);
            this.RailFence.Name = "RailFence";
            this.RailFence.Size = new System.Drawing.Size(679, 402);
            this.RailFence.TabIndex = 7;
            this.RailFence.Text = "栅栏密码";
            this.RailFence.UseVisualStyleBackColor = true;
            // 
            // AES
            // 
            this.AES.Location = new System.Drawing.Point(4, 26);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(679, 402);
            this.AES.TabIndex = 8;
            this.AES.Text = "AES/DES";
            this.AES.UseVisualStyleBackColor = true;
            // 
            // MD5
            // 
            this.MD5.Location = new System.Drawing.Point(4, 26);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(679, 402);
            this.MD5.TabIndex = 9;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            // 
            // others
            // 
            this.others.Location = new System.Drawing.Point(4, 26);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(679, 402);
            this.others.TabIndex = 10;
            this.others.Text = "其它";
            this.others.UseVisualStyleBackColor = true;
            // 
            // FM_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 432);
            this.Controls.Add(this.tabControl);
            this.Name = "FM_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTFDecryptEncrypt";
            this.tabControl.ResumeLayout(false);
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
    }
}

