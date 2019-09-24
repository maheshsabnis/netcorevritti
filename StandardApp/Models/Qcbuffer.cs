using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Qcbuffer
    {
        public string GrnpacketListId { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public string PacketStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string DeviceId { get; set; }
    }
}
