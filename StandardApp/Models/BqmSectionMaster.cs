using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqmSectionMaster
    {
        public string BqmSectionMasterId { get; set; }
        public string SectionSeq { get; set; }
        public string SectionName { get; set; }
        public string Remarks { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
