using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class StatusTechnicalDecision
    {
        public StatusTechnicalDecision()
        {
            Bids = new HashSet<Bids>();
        }

        public int Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Bids> Bids { get; set; }
    }
}
