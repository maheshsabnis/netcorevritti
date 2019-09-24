using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmFeedBackCallList
    {
        public string FeedBackCallId { get; set; }
        public string ProspectId { get; set; }
        public DateTime? CallStart { get; set; }
        public string Source { get; set; }
        public string SouceId { get; set; }
        public string Seid { get; set; }
        public string BackOfficeExecutiveId { get; set; }
        public string CurrentCallOwner { get; set; }
        public string LatestRemark { get; set; }
        public string NextAction { get; set; }
        public DateTime? NextActionDateTime { get; set; }
        public string Isclose { get; set; }
        public int CallType { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string OutcomeCode { get; set; }
        public string CallRescheduleReason { get; set; }
        public string CallTransferReasonCode { get; set; }
        public string CallAgainReasonCode { get; set; }
        public string ContactId { get; set; }
        public long? EmailCount { get; set; }
        public long? VisitCount { get; set; }
        public long? TeleCount { get; set; }
        public string Campaign { get; set; }
        public string TotalHoursSpent { get; set; }
        public int? Calllife { get; set; }
        public string CallCloseReason { get; set; }
        public string CallCloseDetails { get; set; }
        public string FkFamilyId { get; set; }
        public string FkCssFormsId { get; set; }
        public DateTime FeedbackCompletedDateTime { get; set; }
        public int RescheduleCount { get; set; }
        public string FkplantId { get; set; }
    }
}
