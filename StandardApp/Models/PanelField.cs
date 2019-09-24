using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PanelField
    {
        public decimal RecId { get; set; }
        public string PanelFieldId { get; set; }
        public string PanelMasterId { get; set; }
        public string UsrCtrlMasterId { get; set; }
        public int? FieldNo { get; set; }
        public string FieldName { get; set; }
        public string FieldDesc { get; set; }
        public int? TabOrder { get; set; }
        public string IsVisible { get; set; }
        public string IsMandatory { get; set; }
        public string AllowChange { get; set; }
        public string DefaultValue { get; set; }
        public string SecId { get; set; }
        public string IsHidden { get; set; }
    }
}
