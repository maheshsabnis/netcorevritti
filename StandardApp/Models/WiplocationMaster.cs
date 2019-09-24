using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WiplocationMaster
    {
        public string WiplocationMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
