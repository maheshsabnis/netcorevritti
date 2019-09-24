using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DsppkgListHeader
    {
        public string DsppkgListHeaderId { get; set; }
        public string PlantMasterId { get; set; }
        public string DsppkgListNo { get; set; }
        public DateTime? DsppkgListDt { get; set; }
        public string Remark { get; set; }
        public string StatusId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
