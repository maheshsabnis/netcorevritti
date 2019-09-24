using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SugPickList
    {
        public string SugPickListId { get; set; }
        public string PicklistHdrId { get; set; }
        public string PicklistdtlId { get; set; }
        public string ItemPlantId { get; set; }
        public string PacketMasterId { get; set; }
        public string StockDetailsId { get; set; }
        public decimal? PacketQty { get; set; }
        public decimal? PickListQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
