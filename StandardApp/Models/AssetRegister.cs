using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AssetRegister
    {
        public string AssetRegisterId { get; set; }
        public string AssetNo { get; set; }
        public string AssetGroup { get; set; }
        public string PlantMasterId { get; set; }
        public string ItemMasterId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public string LotNo { get; set; }
        public decimal? LotQty { get; set; }
        public string AssetAccNo { get; set; }
        public string LocationMasterId { get; set; }
        public string LocationCode { get; set; }
        public string LocationDesc { get; set; }
        public string WarehouseMasterId { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDesc { get; set; }
        public string SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string ErprefNo { get; set; }
        public string IsCapitalized { get; set; }
        public DateTime? CapitalizationDate { get; set; }
        public string Remarks { get; set; }
        public DateTime? AsOfDate { get; set; }
        public string InvoiceNo { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
