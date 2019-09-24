using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslRptGridStyle
    {
        public string PkrptStyleId { get; set; }
        public string RptBgColor { get; set; }
        public string RptForeColor { get; set; }
        public string RptFontName { get; set; }
        public string RptFontSize { get; set; }
        public string Rptcode { get; set; }
        public string FkuserMastId { get; set; }
    }
}
