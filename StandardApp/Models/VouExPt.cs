using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouExPt
    {
        public decimal RecId { get; set; }
        public string VouExPtId { get; set; }
        public string VouMasterId { get; set; }
        public string ExPtMasterId { get; set; }
        public string EventName { get; set; }
        public string IsActive { get; set; }
        public string SecId { get; set; }
    }
}
