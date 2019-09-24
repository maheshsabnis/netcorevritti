using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DeviceMaster
    {
        public string PkDeviceMaster { get; set; }
        public string ApplicationName { get; set; }
        public string UserMasterId { get; set; }
        public string DeviceId { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
