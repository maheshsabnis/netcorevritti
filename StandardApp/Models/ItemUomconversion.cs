using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemUomconversion
    {
        public string ItemUomconversionId { get; set; }
        public string ItemMasterId { get; set; }
        public string Uomfrom { get; set; }
        public string Uomto { get; set; }
        public decimal? ConvFactor { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
