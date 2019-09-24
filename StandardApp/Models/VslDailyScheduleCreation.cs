using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslDailyScheduleCreation
    {
        public string DailyScheduleId { get; set; }
        public string SchedulerId { get; set; }
        public DateTime? NextschTime { get; set; }
        public DateTime? LastSchTime { get; set; }
        public string CurrentStatus { get; set; }
        public string Laststatus { get; set; }
        public string IsDeleted { get; set; }
    }
}
