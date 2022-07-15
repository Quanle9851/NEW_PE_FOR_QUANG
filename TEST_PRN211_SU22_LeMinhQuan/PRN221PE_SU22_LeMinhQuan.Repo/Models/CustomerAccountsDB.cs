using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PRN221PE_SU22_LeMinhQuan.Repo.Models
{
    public partial class CustomerAccountsContext : DbContext
    {
        public CustomerAccountsContext(string conn)
        {
            this.Database.SetConnectionString(conn);
        }
    }
}
