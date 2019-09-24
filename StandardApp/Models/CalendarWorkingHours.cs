using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CalendarWorkingHours
    {
        public string WorkingHoursId { get; set; }
        public string CalendarId { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
    }
}
