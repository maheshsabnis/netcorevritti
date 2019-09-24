using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MomtrlReqPickList
    {
        public string MomtrlReqPickListId { get; set; }
        public string MomtrlReqHeaderId { get; set; }
        public string MomtrlReqSummaryId { get; set; }
        public string ItemPlantId { get; set; }
        public string PacketMasterId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? PickListQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string StockDetailsId { get; set; }
    }
}
