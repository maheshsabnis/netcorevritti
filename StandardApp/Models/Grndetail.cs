using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Grndetail
    {
        public string GrndetailId { get; set; }
        public string GrnheaderId { get; set; }
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
        public decimal? Grnqty { get; set; }
        public decimal? RejQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? AccQty { get; set; }
        public decimal? RetQty { get; set; }
        public decimal? Qcqty { get; set; }
        public decimal? Grnrate { get; set; }
        public string PurUomid { get; set; }
        public string StkUomid { get; set; }
        public decimal? ConvFactor { get; set; }
        public decimal? StkGrnqty { get; set; }
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
        public string GrnlineStatus { get; set; }
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
        public decimal? LineTaxes { get; set; }
        public decimal? LineTotal { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? LineAmt { get; set; }
        public decimal? ChargeAmnt { get; set; }
        public decimal? ChargeTaxAmnt { get; set; }
        public decimal? TotalGrossAmnt { get; set; }
        public decimal? Porate { get; set; }
        public decimal? NoOfPacket { get; set; }
        public decimal? DiscntAmt { get; set; }
        public string AsnheaderId { get; set; }
        public string RefId { get; set; }
        public DateTime? GoodExpiryDate { get; set; }
        public string ExpiryDate { get; set; }
        public string IsPacketAppl { get; set; }
        public string BuyerId { get; set; }
        public string OperationMasterId { get; set; }
    }
}
