using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserWiseWeeklyOff
    {
        public string PkuserWeeklOffId { get; set; }
        public string FkuserId { get; set; }
        public string WeeklyOff { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
