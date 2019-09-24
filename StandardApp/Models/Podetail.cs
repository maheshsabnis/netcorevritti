using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Podetail
    {
        public string PodetailId { get; set; }
        public string PoheaderId { get; set; }
        public string IndentDetailId { get; set; }
        public decimal? SrNo { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? Qty { get; set; }
        public string UommasterId { get; set; }
        public DateTime? ReqDt { get; set; }
        public decimal? Frate { get; set; }
        public decimal? Porate { get; set; }
        public decimal? DiscPc { get; set; }
        public decimal? LineAmt { get; set; }
        public decimal? FlineAmt { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? LineTaxes { get; set; }
        public decimal? FlineTaxes { get; set; }
        public decimal? LineCharges { get; set; }
        public decimal? FlineCharges { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? FlineTotal { get; set; }
        public decimal? QtyReceived { get; set; }
        public string PolineStatus { get; set; }
        public string AccountNo { get; set; }
        public string ExtDesc1 { get; set; }
        public string ExtDesc2 { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LabourChargeId { get; set; }
        public decimal? LineFreightCharges { get; set; }
        public decimal? LinePackingCharges { get; set; }
        public decimal? LineInsuranceBankingCharges { get; set; }
        public decimal? LinePocharges { get; set; }
        public decimal? LinePackagingCharges { get; set; }
        public string Remark { get; set; }
        public string SorefId { get; set; }
        public bool? IsfixedDiscnt { get; set; }
        public decimal? DiscntAmt { get; set; }
        public decimal? DiscnRate { get; set; }
        public string NoCartShipper { get; set; }
        public string VendorContractHeaderId { get; set; }
    }
}
