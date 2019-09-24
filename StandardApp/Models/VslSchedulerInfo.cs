using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslSchedulerInfo
    {
        public string SchedulerId { get; set; }
        public string ScheduleNo { get; set; }
        public string SchedulerTypeId { get; set; }
        public string ScheduleDesc { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public string ScheduleXmlinfo { get; set; }
        public string SourceId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SyncInfo { get; set; }
        public DateTime? SchEndDate { get; set; }
    }
}
