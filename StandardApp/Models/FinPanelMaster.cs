using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class FinPanelMaster
    {
        public decimal RecId { get; set; }
        public string PanelMasterId { get; set; }
        public string PanelDesc { get; set; }
        public string PanelTitle { get; set; }
        public string AssemblyName { get; set; }
        public string ExecutionString { get; set; }
        public string SecId { get; set; }
    }
}
