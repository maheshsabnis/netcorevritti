using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PanelMaster
    {
        public string PanelMasterId { get; set; }
        public string FormId { get; set; }
        public string PanelId { get; set; }
        public decimal? SeqNo { get; set; }
        public string PanTitle { get; set; }
        public string TagTitle { get; set; }
        public bool? Visibility { get; set; }
    }
}
