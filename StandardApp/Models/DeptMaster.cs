using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DeptMaster
    {
        public string PkdeptMasterid { get; set; }
        public string DeptCode { get; set; }
        public string DeptDesc { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
    }
}
