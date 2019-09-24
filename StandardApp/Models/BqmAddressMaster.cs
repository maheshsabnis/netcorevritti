using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqmAddressMaster
    {
        public string BqmAddressMasterId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ResidentialNo { get; set; }
        public string OfficeNo { get; set; }
        public string FaxNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
    }
}
