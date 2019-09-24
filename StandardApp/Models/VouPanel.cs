using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouPanel
    {
        public decimal RecId { get; set; }
        public string VouPanelId { get; set; }
        public string VouMasterId { get; set; }
        public string VouPnlDesc { get; set; }
        public string PanelMasterId { get; set; }
        public string CrDr { get; set; }
        public int? TabOrder { get; set; }
        public string IsVisible { get; set; }
        public string IsMandatory { get; set; }
        public decimal? LinesAllowed { get; set; }
        public string IsSysGenerated { get; set; }
        public string ManualAllowed { get; set; }
        public string SecId { get; set; }
    }
}
