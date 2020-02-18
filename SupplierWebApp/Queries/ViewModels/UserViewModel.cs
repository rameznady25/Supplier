using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class UserViewModel
    {

        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Balance { get; set; }
        public string NickName { get; set; }
        public string UserName { get; set; }
        public int? SuuplierCode { get; set; }
        public int? AreaCode { get; set; }

    }
}
