using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostHeadMaster
    {
        public CostHeadMaster()
        {
            CostRate = new HashSet<CostRate>();
        }

        public string CostHeadMasterId { get; set; }
        public string CostHeadCode { get; set; }
        public string CostHeadDesc { get; set; }
        public string CostHeadType { get; set; }
        public string Active { get; set; }
        public string Formating { get; set; }
        public string UdfmasterId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string InputLevel { get; set; }
        public string IplvlOrder { get; set; }

        public virtual Udfmaster Udfmaster { get; set; }
        public virtual ICollection<CostRate> CostRate { get; set; }
    }
}
