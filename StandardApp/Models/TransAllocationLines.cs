using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransAllocationLines
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransAllocationLinesId { get; set; }
        public string FinDivId { get; set; }
        public string AllocLineNo { get; set; }
        public string AllocateToAdminDiv { get; set; }
        public string AllocateToTrans { get; set; }
        public string AllocateToSettlmnt { get; set; }
        public decimal? LineVal { get; set; }
        public decimal? LineValFc { get; set; }
        public string AllocType { get; set; }
        public string PersonalLgrLineStatus { get; set; }
        public string LinePayList { get; set; }
        public string LinePayListLine { get; set; }
        public DateTime? TargetDocDt { get; set; }
        public string DebitNoteTransId { get; set; }
        public string AllocLineType { get; set; }
        public string AdjUnit { get; set; }
        public string AdjAccId { get; set; }
        public decimal? ChqNo { get; set; }
        public string LodgeDepositNo { get; set; }
        public string NarrativeId { get; set; }
        public string TransSettlementLinesId { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IntAcntId { get; set; }
        public string DiscAcntId { get; set; }
        public decimal? IntAmnt { get; set; }
        public decimal? DiscAmnt { get; set; }
        public decimal? ExchLossGain { get; set; }
        public string LineSourceId { get; set; }
        public string LineSourceType { get; set; }
    }
}
