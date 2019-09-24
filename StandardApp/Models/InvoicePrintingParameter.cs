﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class InvoicePrintingParameter
    {
        public decimal RecId { get; set; }
        public string RptNmHeaderId { get; set; }
        public string Description { get; set; }
        public string ReportNm { get; set; }
        public string RptDllname { get; set; }
        public string InvFor { get; set; }
    }
}
