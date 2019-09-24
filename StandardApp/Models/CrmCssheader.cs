using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCssheader
    {
        public string PkcssHeaderId { get; set; }
        public string FkcustomerId { get; set; }
        public string FkcssFormsId { get; set; }
        public string FkfeedbackById { get; set; }
        public DateTime FeedBackDate { get; set; }
        public string FeedBackStarttime { get; set; }
        public string FeedBackEndtime { get; set; }
        public string TimeSpent { get; set; }
        public decimal? OverallRating { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string FeedBackCallId { get; set; }
        public string Notes { get; set; }
        public decimal TotalRating { get; set; }
        public decimal Percentage { get; set; }
        public string Grade { get; set; }
        public string IsRequestToCustomer { get; set; }
        public string IsRequestSentTo { get; set; }
        public string MailFormatId { get; set; }
        public string IsResponseGiven { get; set; }
        public DateTime LastReminderDate { get; set; }
        public int ReminderSentCount { get; set; }
        public string FkdatasheetSchId { get; set; }
        public string FreqDescriptor { get; set; }
        public string FkactivityId { get; set; }
        public int? Status { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string AllowDatasheetEntryOn { get; set; }
        public string SaveActivityAction { get; set; }
        public string ItemLevelApproval { get; set; }
        public string Attachment { get; set; }
        public string AssignNew { get; set; }
    }
}
