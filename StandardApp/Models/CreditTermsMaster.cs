using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CreditTermsMaster
    {
        public string CreditTermsMasterId { get; set; }
        public string CreditTermsCode { get; set; }
        public string CreditTermsDesc { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
