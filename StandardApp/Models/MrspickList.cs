using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MrspickList
    {
        public string MrspickListId { get; set; }
        public string MrsheaderId { get; set; }
        public string MrsdetailId { get; set; }
        public string ItemPlantId { get; set; }
        public string PacketMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? PickListQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
