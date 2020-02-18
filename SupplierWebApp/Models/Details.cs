using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class Details
    {
        public Details()
        {
            SupplyOrder = new HashSet<SupplyOrder>();
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Value { get; set; }
        public DateTime? SupplyDate { get; set; }

        public virtual ICollection<SupplyOrder> SupplyOrder { get; set; }
    }
}
