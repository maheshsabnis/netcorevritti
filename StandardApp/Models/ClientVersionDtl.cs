using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ClientVersionDtl
    {
        public string ClientVersionDtlId { get; set; }
        public string ItemPlantId { get; set; }
        public string VersionMasterId { get; set; }
        public string ShipToMasterId { get; set; }
        public string ActivityId { get; set; }
        public DateTime? InstallDt { get; set; }
        public string InstallerId { get; set; }
        public string Notes { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
