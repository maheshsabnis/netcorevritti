using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CurrencyMaster
    {
        public string CurrencyMasterId { get; set; }
        public string CurrCode { get; set; }
        public string CurrDesc { get; set; }
        public string CurrSymbol { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? NoOfDcmlDigits { get; set; }
        public bool? IsLocalCurr { get; set; }
        public string FractionalCurr { get; set; }
    }
}
