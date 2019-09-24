using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PacketMaster
    {
        public string PacketMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string ItemPlantId { get; set; }
        public string PacketSrNo { get; set; }
        public string PacketNo { get; set; }
        public string StockDetailsId { get; set; }
        public decimal? RecvdQty { get; set; }
        public decimal? BalQty { get; set; }
        public decimal? MovedQty { get; set; }
        public string UommasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string RecType { get; set; }
        public string RefRecType { get; set; }
        public string RefRecId { get; set; }
        public string PacketStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
