using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class SupplyOrder
    {
        public DateTime? SupplyDate { get; set; }
        public string SchoolName { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public int? StatusCode { get; set; }
        public int? OrderNumber { get; set; }
        public int? DetailsCode { get; set; }
        public string UserName { get; set; }

        public virtual Details DetailsCodeNavigation { get; set; }
        public virtual StatusSpplyOrder StatusCodeNavigation { get; set; }
        public virtual User UserNameNavigation { get; set; }
    }
}
