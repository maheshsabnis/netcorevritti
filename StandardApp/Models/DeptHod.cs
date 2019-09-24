using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DeptHod
    {
        public string PkdeptHodId { get; set; }
        public string FkdeptMastId { get; set; }
        public string FkuserMastId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
