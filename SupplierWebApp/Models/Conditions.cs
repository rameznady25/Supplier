using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class Conditions
    {
        public int Code { get; set; }
        public decimal? Price { get; set; }
        public int? SchoolCode { get; set; }
        public decimal? PrimaryInsurance { get; set; }
        public DateTime? InsurancePayment { get; set; }
        public int? PlaceCode { get; set; }
        public int? BidNumber { get; set; }

        public virtual Bids BidNumberNavigation { get; set; }
        public virtual Place PlaceCodeNavigation { get; set; }
        public virtual School SchoolCodeNavigation { get; set; }
    }
}
