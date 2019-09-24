using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PrjDatasheetMaster
    {
        public string PkprjDatasheetId { get; set; }
        public string ProjectId { get; set; }
        public string DatasheetId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
