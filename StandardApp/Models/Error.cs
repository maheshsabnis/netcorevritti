using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Error
    {
        public decimal ErrorId { get; set; }
        public string ErrorDesc { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModuleName { get; set; }
        public string ProcedureName { get; set; }
        public string UserName { get; set; }
        public string MachineName { get; set; }
    }
}
