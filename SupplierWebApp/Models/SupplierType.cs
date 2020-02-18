using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class SupplierType
    {
        public SupplierType()
        {
            User = new HashSet<User>();
        }

        public int SuuplierCod { get; set; }
        public string SuopplierName { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
