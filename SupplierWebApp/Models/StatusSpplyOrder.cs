using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class StatusSpplyOrder
    {
        public StatusSpplyOrder()
        {
            SupplyOrder = new HashSet<SupplyOrder>();
        }

        public int Code { get; set; }
        public bool? Name { get; set; }

        public virtual ICollection<SupplyOrder> SupplyOrder { get; set; }
    }
}
