using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BioMetricData
    {
        public string BioMetricDataId { get; set; }
        public string UserLoginId { get; set; }
        public DateTime? PresentDate { get; set; }
        public string PresentTime { get; set; }
        public string InOutStatus { get; set; }
        public DateTime? AddedDt { get; set; }
        public string UserMasterId { get; set; }
        public string Location { get; set; }
        public string AddedBy { get; set; }
        public string MachineNo { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string LocationName { get; set; }
        public string IsVerified { get; set; }
        public string Remark { get; set; }
    }
}
