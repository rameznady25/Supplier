using System;
using System.Collections.Generic;

namespace SupplierWebApp.Queries.ViewModels
{
    public partial class DetailsViewModel
    {
 
        public int Code { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Value { get; set; }
        public DateTime? SupplyDate { get; set; }

    }
}
