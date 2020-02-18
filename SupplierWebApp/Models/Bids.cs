using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class Bids
    {
        public Bids()
        {
            Conditions = new HashSet<Conditions>();
        }

        public int BidNumber { get; set; }
        public int? OfferingCode { get; set; }
        public int? OfferingType { get; set; }
        public int? OfferingMethod { get; set; }
        public string UserName { get; set; }
        public int? TecnicalDecisionCode { get; set; }
        public int? StatusTechnicalCode { get; set; }
        public int? StatusFinancialCode { get; set; }

        public virtual BidType BidNumberNavigation { get; set; }
        public virtual OfferingType OfferingCodeNavigation { get; set; }
        public virtual OfferingMethod OfferingMethodNavigation { get; set; }
        public virtual StatusFinacialDecision StatusFinancialCodeNavigation { get; set; }
        public virtual StatusTechnicalDecision StatusTechnicalCodeNavigation { get; set; }
        public virtual User UserNameNavigation { get; set; }
        public virtual ICollection<Conditions> Conditions { get; set; }
    }
}
