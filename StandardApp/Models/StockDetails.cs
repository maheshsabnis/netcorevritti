using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class StockDetails
    {
        public string StockDetailsId { get; set; }
        public string FinYearId { get; set; }
        public string ItemMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string BatchNo { get; set; }
        public string BarCodeSrNo { get; set; }
        public DateTime? Fifo { get; set; }
        public string LocStat { get; set; }
        public string OrderId { get; set; }
        public string Ref { get; set; }
        public decimal? RecdQty { get; set; }
        public decimal? MovedQty { get; set; }
        public decimal? BalQty { get; set; }
        public decimal? RecdVal { get; set; }
        public decimal? MovedVal { get; set; }
        public decimal? BalVal { get; set; }
        public decimal? SrecdQty { get; set; }
        public decimal? SmovedQty { get; set; }
        public decimal? SbalQty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? SApprovedQty { get; set; }
        public decimal? ApprovedQty { get; set; }
        public decimal? ApprovedVal { get; set; }
        public decimal? UnitRate { get; set; }
        public string SupplierId { get; set; }
        public string LocalImport { get; set; }
        public string RefDocId { get; set; }
        public string RefDocType { get; set; }
        public decimal? FgtransferQty { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public string Qcstatus { get; set; }
        public decimal? UnPostedQty { get; set; }
    }
}
