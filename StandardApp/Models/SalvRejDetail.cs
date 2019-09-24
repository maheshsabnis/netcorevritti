using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalvRejDetail
    {
        public string SalvRejDetailId { get; set; }
        public string SalvHeaderId { get; set; }
        public string ConfigurationDetailId { get; set; }
        public decimal? RejectionType { get; set; }
        public decimal? RejectionQuantity { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? SecondsQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? ReworkQty { get; set; }
    }
}
