using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OperationMaster
    {
        public string OperationMasterId { get; set; }
        public string OperCode { get; set; }
        public string Operation { get; set; }
        public decimal? StdWtVar { get; set; }
        public string OperType { get; set; }
        public string ReportingReq { get; set; }
        public string DfltLocationId { get; set; }
        public string NxtLocationId { get; set; }
        public string PlantId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string QtyCheck { get; set; }
        public decimal? OffsetDays { get; set; }
        public decimal? UpwardTol { get; set; }
        public decimal? DownwardTol { get; set; }
    }
}
