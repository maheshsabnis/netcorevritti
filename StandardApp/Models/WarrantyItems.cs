using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WarrantyItems
    {
        public string PkwarrantyItemId { get; set; }
        public string WarrantyRegisterId { get; set; }
        public string ItemMasterId { get; set; }
        public string ItemDesc { get; set; }
        public string ItemQty { get; set; }
        public decimal? ItemRate { get; set; }
        public string SerialNo { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public string SalesDtlId { get; set; }
    }
}
