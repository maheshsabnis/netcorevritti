using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouPrintProg
    {
        public decimal RecId { get; set; }
        public string VouPrintId { get; set; }
        public string VouPrintProgDesc { get; set; }
        public string AssemblyName { get; set; }
        public string ExecutionString { get; set; }
    }
}
