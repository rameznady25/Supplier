using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class Place
    {
        public Place()
        {
            Conditions = new HashSet<Conditions>();
        }

        public int Code { get; set; }
        public string Comission { get; set; }
        public string Branches { get; set; }
        public int? ConditionCode { get; set; }

        public virtual ICollection<Conditions> Conditions { get; set; }
    }
}
