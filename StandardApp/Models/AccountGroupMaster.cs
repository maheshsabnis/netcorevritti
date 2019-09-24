using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AccountGroupMaster
    {
        public decimal RecId { get; set; }
        public string AccGrpMasterId { get; set; }
        public string AccGrpCode { get; set; }
        public string AccGrpDesc { get; set; }
        public string AccGrpType { get; set; }
        public string Lora { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string ParentGrp { get; set; }
        public string AlternateGrp { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SchMstRefId { get; set; }
    }
}
