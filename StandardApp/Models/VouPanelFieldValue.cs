using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouPanelFieldValue
    {
        public decimal RecId { get; set; }
        public string VouPanelFieldValueId { get; set; }
        public string VouPanelFieldId { get; set; }
        public string UsrCtrlPropId { get; set; }
        public string PropType { get; set; }
        public string PropVal { get; set; }
        public string SecId { get; set; }
    }
}
