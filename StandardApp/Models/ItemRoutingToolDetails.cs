using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemRoutingToolDetails
    {
        public string ItmRoutToolId { get; set; }
        public string ItmRoutingDtlId { get; set; }
        public string ItmClassId { get; set; }
        public string ToolId { get; set; }
        public string DrawingNo { get; set; }
        public decimal? Qty { get; set; }
        public string Remark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
