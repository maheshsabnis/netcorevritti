using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserSetUp
    {
        public string UserSetUpId { get; set; }
        public string UserMasterId { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public DateTime? TimeIncrement { get; set; }
        public string LunchTime { get; set; }
        public string TeaTime { get; set; }
        public DateTime? LunchTimeFrom { get; set; }
        public DateTime? LunchTimeTo { get; set; }
        public DateTime? TeaTimeFrom { get; set; }
        public DateTime? TeaTimeTo { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? AllowEditingDays { get; set; }
    }
}
