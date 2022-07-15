using PRN221PE_SU22_LeMinhQuan.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN221PE_SU22_LeMinhQuan.Repo.Repositories
{
    public class CustomerAccountRepo : ICustomerAccountRepo
    {
        private CustomerAccountsContext _db;
        public CustomerAccountRepo()
        {
            _db = new CustomerAccountsContext();
        }

        public void DeleteAccount(string id)
        {
            try
            {
                CustomerAccount cusAcc = GetByAccountID(id);
                if (cusAcc != null)
                {
                    this._db.Remove(cusAcc);
                    this._db.SaveChanges();
                }
                else
                {
                    throw new Exception("The Account is not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<CustomerAccount> GetAllAccount()
        {
            return this._db.CustomerAccounts;
        }

        public CustomerAccount GetByAccountID(string id)
        {
            var data = this._db.CustomerAccounts.Where(a => a.AccountId == id);
            return data.FirstOrDefault();
        }

        public void InsertAccount(CustomerAccount account)
        {
            try
            {
                CustomerAccount cusAcc = GetByAccountID(account.AccountId);
                if (cusAcc == null)
                {
                    this._db.Add(account);
                    this._db.SaveChanges();
                }
                else
                {
                    throw new Exception("The Account is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateAccount(CustomerAccount account)
        {
            try
            {
                CustomerAccount cusAcc = GetByAccountID(account.AccountId);
                if (cusAcc != null)
                {
                    this._db.Update(account);
                    this._db.SaveChanges();
                }
                else
                {
                    throw new Exception("The Account is not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
