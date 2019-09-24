using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PropickList
    {
        public string PropickListId { get; set; }
        public string PoheaderId { get; set; }
        public string MoheaderId { get; set; }
        public string ModetailId { get; set; }
        public string ItemPlantId { get; set; }
        public string PacketMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? PickListQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
