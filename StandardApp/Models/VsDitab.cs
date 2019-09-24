using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VsDitab
    {
        public string VsDitabId { get; set; }
        public decimal? CheckId { get; set; }
        public string TabName { get; set; }
        public string TabColName { get; set; }
        public string TabKeyValue { get; set; }
        public string DbAction { get; set; }
        public string IsReflected { get; set; }
        public string ClientId { get; set; }
        public string Remarks { get; set; }
        public string DistList { get; set; }
    }
}
