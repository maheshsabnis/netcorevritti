using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TaskMaster
    {
        public string PktaskId { get; set; }
        public string TaskDesc { get; set; }
        public string ParentTaskId { get; set; }
        public string TechnicalName { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string FkmoduleId { get; set; }
        public string FkmenuId { get; set; }
        public string DefaultAuth { get; set; }
        public string IsLock { get; set; }
        public string EncrptTechName { get; set; }
    }
}
