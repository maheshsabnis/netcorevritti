using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CarrierMaster
    {
        public string PkcarrierId { get; set; }
        public string CarrierName { get; set; }
        public string CarrierAddress { get; set; }
        public string City { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
