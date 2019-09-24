using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BankMaster
    {
        public decimal RecId { get; set; }
        public string FinDivId { get; set; }
        public string BankMasterId { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string AccountMasterId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal? Pin { get; set; }
        public string Branch { get; set; }
        public string ContactNo { get; set; }
        public string ContactPerson { get; set; }
        public string ChequeBookPrintProgram { get; set; }
        public decimal? MinBal { get; set; }
        public decimal? MaxBal { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsBank { get; set; }
        public decimal? StrtRw { get; set; }
        public decimal? ChkNoColumn { get; set; }
        public decimal? ChkClrDtColumn { get; set; }
        public string RemarkColumn { get; set; }
        public string BnkAccountNo { get; set; }
        public string StartLine { get; set; }
        public string InstrumentColumn { get; set; }
        public string TransactionType { get; set; }
        public string DebitNo { get; set; }
        public string CreditNo { get; set; }
        public string CtDtNo { get; set; }
        public string DateColumn1 { get; set; }
        public string DateColumn2 { get; set; }
        public string Balance { get; set; }
        public string DateFormat { get; set; }
        public string InterestRate { get; set; }
        public string EndLine { get; set; }
        public string Narration { get; set; }
        public string Ifsccode { get; set; }
        public string AccountName { get; set; }
        public string RecordOrder { get; set; }
    }
}
