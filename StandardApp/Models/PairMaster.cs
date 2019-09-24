using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PairMaster
    {
        public string PairCode { get; set; }
        public string PairDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
