using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DevicemasterHistory
    {
        public string PkDeviceMasterHistory { get; set; }
        public string ApplicationName { get; set; }
        public string UserMasterId { get; set; }
        public string DeviceId { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsInstalled { get; set; }
    }
}
