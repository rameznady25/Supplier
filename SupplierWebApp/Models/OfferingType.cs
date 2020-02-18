using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class OfferingType
    {
        public OfferingType()
        {
            Bids = new HashSet<Bids>();
        }

        public int OfferingCod { get; set; }
        public string OfferingName { get; set; }

        public virtual ICollection<Bids> Bids { get; set; }
    }
}
