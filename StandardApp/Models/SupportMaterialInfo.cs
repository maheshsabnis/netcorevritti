using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SupportMaterialInfo
    {
        public string PkmaterialId { get; set; }
        public string ActivityId { get; set; }
        public string SerialNo { get; set; }
        public string PhysicalCondn { get; set; }
        public string Note { get; set; }
        public string IsReturnable { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
