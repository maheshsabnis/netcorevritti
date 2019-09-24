using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CommProcessing
    {
        public string CommProcessingId { get; set; }
        public string InvoiceHeaderId { get; set; }
        public string SocommissionId { get; set; }
        public string AgentId { get; set; }
        public string VouId { get; set; }
        public string Cpstatus { get; set; }
        public DateTime? ApprDt { get; set; }
        public decimal? CommissionAmt { get; set; }
    }
}
