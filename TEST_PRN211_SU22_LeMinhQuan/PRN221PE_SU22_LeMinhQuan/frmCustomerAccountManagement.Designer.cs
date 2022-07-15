namespace PRN221PE_SU22_LeMinhQuan
{
    partial class frmCustomerAccountManagement
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.txtRegionName = new System.Windows.Forms.TextBox();
            this.txtOpenDate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lbRegionName = new System.Windows.Forms.Label();
            this.lbOpenDate = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomerAccountList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(625, 113);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(267, 27);
            this.txtCustomerID.TabIndex = 66;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(510, 116);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(91, 20);
            this.lbCustomerID.TabIndex = 65;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // txtRegionName
            // 
            this.txtRegionName.Location = new System.Drawing.Point(625, 74);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(267, 27);
            this.txtRegionName.TabIndex = 64;
            // 
            // txtOpenDate
            // 
            this.txtOpenDate.Location = new System.Drawing.Point(625, 32);
            this.txtOpenDate.Name = "txtOpenDate";
            this.txtOpenDate.Size = new System.Drawing.Size(267, 27);
            this.txtOpenDate.TabIndex = 63;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(770, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 29);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(396, 171);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 29);
            this.btnNew.TabIndex = 61;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(24, 171);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(136, 29);
            this.btnLoad.TabIndex = 60;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(144, 74);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(288, 27);
            this.txtAccountName.TabIndex = 59;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(144, 32);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(288, 27);
            this.txtAccountID.TabIndex = 58;
            // 
            // lbRegionName
            // 
            this.lbRegionName.AutoSize = true;
            this.lbRegionName.Location = new System.Drawing.Point(510, 77);
            this.lbRegionName.Name = "lbRegionName";
            this.lbRegionName.Size = new System.Drawing.Size(100, 20);
            this.lbRegionName.TabIndex = 57;
            this.lbRegionName.Text = "Region Name";
            // 
            // lbOpenDate
            // 
            this.lbOpenDate.AutoSize = true;
            this.lbOpenDate.Location = new System.Drawing.Point(510, 35);
            this.lbOpenDate.Name = "lbOpenDate";
            this.lbOpenDate.Size = new System.Drawing.Size(81, 20);
            this.lbOpenDate.TabIndex = 56;
            this.lbOpenDate.Text = "Open Date";
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(12, 78);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(107, 20);
            this.lbAccountName.TabIndex = 55;
            this.lbAccountName.Text = "Account Name";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Location = new System.Drawing.Point(12, 35);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(82, 20);
            this.lbAccountID.TabIndex = 54;
            this.lbAccountID.Text = "Account ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 217);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 69;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 217);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search member";
            this.txtSearch.Size = new System.Drawing.Size(244, 27);
            this.txtSearch.TabIndex = 68;
            // 
            // dgvCustomerAccountList
            // 
            this.dgvCustomerAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerAccountList.Location = new System.Drawing.Point(24, 250);
            this.dgvCustomerAccountList.Name = "dgvCustomerAccountList";
            this.dgvCustomerAccountList.ReadOnly = true;
            this.dgvCustomerAccountList.RowHeadersWidth = 51;
            this.dgvCustomerAccountList.RowTemplate.Height = 29;
            this.dgvCustomerAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerAccountList.Size = new System.Drawing.Size(939, 188);
            this.dgvCustomerAccountList.TabIndex = 67;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(396, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 29);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomerAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 487);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvCustomerAccountList);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.txtOpenDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.lbRegionName);
            this.Controls.Add(this.lbOpenDate);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.lbAccountID);
            this.Name = "frmCustomerAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerAccountManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAccountList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.TextBox txtRegionName;
        private System.Windows.Forms.TextBox txtOpenDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lbRegionName;
        private System.Windows.Forms.Label lbOpenDate;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label lbAccountID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomerAccountList;
        private System.Windows.Forms.Button btnClose;
    }
}