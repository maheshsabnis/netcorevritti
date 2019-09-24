using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCollectionCallList
    {
        public string CollectionCallId { get; set; }
        public string ProspectId { get; set; }
        public DateTime? CallStart { get; set; }
        public string Source { get; set; }
        public string SouceId { get; set; }
        public string Seid { get; set; }
        public string CallStatus { get; set; }
        public string CurrentCallOwner { get; set; }
        public string LatestRemark { get; set; }
        public string NextAction { get; set; }
        public DateTime? NextActionDateTime { get; set; }
        public string ProductId { get; set; }
        public string Isclose { get; set; }
        public int CallType { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string OutcomeCode { get; set; }
        public string CollectMode { get; set; }
        public string InstrNo { get; set; }
        public DateTime? Instrdate { get; set; }
        public string BankName { get; set; }
        public decimal? Amount { get; set; }
        public string PresalesSupportRequired { get; set; }
        public string PresalesExecutiveId { get; set; }
        public string PresalesSupportDetails { get; set; }
        public DateTime? PresalesSupportDueDate { get; set; }
        public string CallRescheduleReason { get; set; }
        public string CallTransferReasonCode { get; set; }
        public string ContactId { get; set; }
        public long? EmailCount { get; set; }
        public long? VisitCount { get; set; }
        public long? TeleCount { get; set; }
        public string Campaign { get; set; }
        public string TotalHoursSpent { get; set; }
        public int? Calllife { get; set; }
        public int? RescheduleCount { get; set; }
        public string InvoiceNo { get; set; }
        public string FkplantId { get; set; }
        public string DisputeReason { get; set; }
        public string BranchName { get; set; }
        public decimal? Tdsamount { get; set; }
        public decimal? DifferenceAmount { get; set; }
        public string DifferenceReason { get; set; }
        public DateTime? PromiseDate { get; set; }
        public int? PromiseChangeCount { get; set; }
        public string PromiseChangeReason { get; set; }
        public string IsBalTds { get; set; }
    }
}
