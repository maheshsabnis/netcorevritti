using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VersionMaster
    {
        public string VersionMasterId { get; set; }
        public string ItemPlantId { get; set; }
        public string Version { get; set; }
        public string Features { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
