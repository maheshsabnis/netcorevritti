using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ModuleMaster
    {
        public string PkmoduleMastId { get; set; }
        public string ModuleName { get; set; }
        public string ProjectId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModuleCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string HoursRequired { get; set; }
        public string IssuedTo { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string IsDefaultModule { get; set; }
        public string ClientId { get; set; }
    }
}
