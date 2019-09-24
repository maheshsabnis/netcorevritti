using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EntityCreationTable
    {
        public string VendorMasterId { get; set; }
        public string EntityType { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string ShortName { get; set; }
        public string CompAddress { get; set; }
        public string ContactName { get; set; }
        public string Designation { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string SkypeId { get; set; }
        public string Influntial { get; set; }
        public string Pincode { get; set; }
        public string Country { get; set; }
        public string InState { get; set; }
        public string City { get; set; }
        public string Distict { get; set; }
        public string Taluka { get; set; }
        public string LanlineNo { get; set; }
        public string Currency { get; set; }
        public string Gstno { get; set; }
        public string Pano { get; set; }
        public string PayeeName { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Ifscode { get; set; }
        public string BankAddress { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public string Remittance { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsEntitySatus { get; set; }
    }
}
