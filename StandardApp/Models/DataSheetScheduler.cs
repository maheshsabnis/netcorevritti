using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DataSheetScheduler
    {
        public string PkdatasheetSchedulerId { get; set; }
        public string FkformId { get; set; }
        public string AssignToId { get; set; }
        public string ScheduleDescription { get; set; }
        public DateTime? RecStartDate { get; set; }
        public DateTime? RecEndDate { get; set; }
        public decimal? RecurDaysCount { get; set; }
        public decimal? RecurWeeksCount { get; set; }
        public bool? IsSunday { get; set; }
        public bool? IsMonday { get; set; }
        public bool? IsTuesday { get; set; }
        public bool? IsWednesday { get; set; }
        public bool? IsThursday { get; set; }
        public bool? IsFriday { get; set; }
        public bool? IsSaturday { get; set; }
        public decimal? EveryMonthCount { get; set; }
        public decimal? MonthlyDayNo { get; set; }
        public decimal? MonthlyMonth { get; set; }
        public string MonthlyWeek { get; set; }
        public string MonthlyDay { get; set; }
        public decimal? RecurYearCount { get; set; }
        public string YearlyMonthName { get; set; }
        public string YearlyWeek { get; set; }
        public string YearlyDay { get; set; }
        public string YearlyMonth { get; set; }
        public string TypeOfPeriod { get; set; }
        public decimal? Occurrences { get; set; }
        public string IsNoEndDate { get; set; }
        public DateTime? NextScheduleRunDate { get; set; }
        public DateTime? ScheduleDueDate { get; set; }
        public string Workspace { get; set; }
        public string ModuleId { get; set; }
        public string Unit { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? IsActive { get; set; }
        public string AllowDatasheetEntryOn { get; set; }
        public string SaveActivityAction { get; set; }
        public string ItemLevelApproval { get; set; }
        public string Attachment { get; set; }
    }
}
