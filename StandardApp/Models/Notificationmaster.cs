using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Notificationmaster
    {
        public int Notificationid { get; set; }
        public string Notificationdesc { get; set; }
        public string Vendorid { get; set; }
        public string Customermasterid { get; set; }
        public string Vendordeviceid { get; set; }
        public string Custdeviceid { get; set; }
        public DateTime? Addeddt { get; set; }
        public string FlagV { get; set; }
        public string FlagC { get; set; }
    }
}
