using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ToolReturnDetail
    {
        public string ToolRectDtlId { get; set; }
        public string ToolRectHdrId { get; set; }
        public string MoheaderId { get; set; }
        public string ToolId { get; set; }
        public string Lotno { get; set; }
        public DateTime? RectDt { get; set; }
        public bool? Usable { get; set; }
        public string ToLocation { get; set; }
        public decimal? Qty { get; set; }
        public decimal? IssueQty { get; set; }
        public decimal? BalToReturn { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
