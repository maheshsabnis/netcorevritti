using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rfstatus
    {
        public decimal RfstatusId { get; set; }
        public string TaskId { get; set; }
        public string TableName { get; set; }
        public string Code { get; set; }
        public string ItemDesc { get; set; }
        public string DtableName { get; set; }
        public string FunctionId { get; set; }
        public string Dfunction { get; set; }
        public string FieldName { get; set; }
        public string DfieldName { get; set; }
        public string ConditionId { get; set; }
        public bool? Status { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
