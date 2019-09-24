using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransErrLog
    {
        public decimal RecId { get; set; }
        public string TransErrLogId { get; set; }
        public string TransHeaderId { get; set; }
        public string PanelDesc { get; set; }
        public string FieldName { get; set; }
        public string ErrorDesc { get; set; }
    }
}
