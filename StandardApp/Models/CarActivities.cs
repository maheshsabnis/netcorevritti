using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CarActivities
    {
        public string RecId { get; set; }
        public string MsgHeaderId { get; set; }
        public string ActivityId { get; set; }
        public string Addedby { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
