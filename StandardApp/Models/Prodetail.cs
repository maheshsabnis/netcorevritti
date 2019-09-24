using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Prodetail
    {
        public string ProdetailId { get; set; }
        public string ProheaderId { get; set; }
        public string IndentDetailId { get; set; }
        public string ReqNo { get; set; }
        public string SrNo { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? Qty { get; set; }
        public string UommasterId { get; set; }
        public DateTime? ReqDt { get; set; }
        public decimal? Frate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? DiscPc { get; set; }
        public decimal? LineAmt { get; set; }
        public decimal? FlineAmt { get; set; }
        public decimal? TaxClassMasterId { get; set; }
        public decimal? LineTaxes { get; set; }
        public decimal? FlineTaxes { get; set; }
        public decimal? LineCharges { get; set; }
        public decimal? FlineCharges { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? FlineTotal { get; set; }
        public decimal? QtyRec { get; set; }
        public string ExtDesc1 { get; set; }
        public string ExtDesc2 { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDt { get; set; }
    }
}
