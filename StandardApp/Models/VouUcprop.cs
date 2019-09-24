using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouUcprop
    {
        public decimal RecId { get; set; }
        public string VouUcpropId { get; set; }
        public string VouPanelFieldId { get; set; }
        public string UsrCtrlPropId { get; set; }
        public string DefaultPropVal { get; set; }
        public string DefDispVal { get; set; }
    }
}
