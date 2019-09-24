using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BinAcrcyHdr
    {
        public string BinAcrcyHdrId { get; set; }
        public string PlantId { get; set; }
        public string Code { get; set; }
        public DateTime? ForMthYr { get; set; }
        public decimal? WrkDays { get; set; }
        public decimal? LocCount { get; set; }
        public string FrmLoc { get; set; }
        public string ToLoc { get; set; }
        public string Status { get; set; }
        public string IsDeleted { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string LocSummerised { get; set; }
    }
}
