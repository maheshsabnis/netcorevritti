using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Socommission
    {
        public string SocommissionId { get; set; }
        public string SoheaderId { get; set; }
        public string Lcno { get; set; }
        public decimal? Lcvalue { get; set; }
        public decimal? Commision { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string AgentId { get; set; }
        public decimal? CommisionPer { get; set; }
        public string CommisionOn { get; set; }
        public string CommissionType { get; set; }
        public decimal? CreditPer { get; set; }
        public string CommType { get; set; }
        public string VouId { get; set; }
        public decimal? CommisionFc { get; set; }
        public string CommProcDtlId { get; set; }
        public string Remark { get; set; }
    }
}
