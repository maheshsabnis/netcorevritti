using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class McnDwnRsnMaster
    {
        public string McnDwnRsnMasterId { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDesc { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
