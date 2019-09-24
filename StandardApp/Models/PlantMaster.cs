using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PlantMaster
    {
        public string PlantMasterId { get; set; }
        public string PlantName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string Cstno { get; set; }
        public string Bstno { get; set; }
        public string ExciseNo { get; set; }
        public string Tin { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ApplicationThemeColor { get; set; }
        public string LeftPanelBackColor { get; set; }
        public string ExciseApplicable { get; set; }
        public string PrefixText { get; set; }
        public string StateMasterId { get; set; }
        public bool? IsActive { get; set; }
        public string ClaimApproval { get; set; }
        public string LeaveApproval { get; set; }
        public string LeaveCancellation { get; set; }
        public string ExtraWorkApproval { get; set; }
        public string WarrantyApproval { get; set; }
        public string Gstcode { get; set; }
        public string AssetApproval { get; set; }
        public string Rrfapproval { get; set; }
        public string Soshortclsappr { get; set; }
        public string AdvancePaymentApproval { get; set; }
        public string SpotApproval { get; set; }
        public string DiscApproval { get; set; }
        public string Bankmasterid { get; set; }
    }
}
