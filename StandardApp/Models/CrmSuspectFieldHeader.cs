using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmSuspectFieldHeader
    {
        public string PkprospectHdrId { get; set; }
        public string ProspectType { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
