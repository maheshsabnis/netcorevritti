using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AppMethod
    {
        public string AppMethodId { get; set; }
        public string MethodCode { get; set; }
        public decimal? ValueFrom { get; set; }
        public decimal? ValueTo { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDt { get; set; }
    }
}
