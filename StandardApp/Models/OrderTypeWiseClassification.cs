using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OrderTypeWiseClassification
    {
        public string PkOrderTypeClassId { get; set; }
        public string OrderTypeId { get; set; }
        public string ItemClassificationId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
