using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EntityContactDeviceMaster
    {
        public string EntityContactDeviceMasterId { get; set; }
        public string ApplicationName { get; set; }
        public string EntityContactInfoId { get; set; }
        public string DeviceId { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
