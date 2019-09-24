using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class RecurActDef
    {
        public string ActivityDefId { get; set; }
        public string ActivityDesc { get; set; }
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
        public string IsHoliday { get; set; }
        public string IsWeeklyOff { get; set; }
    }
}
