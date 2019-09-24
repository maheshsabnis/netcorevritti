using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VehicleTypeMaster
    {
        public string VehicleTypeMasterId { get; set; }
        public string VehicleType { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
