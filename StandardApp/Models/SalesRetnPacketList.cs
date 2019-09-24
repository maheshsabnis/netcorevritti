using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesRetnPacketList
    {
        public string SalesRtnPacketListId { get; set; }
        public string SalesRtnHeaderId { get; set; }
        public string SalesRtnDetailId { get; set; }
        public string PacketSrNo { get; set; }
        public string PacketMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public string PacketNo { get; set; }
        public string LocationMasterId { get; set; }
        public string PacketStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PostStatus { get; set; }
        public string IsDeleted { get; set; }
    }
}
