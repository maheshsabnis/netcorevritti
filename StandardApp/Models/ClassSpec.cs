using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ClassSpec
    {
        public string ClassSpecId { get; set; }
        public string ClassificationId { get; set; }
        public string SpecDetailId { get; set; }
        public string SpecHeaderId { get; set; }
        public string ComponentId { get; set; }
        public string IsMandetory { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
