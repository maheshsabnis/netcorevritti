using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrnheader
    {
        public string MrnheaderId { get; set; }
        public string Mrnno { get; set; }
        public DateTime? Mrndt { get; set; }
        public string DeptMasterId { get; set; }
        public string Remark { get; set; }
        public string StatusId { get; set; }
        public string AuthorisedBy { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string RefDocType { get; set; }
        public string DocType { get; set; }
        public string RouteName { get; set; }
        public string SegmentType { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
    }
}
