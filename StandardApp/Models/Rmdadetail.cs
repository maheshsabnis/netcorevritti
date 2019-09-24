using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rmdadetail
    {
        public string RmdadetailId { get; set; }
        public string RmdaheaderId { get; set; }
        public string StockDetailsId { get; set; }
        public string ItemMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string SupplierId { get; set; }
        public string PoscheduleId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string BatchNo { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitRate { get; set; }
        public decimal? Amount { get; set; }
        public string Reason { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string RefRecId { get; set; }
        public string RefRecType { get; set; }
        public string StatusId { get; set; }
        public decimal? ShortQty { get; set; }
    }
}
