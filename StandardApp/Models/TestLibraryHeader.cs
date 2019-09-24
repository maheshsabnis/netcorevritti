using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TestLibraryHeader
    {
        public string PkfunctionId { get; set; }
        public string FunctionName { get; set; }
        public string FunctionDesc { get; set; }
        public string Prerequisite { get; set; }
        public string Objective { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ActivityId { get; set; }
    }
}
