using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TestCaseMaster
    {
        public string PktestId { get; set; }
        public string TestCaseCode { get; set; }
        public string ProjectId { get; set; }
        public string ModuleId { get; set; }
        public string Prerequisite { get; set; }
        public string Objective { get; set; }
        public string PriorityId { get; set; }
        public string TestDescription { get; set; }
        public string TestSteps { get; set; }
        public string Expectedresult { get; set; }
        public string Actualresult { get; set; }
        public string ExecutionStatus { get; set; }
        public string DefectId { get; set; }
        public string TesterId { get; set; }
        public string Comments { get; set; }
        public string TypeId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? ExecutionDt { get; set; }
        public string ActivityId { get; set; }
    }
}
