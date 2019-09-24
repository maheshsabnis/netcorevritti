using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UsrCtrlProp
    {
        public decimal RecId { get; set; }
        public string UsrCtrlPropId { get; set; }
        public string UsrCtrlMasterId { get; set; }
        public string PropName { get; set; }
        public string AllowedValues { get; set; }
        public string DefaultPropVal { get; set; }
        public string SecId { get; set; }
    }
}
