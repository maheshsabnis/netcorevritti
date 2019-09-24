using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqmInstructionMaster
    {
        public string BqmInstructionMasterId { get; set; }
        public string InstructionName { get; set; }
        public string InstructionDetails { get; set; }
        public string IsDefault { get; set; }
        public string Remarks { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string OrderTypeMasterId { get; set; }
    }
}
