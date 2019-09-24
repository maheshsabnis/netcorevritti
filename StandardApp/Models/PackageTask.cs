using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PackageTask
    {
        public string FunctionId { get; set; }
        public string FunctionDesc { get; set; }
        public string ParentFunctionId { get; set; }
        public string TechnicalName { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
