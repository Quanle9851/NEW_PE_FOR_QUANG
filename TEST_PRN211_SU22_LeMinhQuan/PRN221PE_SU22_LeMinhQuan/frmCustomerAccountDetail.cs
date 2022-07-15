using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN221PE_SU22_LeMinhQuan.Repo.Models;
using PRN221PE_SU22_LeMinhQuan.Repo.Repositories;

namespace PRN221PE_SU22_LeMinhQuan
{
    public partial class frmCustomerAccountDetail : Form
    {
        public bool InsertOrUpdate { get; set; }
        public ICustomerAccountRepo CustomerAccountRepo { get; set; }
        public CustomerAccount CustomerAccount { get; set; }
        public frmCustomerAccountDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var account = new CustomerAccount
                {
                    AccountId = txtAccountID.Text,
                    AccountName = txtAccountName.Text,
                    OpenDate = DateTime.Parse(txtOpenDate.Text),
                    CustomerId = txtCustomerID.Text,
                    RegionName = txtRegionName.Text,
                };
                if(InsertOrUpdate == false)
                {
                    CustomerAccountRepo.InsertAccount(account);
                }
                else
                {
                    CustomerAccountRepo.UpdateAccount(account);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new " : "update ");
            }
        }

        private void frmCustomerAccountDetail_Load(object sender, EventArgs e)
        {
            txtAccountID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtAccountID.Text = CustomerAccount.AccountId;
                txtAccountName.Text = CustomerAccount.AccountName;
                txtCustomerID.Text = CustomerAccount.CustomerId;
                txtOpenDate.Text = CustomerAccount.OpenDate.ToString();
                txtRegionName.Text = CustomerAccount.RegionName;
            }
        }

        private void txtOpenDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtRegionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
