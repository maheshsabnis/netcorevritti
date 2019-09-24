using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmEnquiryRegister
    {
        public string EnquiryRegistryId { get; set; }
        public DateTime? EnquiryDate { get; set; }
        public string RegistryById { get; set; }
        public string AssignedToId { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public long? ContactNumber { get; set; }
        public string Email { get; set; }
        public string EnquiryDetails { get; set; }
        public string ActionTaken { get; set; }
        public string ReasonForCancellation { get; set; }
        public string CallId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Addeddt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Status { get; set; }
    }
}
