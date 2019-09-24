using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AcGroupMaster
    {
        public string AcGroupMasterId { get; set; }
        public string AcGroupNo { get; set; }
        public string AcGroupName { get; set; }
        public string AcGroupType { get; set; }
        public decimal? PL { get; set; }
        public string Lora { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string ParentGr { get; set; }
        public string AltGroupAcNo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
