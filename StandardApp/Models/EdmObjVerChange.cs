using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EdmObjVerChange
    {
        public string EdmObjVerChangeId { get; set; }
        public string ObjName { get; set; }
        public string ObjType { get; set; }
        public string EdmExecHistoryId { get; set; }
        public decimal? PrevVersion { get; set; }
        public decimal? NewVersion { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
