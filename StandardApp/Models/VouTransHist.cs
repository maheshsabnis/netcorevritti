using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouTransHist
    {
        public string VouTransHistId { get; set; }
        public string TransNo { get; set; }
        public string PanelName { get; set; }
        public string ChangesDetails { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
    }
}
