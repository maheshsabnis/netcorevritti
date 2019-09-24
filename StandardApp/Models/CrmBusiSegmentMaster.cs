using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmBusiSegmentMaster
    {
        public string PkbusiSegmentId { get; set; }
        public string SegmentCode { get; set; }
        public string SegmentDescription { get; set; }
        public string FkparentBusiSegmentId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
