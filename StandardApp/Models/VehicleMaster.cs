using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VehicleMaster
    {
        public string VehicleMasterId { get; set; }
        public string TransporterCodeId { get; set; }
        public string VehicleNumber { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string TransporterCode { get; set; }
        public string VehicleType { get; set; }
        public string VehicleInTime { get; set; }
        public string VehicleOutTime { get; set; }
        public string DockInTime { get; set; }
        public string DockOutTime { get; set; }
        public decimal? VehicleVolume { get; set; }
    }
}
