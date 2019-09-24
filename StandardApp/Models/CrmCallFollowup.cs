using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCallFollowup
    {
        public string CallFollowupId { get; set; }
        public string ActionType { get; set; }
        public string FollowupComment { get; set; }
        public string CallStatusOld { get; set; }
        public string CallStatusNew { get; set; }
        public string FollowupById { get; set; }
        public DateTime? FollowupDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TimeSpent { get; set; }
        public string CallHistoryId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PurpoesId { get; set; }
        public string ExpectedCloserDate { get; set; }
        public string Reason { get; set; }
        public string Review { get; set; }
        public string ContactId { get; set; }
        public string CallId { get; set; }
        public bool? StatusFlag { get; set; }
        public int StartCount { get; set; }
        public int InitiatedBy { get; set; }
    }
}
