using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BusinessTripAdvanceMaster
    {
        public string PkadvanceId { get; set; }
        public DateTime TripDate { get; set; }
        public string EmpId { get; set; }
        public string AuthorisedBy { get; set; }
        public DateTime AddedDt { get; set; }
        public string AddedBy { get; set; }
        public int TotalAmt { get; set; }
        public int Advance { get; set; }
        public int Balance { get; set; }
        public bool IsDeleted { get; set; }
        public string Approved { get; set; }
        public string Status { get; set; }
        public DateTime ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
        public string JourneyMode { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public string Occassion { get; set; }
        public string Reason { get; set; }
        public string TripAdvCode { get; set; }
    }
}
