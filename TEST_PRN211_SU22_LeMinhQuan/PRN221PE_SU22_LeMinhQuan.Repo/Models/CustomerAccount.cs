using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221PE_SU22_LeMinhQuan.Repo.Models
{
    public partial class CustomerAccount
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? OpenDate { get; set; }
        public string RegionName { get; set; }
        public string CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
