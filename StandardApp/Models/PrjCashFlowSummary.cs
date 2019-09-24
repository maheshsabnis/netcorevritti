using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PrjCashFlowSummary
    {
        public decimal RecId { get; set; }
        public string FinDivId { get; set; }
        public string PrjCashFlowSummId { get; set; }
        public string Description { get; set; }
        public decimal? ReceivableAmt { get; set; }
        public decimal? PayableAmt { get; set; }
        public string WeekNo { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? WeekEndDate { get; set; }
        public string Ref { get; set; }
        public string Entity { get; set; }
        public string EntityCode { get; set; }
        public decimal? CumulativeTot { get; set; }
        public decimal? DispSeq { get; set; }
    }
}
