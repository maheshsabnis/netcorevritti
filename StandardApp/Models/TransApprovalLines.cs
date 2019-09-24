using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransApprovalLines
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransApprovalLinesId { get; set; }
        public string FinDivId { get; set; }
        public string ApprLineNo { get; set; }
        public string ApprUser { get; set; }
        public DateTime? DtApprReq { get; set; }
        public DateTime? DateResponseRecd { get; set; }
        public string ApprStatus { get; set; }
        public string Reason { get; set; }
        public string ApprLineTransPosted { get; set; }
        public string NarrativeId { get; set; }
        public string SeqTransNo { get; set; }
        public string SeqTransType { get; set; }
        public string SeqFinDivId { get; set; }
        public string SeqLadger { get; set; }
        public DateTime? SeqDocDate { get; set; }
        public DateTime? SeqEffDate { get; set; }
        public DateTime? SeqSupplyDate { get; set; }
        public string SeqPeriod { get; set; }
        public decimal? SeqPeriodDisSeq { get; set; }
        public string SeqEntity { get; set; }
        public string SeqCurrency { get; set; }
        public string SeqOriginUnit { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
