using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrsheader
    {
        public string MrsheaderId { get; set; }
        public string Mrsno { get; set; }
        public DateTime? Mrsdate { get; set; }
        public string DeptMasterId { get; set; }
        public string StatusId { get; set; }
        public string RequisitionerId { get; set; }
        public string ApproverId { get; set; }
        public string Purpose { get; set; }
        public string Remark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string Mrstype { get; set; }
        public string SourceId { get; set; }
        public string RouteName { get; set; }
        public string SegmentType { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public string Address { get; set; }
    }
}
