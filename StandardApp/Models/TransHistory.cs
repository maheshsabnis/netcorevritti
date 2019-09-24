using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransHistory
    {
        public string TransHistoryId { get; set; }
        public string FinYearId { get; set; }
        public string TransCode { get; set; }
        public DateTime? TransDt { get; set; }
        public string PlantMasterId { get; set; }
        public string ItemMasterId { get; set; }
        public string OrderId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Sqty { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? Fifo { get; set; }
        public string LocStat { get; set; }
        public string TransKey { get; set; }
        public decimal? TransRate { get; set; }
        public decimal? TransAmt { get; set; }
        public decimal? PrevStock { get; set; }
        public decimal? NewStock { get; set; }
        public decimal? PrevVal { get; set; }
        public decimal? NewVal { get; set; }
        public string Ref { get; set; }
        public string Reason { get; set; }
        public string DeptMasterId { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? NewLocImpQty { get; set; }
        public decimal? NewWarehouseQty { get; set; }
        public decimal? NewSupplierQty { get; set; }
        public decimal? NewLocationVal { get; set; }
        public decimal? NewWarehouseVal { get; set; }
        public decimal? NewSupplierVal { get; set; }
        public decimal? NewLocImpVal { get; set; }
        public decimal? NewLocationQty { get; set; }
    }
}
