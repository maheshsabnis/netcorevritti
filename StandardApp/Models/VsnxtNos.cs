using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VsnxtNos
    {
        public string DocName { get; set; }
        public decimal NextNos { get; set; }
        public string PrefixText { get; set; }
        public decimal RecCounter { get; set; }
        public bool? IsSync { get; set; }
    }
}
