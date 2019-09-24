using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ClientLicenseDetails
    {
        public string PklicenceId { get; set; }
        public string WebUrl { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string UsersAllowed { get; set; }
        public string ActualUsersAllowed { get; set; }
        public string ExpiryDate { get; set; }
        public string LicenseExpires { get; set; }
        public string VwbdbcnnString { get; set; }
        public string EkatmInstalled { get; set; }
        public string Server { get; set; }
        public string Environment { get; set; }
        public string LogoFile { get; set; }
        public string ActivationDate { get; set; }
        public string BillingInfo { get; set; }
        public string VwbrptDbconnString { get; set; }
        public string ContactName { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
