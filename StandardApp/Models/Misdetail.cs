using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Misdetail
    {
        public string MisdetailId { get; set; }
        public string MisheaderId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? ReqQty { get; set; }
        public decimal? StockQty { get; set; }
        public decimal? IssueQty { get; set; }
        public string OrderId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string LotNo { get; set; }
        public string UommasterId { get; set; }
        public string Comment { get; set; }
        public string StatusId { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? AckQty { get; set; }
        public string MostockAllocId { get; set; }
        public string RouteName { get; set; }
        public string SegmentType { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public string Address { get; set; }
    }
}
