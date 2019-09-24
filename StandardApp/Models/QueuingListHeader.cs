using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class QueuingListHeader
    {
        public string QueuingListHeaderId { get; set; }
        public string QueuingListNo { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string PlantMasterId { get; set; }
        public string ItemMasterId { get; set; }
        public string OperationMasterId { get; set; }
        public decimal? Qty { get; set; }
        public string QueuingStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SrcOperId { get; set; }
    }
}
