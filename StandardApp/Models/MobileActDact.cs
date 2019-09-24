using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MobileActDact
    {
        public decimal Srno { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string MobileNo { get; set; }
        public decimal? MobileAct { get; set; }
        public decimal? CountInstall { get; set; }
        public decimal? CountUninstall { get; set; }
        public string DeviceId { get; set; }
    }
}
