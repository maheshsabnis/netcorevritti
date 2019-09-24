using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalvDetail
    {
        public string SalvDetailId { get; set; }
        public string SalvHeaderId { get; set; }
        public string MoheaderId { get; set; }
        public decimal? ReworkQty { get; set; }
        public decimal? SecondsQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? TotalQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string StatusId { get; set; }
        public decimal? OkQty { get; set; }
    }
}
