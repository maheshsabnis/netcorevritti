using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Bomheader
    {
        public string BomheaderId { get; set; }
        public string Bomcode { get; set; }
        public string ItemMasterId { get; set; }
        public string HeaderDesc { get; set; }
        public decimal? QtyPer { get; set; }
        public decimal? StdPurMtrlCost { get; set; }
        public decimal? FuturePurMtrlCost { get; set; }
        public decimal? StdMfgMtrlCost { get; set; }
        public decimal? FutureMfgMtrlCost { get; set; }
        public decimal? StdScrapRealization { get; set; }
        public decimal? FutureScrapRealization { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string UommasterId { get; set; }
        public string ItemClassificationId { get; set; }
        public string Bomcontains { get; set; }
        public bool? BomonClass { get; set; }
    }
}
