using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OfflineOpStk
    {
        public string OfflineOpStkId { get; set; }
        public string PlantId { get; set; }
        public string ItemCode { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string BatchNo { get; set; }
        public decimal? OpeningQty { get; set; }
        public decimal? OpeningRate { get; set; }
        public decimal? OpeningValue { get; set; }
        public string Reference { get; set; }
    }
}
