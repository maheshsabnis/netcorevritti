using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MachineDownTimeDetail
    {
        public string MachineDownTimeId { get; set; }
        public string ShiftId { get; set; }
        public string MachineMasterId { get; set; }
        public string McnDwnRsnMasterId { get; set; }
        public string DwnTimeFrom { get; set; }
        public string DwnTimeTo { get; set; }
        public decimal? TotalDownTime { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
