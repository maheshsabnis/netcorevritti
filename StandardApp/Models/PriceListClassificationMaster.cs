using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PriceListClassificationMaster
    {
        public string PriceListClassificationId { get; set; }
        public string ClassificationCode { get; set; }
        public string ClassificationDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
