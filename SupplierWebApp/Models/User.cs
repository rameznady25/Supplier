﻿using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class User
    {
        public User()
        {
            Bids = new HashSet<Bids>();
            SupplyOrder = new HashSet<SupplyOrder>();
        }

        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Balance { get; set; }
        public string NickName { get; set; }
        public string UserName { get; set; }
        public int? SuuplierCode { get; set; }
        public int? AreaCode { get; set; }

        public virtual Area AreaCodeNavigation { get; set; }
        public virtual SupplierType SuuplierCodeNavigation { get; set; }
        public virtual ICollection<Bids> Bids { get; set; }
        public virtual ICollection<SupplyOrder> SupplyOrder { get; set; }
    }
}
