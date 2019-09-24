using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmPromSchMaster
    {
        public string PkpromoSchemeId { get; set; }
        public string SchemeCode { get; set; }
        public string IsProductServiceAmc { get; set; }
        public string SchemeName { get; set; }
        public DateTime? EffectiveFromDate { get; set; }
        public DateTime? EffectiveToDate { get; set; }
        public bool? IsActive { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
