using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesPickList
    {
        public string SalesPickListId { get; set; }
        public string SalesHeaderId { get; set; }
        public string SalesDtlId { get; set; }
        public string ItemPlantId { get; set; }
        public string PacketMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? PickListQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string PacketNo { get; set; }
        public string PacketSrNo { get; set; }
        public decimal? NoofBoxex { get; set; }
    }
}
