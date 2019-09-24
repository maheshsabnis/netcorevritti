using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AsnchargeDetail
    {
        public string AsnchargeDetailId { get; set; }
        public string AsndetailId { get; set; }
        public string AsnheaderId { get; set; }
        public string PochargeDetailId { get; set; }
        public string PoheaderId { get; set; }
        public string ChrgMasterId { get; set; }
        public string CalcMethod { get; set; }
        public decimal? ChargeAmount { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? TaxAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
