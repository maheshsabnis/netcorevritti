using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CommSummary
    {
        public string CommSummaryId { get; set; }
        public string CommProcHdrId { get; set; }
        public string AgentId { get; set; }
        public decimal? VouAmt { get; set; }
        public string VouId { get; set; }
        public DateTime? VouDate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
