using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN221PE_SU22_LeMinhQuan.Repo.Models;

namespace PRN221PE_SU22_LeMinhQuan.Repo.Repositories
{
    public class CustomerAccountDAO
    {
        private static CustomerAccountDAO instance = null;
        private static readonly object instanceLock = new object();
        private CustomerAccountDAO() { }
        public static CustomerAccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerAccountDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<CustomerAccount> GetAccountList()
        {
            var accounts = new List<CustomerAccount>();
            try
            {
                using var context = new CustomerAccountsContext();
                accounts = context.CustomerAccounts.ToList();              

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return accounts;

        }

        public CustomerAccount GetAccountByID(string ID)
        {
            CustomerAccount acc = null;
            try
            {
                using var context = new CustomerAccountsContext();

                acc = context.CustomerAccounts.SingleOrDefault(m => m.AccountId == ID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return acc;
        }

        public void AddNew(CustomerAccount acc)
        {
            try
            {
                CustomerAccount account = GetAccountByID(acc.AccountId);
                if (account == null)
                {
                    using var context = new CustomerAccountsContext();
                    context.CustomerAccounts.Add(account);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The account is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
