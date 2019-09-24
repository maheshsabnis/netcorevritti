using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DocPrintCount
    {
        public string DocPrintCountId { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public string BarcodeNo { get; set; }
        public decimal? Count { get; set; }
    }
}
