using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Modetail
    {
        public string ModetailId { get; set; }
        public string MoheaderId { get; set; }
        public string BomheaderId { get; set; }
        public string ComponentMasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? ReqdQty { get; set; }
        public decimal? IssueThisQty { get; set; }
        public decimal? TotalIssue { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? ReturnedQty { get; set; }
        public bool? Backflushing { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ActualCost { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string UommasterId { get; set; }
        public decimal? EquiReceiptQty { get; set; }
        public decimal? StockBal { get; set; }
        public string ModetailStatus { get; set; }
        public decimal? RecQty { get; set; }
        public decimal? DispatchQty { get; set; }
        public decimal? TotalAllocQty { get; set; }
        public decimal? BomhqtyPer { get; set; }
        public decimal? BomdqtyPer { get; set; }
        public decimal? PendingReqmntQty { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string UsedAtOperationSeq { get; set; }
    }
}
