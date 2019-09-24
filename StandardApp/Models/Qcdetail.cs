using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Qcdetail
    {
        public string QcdetailId { get; set; }
        public string QcheaderId { get; set; }
        public string GrndetailId { get; set; }
        public string ChallonNo { get; set; }
        public DateTime? ChallonDt { get; set; }
        public decimal? Grnqty { get; set; }
        public decimal? AcceptedQty { get; set; }
        public decimal? RejectedQty { get; set; }
        public string QcreasonId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string LotNo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? GoodExpiryDate { get; set; }
        public string ExpiryDate { get; set; }
        public string Remark { get; set; }
        public string ReasonOfRejection { get; set; }
        public string RejectedLoc { get; set; }
    }
}
