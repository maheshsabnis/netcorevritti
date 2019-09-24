using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class RouteMaster
    {
        public string RouteMasterId { get; set; }
        public string RouteCode { get; set; }
        public string RouteName { get; set; }
        public DateTime? AddedDt { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string PlantId { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string UserLevel { get; set; }
        public string CreationLevel { get; set; }
    }
}
