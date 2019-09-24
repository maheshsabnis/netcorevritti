using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EdmexecuteHistory
    {
        public string EdmexecuteHistoryId { get; set; }
        public string EdmexecHdrId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string ExecutedBy { get; set; }
        public string ExeVersion { get; set; }
        public DateTime? ModifiedDtOfExe { get; set; }
    }
}
