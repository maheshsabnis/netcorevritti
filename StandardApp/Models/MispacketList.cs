using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MispacketList
    {
        public string MispacketListId { get; set; }
        public string MisheaderId { get; set; }
        public string MisdetailId { get; set; }
        public string PacketMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? IssueQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string PacketNo { get; set; }
        public string PacketSrNo { get; set; }
        public string StatusId { get; set; }
    }
}
