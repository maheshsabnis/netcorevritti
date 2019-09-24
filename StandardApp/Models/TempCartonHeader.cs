using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TempCartonHeader
    {
        public string TempCartonHeaderId { get; set; }
        public string PlantMasterId { get; set; }
        public string PacketCode { get; set; }
        public string PacketDesc { get; set; }
        public decimal? PacketQty { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ItemQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
    }
}
