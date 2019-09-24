using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Udfmaster
    {
        public Udfmaster()
        {
            CostHeadMaster = new HashSet<CostHeadMaster>();
        }

        public string UdfmasterId { get; set; }
        public string Udfcode { get; set; }
        public string Udfdesc { get; set; }
        public string AssemblyPath { get; set; }
        public string FunctionDesc { get; set; }
        public string ClassName { get; set; }
        public string FunctionName { get; set; }
        public byte? NoOfParameter { get; set; }
        public string ReturnType { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }

        public virtual ICollection<CostHeadMaster> CostHeadMaster { get; set; }
    }
}
