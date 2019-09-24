using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EventMaster
    {
        public string EventId { get; set; }
        public string EventType { get; set; }
        public bool? IsReminderSet { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
