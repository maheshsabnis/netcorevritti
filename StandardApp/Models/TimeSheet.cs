using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TimeSheet
    {
        public string TimeSheetId { get; set; }
        public string UserMasterId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? WorkDate { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public decimal? Status { get; set; }
        public string Remarks { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string UnitId { get; set; }
        public string ActivityId { get; set; }
        public string TimeSlotId { get; set; }
        public string ProjectId { get; set; }
        public string ActivityTypeId { get; set; }
        public decimal? BookedHours { get; set; }
        public decimal? Rate { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? ReportingStatus { get; set; }
        public decimal? AssignedCount { get; set; }
        public string ActionMasterId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Address { get; set; }
        public string TimeSheetEntryFrmClient { get; set; }
        public string ClaimDetailId { get; set; }
    }
}
