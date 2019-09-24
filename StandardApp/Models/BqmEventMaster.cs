using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqmEventMaster
    {
        public string BqmEventMasterId { get; set; }
        public string EventName { get; set; }
        public string EventTypeMasterId { get; set; }
        public string InstructionMasterId { get; set; }
        public string ContactLines { get; set; }
        public string Remarks { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
