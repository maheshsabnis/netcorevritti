using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MachineMaster
    {
        public string MachineMasterId { get; set; }
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public string MachineGroupId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? IsAvailable { get; set; }
        public string IsDeleted { get; set; }
    }
}
