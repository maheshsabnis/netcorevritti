using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransSettlementLines
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransSettlementLinesId { get; set; }
        public string FinDivId { get; set; }
        public string SttlmntLineNo { get; set; }
        public DateTime? SttlmntDate { get; set; }
        public decimal? SttlmntValFc { get; set; }
        public decimal? SttlmntVal { get; set; }
        public string LineNarrative { get; set; }
        public string LedgerId { get; set; }
        public string PartyId { get; set; }
        public string SttlmntLineTranNo { get; set; }
        public string SttlmntMethodId { get; set; }
        public string SttlmntTermsId { get; set; }
        public string SttlmntDiscBase { get; set; }
        public DateTime? DueDate { get; set; }
        public string SttlmntStatus { get; set; }
        public string CurrContractId { get; set; }
        public decimal? SttlmntBalOs { get; set; }
        public string LineSettled { get; set; }
        public string PersonalLgrLineStatus { get; set; }
        public DateTime? DateSettled { get; set; }
        public DateTime? StlLineDateOfDoc { get; set; }
        public string PaymentListFinDivId { get; set; }
        public string PaymentListId { get; set; }
        public string PaymentListLineNo { get; set; }
        public string Reason { get; set; }
        public string SttlmntLineSource { get; set; }
        public string NarrativeId { get; set; }
        public string PrevNoteLetters { get; set; }
        public decimal? InstallIntAmt { get; set; }
        public decimal? InstallPrincipalAmt { get; set; }
        public string NoteListFinDivId { get; set; }
        public string NoteListId { get; set; }
        public string NoteListLineNo { get; set; }
        public string NoteTransNo { get; set; }
        public string NoteMethodId { get; set; }
        public string LetterTypeId { get; set; }
        public string LetterListId { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? SttlmntBalOsfc { get; set; }
        public decimal? InstallIntAmtFc { get; set; }
        public decimal? InstallPrincipalAmtFc { get; set; }
        public decimal? SttlmntValGross { get; set; }
    }
}
