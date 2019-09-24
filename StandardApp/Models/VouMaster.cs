using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouMaster
    {
        public decimal RecId { get; set; }
        public string VouMasterId { get; set; }
        public string VouName { get; set; }
        public string VouDesc { get; set; }
        public string IsActive { get; set; }
        public string SecId { get; set; }
        public string CurrencyCode { get; set; }
        public string IsForeignCur { get; set; }
        public string VouPrintId { get; set; }
        public int? VouClass { get; set; }
        public string ApprDefCode { get; set; }
        public string AutoReco { get; set; }
    }
}
