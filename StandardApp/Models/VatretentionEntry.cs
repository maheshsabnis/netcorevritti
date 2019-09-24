using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VatretentionEntry
    {
        public decimal RecId { get; set; }
        public string VatretentionEntryId { get; set; }
        public string FinDivId { get; set; }
        public string AccId { get; set; }
        public string IsSetOff { get; set; }
        public decimal? RetPer { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
