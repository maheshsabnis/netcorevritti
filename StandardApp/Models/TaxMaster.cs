using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TaxMaster
    {
        public string TaxMasterId { get; set; }
        public string TaxCode { get; set; }
        public string TaxDesc { get; set; }
        public bool? Recoverable { get; set; }
        public decimal? RecoveryPer { get; set; }
        public string PayableAccount { get; set; }
        public string ReceivableAccount { get; set; }
        public string TaxAuthorityId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string TaxGroup { get; set; }
        public string ChargeMasterId { get; set; }
    }
}
