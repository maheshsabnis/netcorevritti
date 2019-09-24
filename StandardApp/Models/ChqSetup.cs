using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ChqSetup
    {
        public decimal RecId { get; set; }
        public string ChqSetupId { get; set; }
        public string ProgName { get; set; }
        public string FieldName { get; set; }
        public decimal? Xpos { get; set; }
        public decimal? Ypos { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Format { get; set; }
    }
}
