using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221PE_SU22_LeMinhQuan.Repo.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAccounts = new HashSet<CustomerAccount>();
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomersDesc { get; set; }

        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
    }
}
