using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Kotdetail
    {
        public string KotdetailId { get; set; }
        public string KotheaderId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ItemStatus { get; set; }
        public string ItemPrizeListId { get; set; }
        public decimal? QtyRem { get; set; }
        public DateTime? ItemCompletedOn { get; set; }
    }
}
