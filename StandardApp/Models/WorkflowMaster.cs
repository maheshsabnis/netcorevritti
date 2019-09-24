using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WorkflowMaster
    {
        public string WorkflowId { get; set; }
        public string WorkflowDescription { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsPrefix { get; set; }
        public string IsMainGroup { get; set; }
        public string IsSubGroup { get; set; }
        public string IsWorkSpace { get; set; }
        public string ItemMasterId { get; set; }
    }
}
