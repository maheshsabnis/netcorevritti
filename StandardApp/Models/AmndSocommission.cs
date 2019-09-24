using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AmndSocommission
    {
        public string AmndSocommissionId { get; set; }
        public string AmndSoheaderId { get; set; }
        public string Lcno { get; set; }
        public decimal? Lcvalue { get; set; }
        public decimal? Commision { get; set; }
        public string AgentId { get; set; }
        public decimal? CommisionPer { get; set; }
        public string CommisionOn { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
