using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrsdetail
    {
        public string MrsdetailId { get; set; }
        public string MrsheaderId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? ReqQty { get; set; }
        public string UommasterId { get; set; }
        public decimal? IssuedQty { get; set; }
        public string StatusId { get; set; }
        public string Remark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModetailId { get; set; }
        public string SupplierId { get; set; }
        public string RouteName { get; set; }
        public string SegmentType { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public string Address { get; set; }
    }
}
