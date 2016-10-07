namespace CTFDecryptEncrypt
{
    partial class FM_word
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_WordInput = new System.Windows.Forms.TextBox();
            this.text_WordOutput = new System.Windows.Forms.TextBox();
            this.btn_WordUp = new System.Windows.Forms.Button();
            this.btn_WordLow = new System.Windows.Forms.Button();
            this.btn_WordReplace = new System.Windows.Forms.Button();
            this.text_WordFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_WordReplace = new System.Windows.Forms.TextBox();
            this.btn_WordFind = new System.Windows.Forms.Button();
            this.text_WordLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_WordInput
            // 
            this.text_WordInput.Location = new System.Drawing.Point(12, 12);
            this.text_WordInput.Multiline = true;
            this.text_WordInput.Name = "text_WordInput";
            this.text_WordInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_WordInput.Size = new System.Drawing.Size(664, 128);
            this.text_WordInput.TabIndex = 0;
            this.text_WordInput.TextChanged += new System.EventHandler(this.text_WordInput_TextChanged);
            // 
            // text_WordOutput
            // 
            this.text_WordOutput.Location = new System.Drawing.Point(12, 211);
            this.text_WordOutput.Multiline = true;
            this.text_WordOutput.Name = "text_WordOutput";
            this.text_WordOutput.ReadOnly = true;
            this.text_WordOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_WordOutput.Size = new System.Drawing.Size(664, 118);
            this.text_WordOutput.TabIndex = 1;
            // 
            // btn_WordUp
            // 
            this.btn_WordUp.Location = new System.Drawing.Point(12, 173);
            this.btn_WordUp.Name = "btn_WordUp";
            this.btn_WordUp.Size = new System.Drawing.Size(86, 32);
            this.btn_WordUp.TabIndex = 10;
            this.btn_WordUp.Text = "转大写";
            this.btn_WordUp.UseVisualStyleBackColor = true;
            this.btn_WordUp.Click += new System.EventHandler(this.btn_WordUp_Click);
            // 
            // btn_WordLow
            // 
            this.btn_WordLow.Location = new System.Drawing.Point(104, 173);
            this.btn_WordLow.Name = "btn_WordLow";
            this.btn_WordLow.Size = new System.Drawing.Size(86, 32);
            this.btn_WordLow.TabIndex = 11;
            this.btn_WordLow.Text = "转小写";
            this.btn_WordLow.UseVisualStyleBackColor = true;
            this.btn_WordLow.Click += new System.EventHandler(this.btn_WordLow_Click);
            // 
            // btn_WordReplace
            // 
            this.btn_WordReplace.Location = new System.Drawing.Point(288, 173);
            this.btn_WordReplace.Name = "btn_WordReplace";
            this.btn_WordReplace.Size = new System.Drawing.Size(86, 32);
            this.btn_WordReplace.TabIndex = 12;
            this.btn_WordReplace.Text = "替换";
            this.btn_WordReplace.UseVisualStyleBackColor = true;
            this.btn_WordReplace.Click += new System.EventHandler(this.btn_WordReplace_Click);
            // 
            // text_WordFind
            // 
            this.text_WordFind.Location = new System.Drawing.Point(51, 146);
            this.text_WordFind.Name = "text_WordFind";
            this.text_WordFind.Size = new System.Drawing.Size(243, 21);
            this.text_WordFind.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "查找:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "替换:";
            // 
            // text_WordReplace
            // 
            this.text_WordReplace.Location = new System.Drawing.Point(332, 146);
            this.text_WordReplace.Name = "text_WordReplace";
            this.text_WordReplace.Size = new System.Drawing.Size(230, 21);
            this.text_WordReplace.TabIndex = 17;
            // 
            // btn_WordFind
            // 
            this.btn_WordFind.Location = new System.Drawing.Point(196, 173);
            this.btn_WordFind.Name = "btn_WordFind";
            this.btn_WordFind.Size = new System.Drawing.Size(86, 32);
            this.btn_WordFind.TabIndex = 18;
            this.btn_WordFind.Text = "查找";
            this.btn_WordFind.UseVisualStyleBackColor = true;
            this.btn_WordFind.Click += new System.EventHandler(this.btn_WordFind_Click);
            // 
            // text_WordLength
            // 
            this.text_WordLength.Location = new System.Drawing.Point(608, 146);
            this.text_WordLength.Name = "text_WordLength";
            this.text_WordLength.ReadOnly = true;
            this.text_WordLength.Size = new System.Drawing.Size(68, 21);
            this.text_WordLength.TabIndex = 19;
            this.text_WordLength.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "长度:";
            // 
            // FM_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_WordLength);
            this.Controls.Add(this.btn_WordFind);
            this.Controls.Add(this.text_WordReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_WordFind);
            this.Controls.Add(this.btn_WordReplace);
            this.Controls.Add(this.btn_WordLow);
            this.Controls.Add(this.btn_WordUp);
            this.Controls.Add(this.text_WordOutput);
            this.Controls.Add(this.text_WordInput);
            this.Name = "FM_word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本处理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_WordInput;
        private System.Windows.Forms.TextBox text_WordOutput;
        private System.Windows.Forms.Button btn_WordUp;
        private System.Windows.Forms.Button btn_WordLow;
        private System.Windows.Forms.Button btn_WordReplace;
        private System.Windows.Forms.TextBox text_WordFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_WordReplace;
        private System.Windows.Forms.Button btn_WordFind;
        private System.Windows.Forms.TextBox text_WordLength;
        private System.Windows.Forms.Label label3;
    }
}