using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rfmaster
    {
        public decimal Rfid { get; set; }
        public string TaskId { get; set; }
        public string TableName { get; set; }
        public string DtableName { get; set; }
        public string FieldName { get; set; }
        public string DfieldName { get; set; }
        public string FunctionId { get; set; }
        public string ConditionId { get; set; }
        public bool? Rfactive { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
