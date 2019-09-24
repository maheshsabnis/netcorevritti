using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class StandardCalendarOptions
    {
        public string CalendarOptionId { get; set; }
        public string CalendarId { get; set; }
        public string WeekStartsOn { get; set; }
        public string FiscalYearStartsIn { get; set; }
        public DateTime? DefaultStartTime { get; set; }
        public DateTime? DefaultEndTime { get; set; }
        public int? HoursPerDay { get; set; }
        public int? HoursPerWeek { get; set; }
        public int? DaysPerMonth { get; set; }
    }
}
