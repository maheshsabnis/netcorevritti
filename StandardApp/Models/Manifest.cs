using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Manifest
    {
        public string ManifestId { get; set; }
        public string ManifestNo { get; set; }
        public DateTime? ManifestDate { get; set; }
        public string TransporterId { get; set; }
        public string TransporterName { get; set; }
        public string VehicleNo { get; set; }
        public string DriverName { get; set; }
        public string DriverAddress { get; set; }
        public string DriverContactNo { get; set; }
        public DateTime? ManifestCreatedDateTime { get; set; }
        public DateTime? ManifestClosedDateTime { get; set; }
        public string Status { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
