using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CommProcessed
    {
        public string CommProcessedId { get; set; }
        public string CommProcessingId { get; set; }
        public string InvoiceHeaderId { get; set; }
        public string SocommissionId { get; set; }
        public string CommTypeId { get; set; }
        public string VouMasterId { get; set; }
        public string AgentId { get; set; }
        public string VouId { get; set; }
        public string Glid { get; set; }
        public string Cpstatus { get; set; }
        public DateTime? ApprDt { get; set; }
        public decimal? CreditPer { get; set; }
        public decimal? CommisionPer { get; set; }
        public decimal? CreditAmt { get; set; }
        public decimal? CommissionAmt { get; set; }
        public decimal? TotalAmt { get; set; }
    }
}
