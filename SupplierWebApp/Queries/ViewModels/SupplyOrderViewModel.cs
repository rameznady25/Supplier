using System;
using System.Collections.Generic;

namespace SupplierWebApp.Queries.ViewModels
{
    public partial class SupplyOrderViewModel
    {
        public DateTime? SupplyDate { get; set; }
        public string SchoolName { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public int? StatusCode { get; set; }
        public int? OrderNumber { get; set; }
        public int? DetailsCode { get; set; }
        public string UserName { get; set; }

    }
}
