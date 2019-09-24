using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class RouteMaster1
    {
        public string PkrouteMasterId { get; set; }
        public string SequenceNo { get; set; }
        public string ItemPlantId { get; set; }
        public string RouteCode { get; set; }
        public string RouteDesc { get; set; }
        public string PlantId { get; set; }
        public string PlantName { get; set; }
        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public string Area { get; set; }
        public string Point { get; set; }
        public string SegmentType { get; set; }
        public string ConnectionPoint { get; set; }
        public string Length { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string TotalCore { get; set; }
        public string UtilizeCore { get; set; }
        public string IsDeleted { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
