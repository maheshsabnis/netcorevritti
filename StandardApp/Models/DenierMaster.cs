using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DenierMaster
    {
        public string DenierCode { get; set; }
        public string DenierDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
