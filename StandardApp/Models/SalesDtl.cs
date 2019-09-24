using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesDtl
    {
        public string SalesDtlId { get; set; }
        public string SalesHeaderId { get; set; }
        public string SoScheduleId { get; set; }
        public string OrderNo { get; set; }
        public decimal? SrNo { get; set; }
        public decimal? CustomerId { get; set; }
        public DateTime? CommittedDt { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? SalesQty { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? TaxClassMasterId { get; set; }
        public decimal? LineAmt { get; set; }
        public decimal? DiscPc { get; set; }
        public decimal? DiscAmt { get; set; }
        public string BatchNo { get; set; }
        public string LocStat { get; set; }
        public string LocationMasterId { get; set; }
        public decimal? AvgRate { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string WarehouseMasterId { get; set; }
        public bool? Status { get; set; }
        public decimal? ChargeAmnt { get; set; }
        public decimal? BasicTaxAmnt { get; set; }
        public decimal? ChargeTaxAmnt { get; set; }
        public decimal? TotalTaxAmnt { get; set; }
        public decimal? TotalGrossAmnt { get; set; }
        public decimal? TotalAmnt { get; set; }
        public decimal? ProformaQty { get; set; }
        public decimal? DiscAmntFc { get; set; }
        public decimal? ChargeAmntFc { get; set; }
        public decimal? BasicTaxAmntFc { get; set; }
        public decimal? ChargeTaxAmntFc { get; set; }
        public decimal? TotalTaxAmntFc { get; set; }
        public decimal? TotalGrossAmntFc { get; set; }
        public string MarksNo { get; set; }
        public string ContDimensn { get; set; }
        public string ContGrossWt { get; set; }
        public string ContNetWt { get; set; }
        public string NoKindPkgs { get; set; }
        public string BoxNo { get; set; }
        public decimal? FlineAmt { get; set; }
        public decimal? FlineTaxes { get; set; }
        public decimal? FlineTotal { get; set; }
        public string BoxDtlId { get; set; }
        public string LicenseNo { get; set; }
        public string Remark { get; set; }
        public string ExemptMaterialAndNetWt { get; set; }
        public decimal? QtyPerCont { get; set; }
        public decimal? NoofCont { get; set; }
        public string ActivityId { get; set; }
    }
}
