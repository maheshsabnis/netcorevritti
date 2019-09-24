using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserMaster
    {
        public UserMaster()
        {
            EmpDocInfo = new HashSet<EmpDocInfo>();
        }

        public string UserMasterId { get; set; }
        public string UserLoginId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string UserPassword { get; set; }
        public string HintQuestion { get; set; }
        public string Answer { get; set; }
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
        public string PlantMasterId { get; set; }
        public DateTime? ActvDactvDt { get; set; }
        public string Crmcode { get; set; }
        public decimal? Crmcategory { get; set; }
        public int? CrmnoofDays { get; set; }
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
        public bool? ChangePass1stLogin { get; set; }
        public bool? IsClientContact { get; set; }
        public bool? Active { get; set; }
        public string Gender { get; set; }
        public bool? IsSysUser { get; set; }
        public bool? MobileActive { get; set; }
        public string RegularWkoff { get; set; }
        public string AlternetWkOff { get; set; }
        public string AlternetWkOffVal { get; set; }
        public string EffectLeaveDate { get; set; }
        public bool? IsBuyer { get; set; }
        public DateTime? SeptDate { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string InOutFlg { get; set; }
        public string FkShiftMasterId { get; set; }
        public string IsAttendanceRecordMandatory { get; set; }
        public string ConsiderWeeklyOff { get; set; }
        public bool? IsIntDeptEmp { get; set; }
        public string MembershipNo { get; set; }
        public string FkuserCategoryId { get; set; }
        public string PerState { get; set; }
        public string PerCountry { get; set; }
        public string PreCountry { get; set; }
        public string PreCode { get; set; }
        public string PerCode { get; set; }
        public string PerAddr { get; set; }
        public string PreAddr { get; set; }
        public string PerCity { get; set; }
        public string PreCity { get; set; }
        public string AllowUsrTimeSlotHrs { get; set; }
        public string SameAsPresent { get; set; }
        public string UseShift { get; set; }
        public string PreState { get; set; }
        public int? IsHrexecutive { get; set; }
        public string FkEmpStatus { get; set; }
        public bool? IsdefaultUser { get; set; }
        public string IsExternalUser { get; set; }
        public string Pan { get; set; }
        public string Pfno { get; set; }
        public string Aadhaar { get; set; }
        public bool? IsDeliveryAgent { get; set; }
        public string IsBus { get; set; }

        public virtual ICollection<EmpDocInfo> EmpDocInfo { get; set; }
    }
}
