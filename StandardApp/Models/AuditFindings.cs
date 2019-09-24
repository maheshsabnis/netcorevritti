using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AuditFindings
    {
        public string AuditFindingId { get; set; }
        public string AuditPlanId { get; set; }
        public int? SrNo { get; set; }
        public string AuditPointId { get; set; }
        public string Remarks { get; set; }
        public string RootCause { get; set; }
        public decimal? Nctype { get; set; }
    }
}
