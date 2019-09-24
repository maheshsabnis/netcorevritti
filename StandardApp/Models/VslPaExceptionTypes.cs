using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslPaExceptionTypes
    {
        public string ExceptionTypeId { get; set; }
        public string ExceptionTypeDesc { get; set; }
        public string IsWorking { get; set; }
        public string Remarks { get; set; }
        public string ClientId { get; set; }
    }
}
