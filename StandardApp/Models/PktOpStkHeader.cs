using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PktOpStkHeader
    {
        public string PktOpStkHeaderId { get; set; }
        public string PktOpStkNo { get; set; }
        public DateTime? PacketDt { get; set; }
        public string ItemPlantId { get; set; }
        public string PlantMasterId { get; set; }
        public string StockDetailsId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? NoOfPacket { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string LocationMasterId { get; set; }
    }
}
