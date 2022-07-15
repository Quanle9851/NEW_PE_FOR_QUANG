using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221PE_SU22_LeMinhQuan.Repo.Models
{
    public partial class User
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int? UserRole { get; set; }
    }
}
