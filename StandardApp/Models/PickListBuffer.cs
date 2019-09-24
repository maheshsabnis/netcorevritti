using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PickListBuffer
    {
        public string PacketMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string PickListType { get; set; }
        public string PickListId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? PickQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string DeviceId { get; set; }
    }
}
