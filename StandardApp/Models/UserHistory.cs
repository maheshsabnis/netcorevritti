using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserHistory
    {
        public string PkuserHstryId { get; set; }
        public string FkuserMasterId { get; set; }
        public string UserLoginId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string DeptMasterId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string ExtNo { get; set; }
        public string LocationId { get; set; }
        public string ReportingTo { get; set; }
        public string Phone { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string IsActive { get; set; }
        public string IsReportingUsingExcel { get; set; }
        public string DesignationId { get; set; }
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsuprofileExpire { get; set; }
        public DateTime? UprofileExpDate { get; set; }
        public DateTime? PswModifiedDt { get; set; }
        public DateTime? LastLoginDt { get; set; }
        public bool? IsDisabled { get; set; }
        public decimal? FailedLoginAttempt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsCompleteRight { get; set; }
        public int? AllowEditingDays { get; set; }
        public string MiddleName { get; set; }
        public string MembershipNo { get; set; }
        public string FkuserCategoryId { get; set; }
    }
}
