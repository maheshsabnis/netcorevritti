using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemParameterMaster
    {
        public string ItemParameterMasterId { get; set; }
        public string ItemClassificationId { get; set; }
        public string ParameterGroupId { get; set; }
        public string ParameterDesc { get; set; }
        public string ConfigTypeId { get; set; }
        public bool? IsAttachment { get; set; }
        public bool? IsForeignValue { get; set; }
        public string ForeignTable { get; set; }
        public string ForeignDisplayMember { get; set; }
        public string ForeignValuemember { get; set; }
        public string DataType { get; set; }
        public decimal? Decimals { get; set; }
        public decimal? StdValue { get; set; }
        public decimal? PositiveTollerance { get; set; }
        public decimal? NegativeTollerance { get; set; }
        public bool? IsParentParameter { get; set; }
        public string ParentParameterId { get; set; }
        public bool? ReqdForQc { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
