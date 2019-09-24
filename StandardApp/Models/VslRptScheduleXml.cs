using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslRptScheduleXml
    {
        public decimal RecId { get; set; }
        public string RptName { get; set; }
        public string RptBasicXml { get; set; }
        public string IsScheduled { get; set; }
    }
}
