namespace BlockWithMultipleTransactions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_inTransactions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nameBlock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_blockList = new System.Windows.Forms.ComboBox();
            this.dtg_outTransactions = new System.Windows.Forms.DataGridView();
            this.btn_addTransactions = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn_verify = new System.Windows.Forms.Button();
            this.txt_logs = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.claimNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlementAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_inTransactions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtg_inTransactions);
            this.groupBox1.Controls.Add(this.txt_nameBlock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Block Creation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Transactions";
            // 
            // dtg_inTransactions
            // 
            this.dtg_inTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_inTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtg_inTransactions.Location = new System.Drawing.Point(9, 54);
            this.dtg_inTransactions.Name = "dtg_inTransactions";
            this.dtg_inTransactions.Size = new System.Drawing.Size(540, 150);
            this.dtg_inTransactions.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Claim Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Settlement Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Car Registration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Mileage";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // txt_nameBlock
            // 
            this.txt_nameBlock.AutoSize = true;
            this.txt_nameBlock.Location = new System.Drawing.Point(51, 27);
            this.txt_nameBlock.Name = "txt_nameBlock";
            this.txt_nameBlock.Size = new System.Drawing.Size(43, 13);
            this.txt_nameBlock.TabIndex = 1;
            this.txt_nameBlock.Text = "Block 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_blockList);
            this.groupBox2.Controls.Add(this.dtg_outTransactions);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Block Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Block:";
            // 
            // cb_blockList
            // 
            this.cb_blockList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_blockList.FormattingEnabled = true;
            this.cb_blockList.Location = new System.Drawing.Point(54, 28);
            this.cb_blockList.Name = "cb_blockList";
            this.cb_blockList.Size = new System.Drawing.Size(294, 21);
            this.cb_blockList.TabIndex = 6;
            this.cb_blockList.SelectedIndexChanged += new System.EventHandler(this.cb_blockList_SelectedIndexChanged);
            // 
            // dtg_outTransactions
            // 
            this.dtg_outTransactions.AllowUserToAddRows = false;
            this.dtg_outTransactions.AllowUserToDeleteRows = false;
            this.dtg_outTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_outTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claimNumber,
            this.settlementAmount,
            this.settlementDate,
            this.carRegistration,
            this.mileage,
            this.claimType});
            this.dtg_outTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_outTransactions.Location = new System.Drawing.Point(9, 65);
            this.dtg_outTransactions.Name = "dtg_outTransactions";
            this.dtg_outTransactions.ReadOnly = true;
            this.dtg_outTransactions.RowHeadersVisible = false;
            this.dtg_outTransactions.Size = new System.Drawing.Size(540, 150);
            this.dtg_outTransactions.TabIndex = 4;
            // 
            // btn_addTransactions
            // 
            this.btn_addTransactions.Location = new System.Drawing.Point(578, 35);
            this.btn_addTransactions.Name = "btn_addTransactions";
            this.btn_addTransactions.Size = new System.Drawing.Size(194, 47);
            this.btn_addTransactions.TabIndex = 5;
            this.btn_addTransactions.Text = "Add Transactions";
            this.btn_addTransactions.UseVisualStyleBackColor = true;
            this.btn_addTransactions.Click += new System.EventHandler(this.btn_addTransactions_Click);
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(578, 88);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(194, 47);
            this.btn_sign.TabIndex = 6;
            this.btn_sign.Text = "Sign Transactions";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(578, 141);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(194, 47);
            this.btn_verify.TabIndex = 7;
            this.btn_verify.Text = "Verify Signature";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // txt_logs
            // 
            this.txt_logs.Location = new System.Drawing.Point(587, 297);
            this.txt_logs.Name = "txt_logs";
            this.txt_logs.ReadOnly = true;
            this.txt_logs.Size = new System.Drawing.Size(185, 202);
            this.txt_logs.TabIndex = 8;
            this.txt_logs.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "LOGS";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(578, 194);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(194, 47);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // claimNumber
            // 
            this.claimNumber.DataPropertyName = "claimNumber";
            this.claimNumber.HeaderText = "Claim Number";
            this.claimNumber.Name = "claimNumber";
            this.claimNumber.ReadOnly = true;
            // 
            // settlementAmount
            // 
            this.settlementAmount.DataPropertyName = "settlementAmount";
            this.settlementAmount.HeaderText = "Settlement Amount";
            this.settlementAmount.Name = "settlementAmount";
            this.settlementAmount.ReadOnly = true;
            // 
            // settlementDate
            // 
            this.settlementDate.DataPropertyName = "settlementDate";
            this.settlementDate.HeaderText = "Settlement Date";
            this.settlementDate.Name = "settlementDate";
            this.settlementDate.ReadOnly = true;
            // 
            // carRegistration
            // 
            this.carRegistration.DataPropertyName = "carRegistration";
            this.carRegistration.HeaderText = "Car Registration";
            this.carRegistration.Name = "carRegistration";
            this.carRegistration.ReadOnly = true;
            // 
            // mileage
            // 
            this.mileage.DataPropertyName = "mileage";
            this.mileage.HeaderText = "Mileage";
            this.mileage.Name = "mileage";
            this.mileage.ReadOnly = true;
            // 
            // claimType
            // 
            this.claimType.DataPropertyName = "claimType";
            this.claimType.HeaderText = "Claim Type";
            this.claimType.Name = "claimType";
            this.claimType.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_logs);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn_addTransactions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blockchain Test - Zugor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_inTransactions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_inTransactions;
        private System.Windows.Forms.Label txt_nameBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_blockList;
        private System.Windows.Forms.DataGridView dtg_outTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addTransactions;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.RichTextBox txt_logs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlementAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn carRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimType;
    }
}

