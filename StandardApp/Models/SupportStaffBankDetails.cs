using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SupportStaffBankDetails
    {
        public string UserBankId { get; set; }
        public string UserMasterId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public string Ifscode { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SatffAddress { get; set; }
        public string VendorName { get; set; }
        public string Pano { get; set; }
        public string AdharNo { get; set; }
    }
}
