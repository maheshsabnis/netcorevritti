using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqmBanquetContactInfo
    {
        public string BqmBanquetContactInfoId { get; set; }
        public string BqmBanquetClientId { get; set; }
        public string ContPerName { get; set; }
        public string Designation { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public decimal? InfluentialLevel { get; set; }
        public string IsDefault { get; set; }
        public string IsDeleted { get; set; }
        public string ContactType { get; set; }
        public string IsVwbloginAllowed { get; set; }
        public bool? IsTimeAllow { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
    }
}
