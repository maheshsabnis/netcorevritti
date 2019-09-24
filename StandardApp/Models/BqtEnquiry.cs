using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqtEnquiry
    {
        public string BqtEnquiryId { get; set; }
        public decimal? EnquiryNo { get; set; }
        public DateTime? EventFromDate { get; set; }
        public DateTime? EventToDate { get; set; }
        public string TimeSlot { get; set; }
        public string EventType { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public decimal? NoOfPersons { get; set; }
        public string VenueMasterId { get; set; }
        public string BanquentClientId { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Potential { get; set; }
        public string HandledBy { get; set; }
        public string Remarks { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
