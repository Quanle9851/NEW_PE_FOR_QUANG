using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using PRN221PE_SU22_LeMinhQuan.Repo.Models;
namespace PRN221PE_SU22_LeMinhQuan
{
    public partial class frmLogin : Form
    {
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",true,true)
                .Build();
            var strConn = config["ConnectionStrings:CustomersAccountDB"];
            return strConn;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if (txtUserName.Text == "")
            {
                MessageBox.Show("Please input user name!");
            }
           else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please input Password!");
            }
            else
            {
                string cs = GetConnectionString();

                using (var db  = new CustomerAccountsContext(cs))
                {
                    var user = db.Users.Where(u => u.UserId == txtUserName.Text && u.Password == txtPassword.Text).FirstOrDefault();
                    if (user == null)
                    {
                        MessageBox.Show("Invalid User Name or Password!");
                    }
                    else
                    {
                        if (user.UserRole == 1)
                        {
                            frmCustomerAccountManagement mainForm = new frmCustomerAccountManagement();
                            this.Hide();
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("You are not allow to access this function!");
                        }
                    }
                }
            }
        }



    }
}
