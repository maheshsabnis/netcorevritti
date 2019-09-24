using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmOutcome
    {
        public string PkoutcomeId { get; set; }
        public string Outcome { get; set; }
        public string IsActivity { get; set; }
        public string IsEmail { get; set; }
        public string Code { get; set; }
        public string ActivityTypeId { get; set; }
        public bool? ActivityFunctionality { get; set; }
        public bool? EmailFunctionality { get; set; }
        public string OutcomeType { get; set; }
        public string ShowOthers { get; set; }
        public decimal? MilestoneSeqNo { get; set; }
        public decimal? LeadTime { get; set; }
        public string IsRequest { get; set; }
        public string IsApprover { get; set; }
        public bool? AccessToAssociate { get; set; }
    }
}
