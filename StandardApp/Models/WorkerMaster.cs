using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WorkerMaster
    {
        public string WorkerMasterId { get; set; }
        public string WorkerCode { get; set; }
        public string WorkerName { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
