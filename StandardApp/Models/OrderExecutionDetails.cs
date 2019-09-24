using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OrderExecutionDetails
    {
        public string OrderExecutionId { get; set; }
        public string SoheaderId { get; set; }
        public DateTime? ExecutionDt { get; set; }
        public string ActivityMasterId { get; set; }
        public string Responsible { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public DateTime? DueDt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
