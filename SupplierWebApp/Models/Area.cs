using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class Area
    {
        public Area()
        {
            User = new HashSet<User>();
        }

        public int AreaCod { get; set; }
        public string AreaName { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
