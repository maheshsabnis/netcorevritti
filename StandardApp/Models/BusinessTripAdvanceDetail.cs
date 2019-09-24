using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BusinessTripAdvanceDetail
    {
        public string PkadvanceDetailId { get; set; }
        public string PkadvanceId { get; set; }
        public string TripPurpose { get; set; }
        public bool IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string OtherParticipants { get; set; }
        public string TripTraining { get; set; }
        public string TripRect { get; set; }
        public string TripOth { get; set; }
    }
}
