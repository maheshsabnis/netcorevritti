using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProRatingInfo
    {
        public string ProRatingId { get; set; }
        public DateTime? Date { get; set; }
        public string DailyTimesheetPoints { get; set; }
        public string TimesheetEnteredPoints { get; set; }
        public string MeetingInvitedPoints { get; set; }
        public string MeetingInvitationAcceptedPoints { get; set; }
        public string MompreparedPoints { get; set; }
        public string ActivityTrailEnteredPoints { get; set; }
        public string LeaveAppliedPoints { get; set; }
        public string LeaveApprovedRejectedPoints { get; set; }
        public string ClaimEnteredWithin1DayPoints { get; set; }
        public string ClaimEnteredWithin3DaysPoints { get; set; }
        public string ClaimEnteredPoints { get; set; }
        public string UserMasterId { get; set; }
        public string TotalPoints { get; set; }
        public string UserLoginId { get; set; }
    }
}
