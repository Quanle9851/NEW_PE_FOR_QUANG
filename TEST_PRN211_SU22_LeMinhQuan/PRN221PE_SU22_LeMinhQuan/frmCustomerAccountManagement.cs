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
    public partial class frmCustomerAccountManagement : Form
    {
        BindingSource source;
        ICustomerAccountRepo AccountRepository =  new CustomerAccountRepo();

        public frmCustomerAccountManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
                txtAccountID.Enabled=false;
                txtAccountName.Enabled=false;
                txtCustomerID.Enabled=false;
                txtOpenDate.Enabled=false;
                txtRegionName.Enabled=false;
                btnDelete.Enabled = false;
                dgvCustomerAccountList.CellDoubleClick += dgvCustomerAccountList_CellDoubleClick;
        }

        private void dgvCustomerAccountList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCustomerAccountDetail frmAccountDetails = new frmCustomerAccountDetail
            {
                Text = "Update Customer Account",
                InsertOrUpdate = true,
                CustomerAccountRepo = AccountRepository,
                CustomerAccount = GetAccountObject()
            };
            if (frmAccountDetails.ShowDialog() == DialogResult.OK)
            {
                LoadAccountList();
                //Set focus member updated
                source.Position = source.Count - 1;
            }
        }

        public void LoadAccountList()
        {
            var accounts = AccountRepository.GetAllAccount();
            try
            {

                source = new BindingSource();
                source.DataSource = accounts.OrderByDescending(a => a.AccountName);
                
                txtAccountID.DataBindings.Clear();
                txtAccountName.DataBindings.Clear();
                txtCustomerID.DataBindings.Clear();
                txtOpenDate.DataBindings.Clear();
                txtRegionName.DataBindings.Clear();

                txtAccountID.DataBindings.Add("Text", source, "AccountId");
                txtAccountName.DataBindings.Add("Text", source, "AccountName");
                txtCustomerID.DataBindings.Add("Text", source, "CustomerId");
                txtOpenDate.DataBindings.Add("Text", source, "OpenDate");
                txtRegionName.DataBindings.Add("Text", source, "RegionName");


                dgvCustomerAccountList.DataSource = null;
                dgvCustomerAccountList.DataSource = source;
                
                    if (accounts.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Account list");
            }
        }

        private void ClearText()
        {
            txtAccountID.Text = string.Empty;
            txtAccountName.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtOpenDate.Text = string.Empty;
            txtRegionName.Text = string.Empty;
        }

        private CustomerAccount GetAccountObject()
        {
            CustomerAccount account = null;
            try
            {
                account = new CustomerAccount
                {
                    AccountId = txtAccountID.Text,
                    AccountName = txtAccountName.Text,
                    RegionName = txtRegionName.Text,
                    CustomerId = txtCustomerID.Text,
                    OpenDate = DateTime.Parse(txtOpenDate.Text),
                };
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return account;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var account = GetAccountObject();
                AccountRepository.DeleteAccount(account.AccountId);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Account");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomerAccountDetail frm = new frmCustomerAccountDetail
            {
                Text = "Add Customer Account",
                InsertOrUpdate = false,
                CustomerAccountRepo = new CustomerAccountRepo(),
            };
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadAccountList();
                source.Position = source.Position - 1;
            }
        }
    }
}
