using System;
using System.Collections.Generic;

namespace SupplierWebApp.Queries.ViewModels
{
    public partial class BidsViewModel
    {

        public int BidNumber { get; set; }
        public int? OfferingCode { get; set; }
        public int? OfferingType { get; set; }
        public int? OfferingMethod { get; set; }
        public string UserName { get; set; }
        public int? TecnicalDecisionCode { get; set; }
        public int? StatusTechnicalCode { get; set; }
        public int? StatusFinancialCode { get; set; }

    }
}
