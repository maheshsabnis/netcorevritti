using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PktOpStkDetail
    {
        public string PktOpStkDetailId { get; set; }
        public string PktOpStkHeaderId { get; set; }
        public string PacketSrNo { get; set; }
        public string PacketNo { get; set; }
        public decimal? PacketQty { get; set; }
        public string StatusId { get; set; }
        public string LocationMasterId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
