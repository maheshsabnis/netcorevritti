using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class StkAdjPacket
    {
        public string StkAdjPacketId { get; set; }
        public string StockAdjId { get; set; }
        public string PacketNo { get; set; }
        public string PacketSrNo { get; set; }
        public decimal? PacketQty { get; set; }
        public string StatusId { get; set; }
    }
}
