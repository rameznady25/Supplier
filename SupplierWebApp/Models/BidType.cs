using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class BidType
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public virtual Bids Bids { get; set; }
    }
}
