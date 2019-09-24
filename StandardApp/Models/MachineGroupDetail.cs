using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MachineGroupDetail
    {
        public string MachineGroupDetailId { get; set; }
        public string MachineGroupMasterId { get; set; }
        public string MachineNo { get; set; }
        public string MachineName { get; set; }
        public string LocationId { get; set; }
        public string CalendorId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Make { get; set; }
        public string ManufacturerSrNo { get; set; }
        public string Needle { get; set; }
        public string Flatknit { get; set; }
        public string Terry { get; set; }
        public string SelectTerry { get; set; }
        public decimal? MaxHrPerDay { get; set; }
        public string IsActive { get; set; }
        public string AssetNo { get; set; }
        public decimal? Year { get; set; }
    }
}
