using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class IndentSchedule
    {
        public string IndentScheduleId { get; set; }
        public string IndentDetailId { get; set; }
        public DateTime? ScheduleDt { get; set; }
        public decimal? ReqQty { get; set; }
        public decimal? Poqty { get; set; }
        public string Comment { get; set; }
        public string IndentScheduleStatus { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
