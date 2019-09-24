using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SizeMaster
    {
        public string SizeCode { get; set; }
        public string SizeDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
