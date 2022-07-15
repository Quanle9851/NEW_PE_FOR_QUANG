using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN221PE_SU22_LeMinhQuan.Repo.Models;

namespace PRN221PE_SU22_LeMinhQuan.Repo.Repositories
{
    public interface ICustomerAccountRepo
    {
        IEnumerable<CustomerAccount> GetAllAccount(); 
        CustomerAccount GetByAccountID(string id);
        void InsertAccount(CustomerAccount account);
        void DeleteAccount(string id);
        void UpdateAccount(CustomerAccount account);
    }
}
