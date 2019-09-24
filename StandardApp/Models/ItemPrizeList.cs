using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemPrizeList
    {
        public string ItemPrizeListId { get; set; }
        public string ItemPlantId { get; set; }
        public DateTime EffFrom { get; set; }
        public decimal? Rate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string OrderTypeMasterId { get; set; }
    }
}
