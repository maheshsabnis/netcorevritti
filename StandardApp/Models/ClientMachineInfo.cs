using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ClientMachineInfo
    {
        public string Id { get; set; }
        public string Nipaddress { get; set; }
        public string MachineName { get; set; }
        public string UserMasterId { get; set; }
        public DateTime AddedDt { get; set; }
    }
}
