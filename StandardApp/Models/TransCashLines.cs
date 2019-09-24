using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransCashLines
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransCashLinesId { get; set; }
        public string FinDivId { get; set; }
        public string CashLineNo { get; set; }
        public decimal? LineVal { get; set; }
        public decimal? CashBookVal { get; set; }
        public decimal? CashBookValFc { get; set; }
        public string RateAdviceExp { get; set; }
        public string ChqNo { get; set; }
        public DateTime? CheqDate { get; set; }
        public string BankRemittanceNo { get; set; }
        public string LodgeDepositNo { get; set; }
        public string CashLineNarrative { get; set; }
        public string BankChargesAppli { get; set; }
        public string AdjType { get; set; }
        public string LedgerId { get; set; }
        public string LineSttlmntMethod { get; set; }
        public string RecoRef { get; set; }
        public string RecoNarrative { get; set; }
        public string LineStatus { get; set; }
        public string LineSource { get; set; }
        public string LineUnit { get; set; }
        public string LineAccId { get; set; }
        public string LineAccType { get; set; }
        public string LineAccPeriod { get; set; }
        public string BankTransType { get; set; }
        public string InTransitStatus { get; set; }
        public string NarrativeId { get; set; }
        public string FwdCvrMstId { get; set; }
        public decimal? ExchangeRt { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? RecoDate { get; set; }
        public string RecoStatus { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? AllocValFc { get; set; }
        public decimal? AllocVal { get; set; }
        public string TransModesId { get; set; }
    }
}
