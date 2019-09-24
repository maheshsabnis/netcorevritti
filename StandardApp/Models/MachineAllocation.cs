using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MachineAllocation
    {
        public string MachineAllocId { get; set; }
        public string PlantMasterId { get; set; }
        public string MachineMasterId { get; set; }
        public string MoheaderId { get; set; }
        public string MoroutingId { get; set; }
        public string OperationMasterId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Moqty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
