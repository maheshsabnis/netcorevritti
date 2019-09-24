using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CodePartMaster
    {
        public string CodePartMasterId { get; set; }
        public string CodeForMasterId { get; set; }
        public string Title { get; set; }
        public string CodeTableName { get; set; }
        public string DisplayFieldName { get; set; }
        public string ValueFieldName { get; set; }
        public string CodeType { get; set; }
        public string ConstantValue { get; set; }
        public decimal? CodeLength { get; set; }
        public decimal? CodeSeqNo { get; set; }
        public string AppendedBy { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
