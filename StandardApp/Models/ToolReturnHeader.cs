using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ToolReturnHeader
    {
        public string ToolRetHdrId { get; set; }
        public string RectNo { get; set; }
        public DateTime? RectDt { get; set; }
        public string PlantId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Remark { get; set; }
    }
}
