using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class GinpacketList
    {
        public string GinpacketListId { get; set; }
        public string GininvHdrId { get; set; }
        public string GininvDtlId { get; set; }
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
        public DateTime? Qcdate { get; set; }
    }
}
