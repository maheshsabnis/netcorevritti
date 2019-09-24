using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TimeSlot
    {
        public string TimeSlotId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}
