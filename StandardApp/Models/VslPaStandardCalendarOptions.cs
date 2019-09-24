using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslPaStandardCalendarOptions
    {
        public string CalendarOptionId { get; set; }
        public string CalendarId { get; set; }
        public string WeekStartsOn { get; set; }
        public string FiscalYearStartsIn { get; set; }
        public DateTime? DefaultStartTime { get; set; }
        public DateTime? DefaultEndTime { get; set; }
        public string HoursPerDay { get; set; }
        public string HoursPerWeek { get; set; }
        public string DaysPerMonth { get; set; }
        public string ClientId { get; set; }
    }
}
