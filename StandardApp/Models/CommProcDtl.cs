using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CommProcDtl
    {
        public string CommProcDtlId { get; set; }
        public string CommProcHdrId { get; set; }
        public string InvoiceHeaderId { get; set; }
        public string ReceiptId { get; set; }
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
        public decimal? DocAmt { get; set; }
        public string CommSummaryId { get; set; }
        public decimal? InvDiv { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
