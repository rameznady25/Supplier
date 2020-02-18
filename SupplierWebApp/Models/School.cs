using System;
using System.Collections.Generic;

namespace SupplierWebApp.Models
{
    public partial class School
    {
        public School()
        {
            Conditions = new HashSet<Conditions>();
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public int? ConditionCode { get; set; }

        public virtual ICollection<Conditions> Conditions { get; set; }
    }
}
