using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ExchRateMaster
    {
        public string ExchRateMasterId { get; set; }
        public string CurrFromId { get; set; }
        public string CurrToId { get; set; }
        public decimal? CurrConversion { get; set; }
        public DateTime? EffFrom { get; set; }
        public DateTime? EffUpto { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
