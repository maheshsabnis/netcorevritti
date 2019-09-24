using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PccardDetail
    {
        public string PccardDetailId { get; set; }
        public string PccardMasterId { get; set; }
        public string WiplocationMasterId { get; set; }
        public string MoroutingId { get; set; }
        public decimal? ProdQty { get; set; }
        public decimal? RejQty { get; set; }
        public decimal? ReworkQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string MoveToSegregation { get; set; }
        public string OperationId { get; set; }
        public decimal? Wt1 { get; set; }
        public decimal? Wt2 { get; set; }
        public decimal? TransferQty { get; set; }
        public string MachineMasterId { get; set; }
    }
}
