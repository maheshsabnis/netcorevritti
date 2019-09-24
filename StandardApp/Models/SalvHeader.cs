using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalvHeader
    {
        public string SalvHeaderId { get; set; }
        public string SalvNo { get; set; }
        public DateTime? SalvDt { get; set; }
        public string ItemPlantId { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? ReworkQty { get; set; }
        public decimal? SecondsQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? TotalQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public decimal? OkQty { get; set; }
    }
}
