using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouPanelField
    {
        public decimal RecId { get; set; }
        public string VouPanelFieldId { get; set; }
        public string VouPanelId { get; set; }
        public string PanelFieldId { get; set; }
        public string VouPnlFldDesc { get; set; }
        public string SecId { get; set; }
        public int? TabOrder { get; set; }
        public string IsVisible { get; set; }
        public string IsMandatory { get; set; }
        public string AllowChange { get; set; }
        public string DefaultValue { get; set; }
        public string EditableAfterPost { get; set; }
    }
}
