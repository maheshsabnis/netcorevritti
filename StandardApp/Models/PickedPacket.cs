using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PickedPacket
    {
        public string PickedPacketId { get; set; }
        public string PickedLotId { get; set; }
        public string PacketMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? PickPacketQty { get; set; }
        public string PacketNo { get; set; }
        public string PacketSrNo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
