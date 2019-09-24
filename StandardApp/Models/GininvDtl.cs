﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class GininvDtl
    {
        public string GininvDtlId { get; set; }
        public string GininvHdrId { get; set; }
        public string SupplierId { get; set; }
        public string PartyDcno { get; set; }
        public DateTime? PartyDcdt { get; set; }
        public string PlantMasterId { get; set; }
        public string PoscheduleId { get; set; }
        public string Pono { get; set; }
        public DateTime? Podate { get; set; }
        public string ShipToMasterId { get; set; }
        public string BillNo { get; set; }
        public string BillToId { get; set; }
        public decimal? Poamt { get; set; }
        public decimal? PotaxAmt { get; set; }
        public decimal? Pocharges { get; set; }
        public decimal? PototalAmt { get; set; }
        public string ItemMasterId { get; set; }
        public string MaterialId { get; set; }
        public string ReturnAs { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public decimal? ChallanQty { get; set; }
        public decimal? Ginqty { get; set; }
        public decimal? RejQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? AccQty { get; set; }
        public decimal? RetQty { get; set; }
        public decimal? Qcqty { get; set; }
        public decimal? Ginrate { get; set; }
        public string PurUomid { get; set; }
        public string StkUomid { get; set; }
        public decimal? ConvFactor { get; set; }
        public decimal? StkGinqty { get; set; }
        public decimal? StkRejQty { get; set; }
        public decimal? StkScrapQty { get; set; }
        public decimal? StkAccQty { get; set; }
        public decimal? StkRetQty { get; set; }
        public bool? InspOnRect { get; set; }
        public string AccTypeId { get; set; }
        public string AptransNo { get; set; }
        public string AptransLineNo { get; set; }
        public string Ref { get; set; }
        public string LotNo { get; set; }
        public string VendorLotNo { get; set; }
        public DateTime? Rfifo { get; set; }
        public string DeptMasterId { get; set; }
        public string DeliveryMode { get; set; }
        public string Remark { get; set; }
        public string GinlineStatus { get; set; }
        public string Ct3no { get; set; }
        public string Pcno { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? ExchRate { get; set; }
        public decimal? LandedRate { get; set; }
        public decimal? RejQtyAtQc { get; set; }
        public decimal? Rmdaqty { get; set; }
        public decimal? Mrnqty { get; set; }
        public decimal? ShortQty { get; set; }
        public bool? IsStackable { get; set; }
        public bool? IsIndentReqd { get; set; }
        public string RejReasonId { get; set; }
        public decimal? ExcessQty { get; set; }
        public decimal? UnitRateSentMtrl { get; set; }
        public decimal? UnitRatePocharges { get; set; }
        public decimal? UnitRateTax { get; set; }
        public decimal? UnitRateOtherCaharges { get; set; }
        public decimal? UnitRatePo { get; set; }
        public string RefRecType { get; set; }
        public string RefRecId { get; set; }
        public string RecType { get; set; }
        public string OctroiCh { get; set; }
        public DateTime? ExciseDt { get; set; }
        public decimal? BasicAmount { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? ChargeAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Porate { get; set; }
        public decimal? UnitPackingCharges { get; set; }
        public decimal? UnitFreightCharges { get; set; }
        public decimal? UnitInsuranceBankingCharges { get; set; }
        public decimal? UnitPocharges { get; set; }
        public decimal? UnitGrncharges { get; set; }
        public decimal? UnitOtherCharges { get; set; }
        public decimal? NoOfPacket { get; set; }
        public string IsPacketAppl { get; set; }
        public string SaleRetnHdrId { get; set; }
        public decimal? BalanceQty { get; set; }
        public string SaleRetnDtlId { get; set; }
    }
}