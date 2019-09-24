using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProjectTypeMaster
    {
        public string ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModuleDesc { get; set; }
        public string UnitDesc { get; set; }
        public string ActivityDesc { get; set; }
        public string ProjectTypeCode { get; set; }
    }
}
