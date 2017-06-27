namespace CTFDecryptEncrypt
{
    partial class FM_Conversion
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
            this.text_ConversionInput = new System.Windows.Forms.TextBox();
            this.text_ConversionOutput = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.fromNum = new System.Windows.Forms.ComboBox();
            this.toNum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_ConversionInput
            // 
            this.text_ConversionInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_ConversionInput.Location = new System.Drawing.Point(13, 13);
            this.text_ConversionInput.Multiline = true;
            this.text_ConversionInput.Name = "text_ConversionInput";
            this.text_ConversionInput.Size = new System.Drawing.Size(517, 85);
            this.text_ConversionInput.TabIndex = 0;
            // 
            // text_ConversionOutput
            // 
            this.text_ConversionOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_ConversionOutput.Location = new System.Drawing.Point(12, 157);
            this.text_ConversionOutput.Multiline = true;
            this.text_ConversionOutput.Name = "text_ConversionOutput";
            this.text_ConversionOutput.Size = new System.Drawing.Size(517, 92);
            this.text_ConversionOutput.TabIndex = 1;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(425, 115);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(49, 23);
            this.btn_Convert.TabIndex = 4;
            this.btn_Convert.Text = "转";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // fromNum
            // 
            this.fromNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromNum.FormatString = "N0";
            this.fromNum.FormattingEnabled = true;
            this.fromNum.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.fromNum.Location = new System.Drawing.Point(366, 117);
            this.fromNum.Name = "fromNum";
            this.fromNum.Size = new System.Drawing.Size(53, 20);
            this.fromNum.TabIndex = 5;
            // 
            // toNum
            // 
            this.toNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toNum.FormatString = "N0";
            this.toNum.FormattingEnabled = true;
            this.toNum.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.toNum.Location = new System.Drawing.Point(482, 117);
            this.toNum.Name = "toNum";
            this.toNum.Size = new System.Drawing.Size(48, 20);
            this.toNum.TabIndex = 6;
            // 
            // FM_Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.toNum);
            this.Controls.Add(this.fromNum);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.text_ConversionOutput);
            this.Controls.Add(this.text_ConversionInput);
            this.Name = "FM_Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进制转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_ConversionInput;
        private System.Windows.Forms.TextBox text_ConversionOutput;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.ComboBox fromNum;
        private System.Windows.Forms.ComboBox toNum;
    }
}