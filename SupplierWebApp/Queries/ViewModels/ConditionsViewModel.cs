using System;
using System.Collections.Generic;

namespace SupplierWebApp.Queries.ViewModels
{
    public partial class ConditionsViewModel
    {
        public int Code { get; set; }
        public decimal? Price { get; set; }
        public int? SchoolCode { get; set; }
        public decimal? PrimaryInsurance { get; set; }
        public DateTime? InsurancePayment { get; set; }
        public int? PlaceCode { get; set; }
        public int? BidNumber { get; set; }

    }
}
