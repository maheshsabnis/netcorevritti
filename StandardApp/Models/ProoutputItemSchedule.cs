using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProoutputItemSchedule
    {
        public string ProoutputItemScheduleId { get; set; }
        public string ProoutputItemDetailId { get; set; }
        public string WarehouseMasterId { get; set; }
        public DateTime? ScheduleDt { get; set; }
        public decimal? ScheduleQty { get; set; }
        public decimal? QtyReceived { get; set; }
        public string Comment { get; set; }
        public string ScheduleStatus { get; set; }
        public string UommasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
