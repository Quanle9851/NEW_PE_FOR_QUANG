namespace PRN221PE_SU22_LeMinhQuan
{
    partial class frmCustomerAccountDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtRegionName = new System.Windows.Forms.TextBox();
            this.txtOpenDate = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Open Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Region Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(194, 38);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(216, 27);
            this.txtAccountID.TabIndex = 5;
            this.txtAccountID.TextChanged += new System.EventHandler(this.txtAccountID_TextChanged);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(194, 77);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(216, 27);
            this.txtAccountName.TabIndex = 6;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtAccountName_TextChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(194, 116);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(216, 27);
            this.txtCustomerID.TabIndex = 7;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // txtRegionName
            // 
            this.txtRegionName.Location = new System.Drawing.Point(194, 202);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(216, 27);
            this.txtRegionName.TabIndex = 8;
            this.txtRegionName.TextChanged += new System.EventHandler(this.txtRegionName_TextChanged);
            // 
            // txtOpenDate
            // 
            this.txtOpenDate.Location = new System.Drawing.Point(194, 158);
            this.txtOpenDate.Mask = "00/00/0000";
            this.txtOpenDate.Name = "txtOpenDate";
            this.txtOpenDate.Size = new System.Drawing.Size(216, 27);
            this.txtOpenDate.TabIndex = 9;
            this.txtOpenDate.ValidatingType = typeof(System.DateTime);
            this.txtOpenDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtOpenDate_MaskInputRejected);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomerAccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOpenDate);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerAccountDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerAccountDetail";
            this.Load += new System.EventHandler(this.frmCustomerAccountDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtRegionName;
        private System.Windows.Forms.MaskedTextBox txtOpenDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}