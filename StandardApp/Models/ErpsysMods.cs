using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ErpsysMods
    {
        public decimal ErpsysModsId { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleDesc { get; set; }
        public decimal? LeadingZeros { get; set; }
        public string DefaultSepChar { get; set; }
        public string SepChar { get; set; }
        public string ModTextFormat { get; set; }
        public string ModCntrValue { get; set; }
    }
}
