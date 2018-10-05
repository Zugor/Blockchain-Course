namespace BlockChainCourse.Cryptography
{
    partial class Form1
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.RichTextBox();
            this.txtSignature = new System.Windows.Forms.RichTextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.hashType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(478, 18);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 39);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hashType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.txtMsg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(87, 84);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(336, 20);
            this.txtResult.TabIndex = 12;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(87, 29);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(336, 20);
            this.txtMsg.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plaintext:";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(478, 154);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(94, 39);
            this.btnSign.TabIndex = 14;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(478, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(478, 77);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 39);
            this.btnDecrypt.TabIndex = 16;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrivateKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPublicKey);
            this.groupBox2.Controls.Add(this.txtSignature);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 251);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Private Key:";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(232, 136);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(191, 91);
            this.txtPrivateKey.TabIndex = 3;
            this.txtPrivateKey.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Public Key:";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(22, 136);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(191, 91);
            this.txtPublicKey.TabIndex = 1;
            this.txtPublicKey.Text = "";
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(22, 30);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(400, 71);
            this.txtSignature.TabIndex = 0;
            this.txtSignature.Text = "";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(478, 210);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(94, 39);
            this.btnVerify.TabIndex = 17;
            this.btnVerify.Text = "Verify Signature";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hash Func:";
            // 
            // hashType
            // 
            this.hashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashType.FormattingEnabled = true;
            this.hashType.Items.AddRange(new object[] {
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hashType.Location = new System.Drawing.Point(87, 57);
            this.hashType.Name = "hashType";
            this.hashType.Size = new System.Drawing.Size(336, 21);
            this.hashType.TabIndex = 14;
            this.hashType.SelectedIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption - Zugor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtPublicKey;
        private System.Windows.Forms.RichTextBox txtSignature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtPrivateKey;
        private System.Windows.Forms.ComboBox hashType;
        private System.Windows.Forms.Label label5;
    }
}

