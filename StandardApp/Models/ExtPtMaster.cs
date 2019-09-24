using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ExtPtMaster
    {
        public decimal RecId { get; set; }
        public string ExtPtMasterId { get; set; }
        public string Epdescription { get; set; }
        public string AssemblyName { get; set; }
        public string ExecutionString { get; set; }
        public decimal? SeqNo { get; set; }
        public string IsActive { get; set; }
        public string SecId { get; set; }
    }
}
