using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rrf
    {
        public string Rrfid { get; set; }
        public string Rrfno { get; set; }
        public DateTime? Rrfdt { get; set; }
        public DateTime? ReqByDate { get; set; }
        public string DeptId { get; set; }
        public string DesignationId { get; set; }
        public string JobDesc { get; set; }
        public string EmploymentType { get; set; }
        public string NoOfVacancies { get; set; }
        public string TotalExp { get; set; }
        public string CustomerId { get; set; }
        public string RrfapprStatus { get; set; }
        public string HrexecutiveId { get; set; }
        public string Rrfstatus { get; set; }
        public int? Cvrecd { get; set; }
        public int? Cvhracc { get; set; }
        public int? Cvhrrej { get; set; }
        public int? Cvhrpend { get; set; }
        public int? CvdeptAcc { get; set; }
        public int? CvdeptRej { get; set; }
        public int? CvdeptPend { get; set; }
        public int? Intrv1Acc { get; set; }
        public int? Intrv1Rej { get; set; }
        public int? Intrv1Pend { get; set; }
        public string Intrv2Acc { get; set; }
        public string Intrv2Rej { get; set; }
        public string Intrv2Pend { get; set; }
        public string Intrv3Acc { get; set; }
        public string Intrv3Rej { get; set; }
        public string Intrv3Pend { get; set; }
        public string Ctcoffered { get; set; }
        public string Remark { get; set; }
        public string ActivityId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ApproverId { get; set; }
        public string CvscreenBy { get; set; }
        public string Interview1By { get; set; }
        public string Interview2By { get; set; }
        public string Interview3By { get; set; }
        public string ModeOfEmp { get; set; }
        public string EmploymentSubType { get; set; }
        public string Replaceby { get; set; }
        public string PlantMasterId { get; set; }
        public string IsAvailableWp { get; set; }
        public string RelevantExp { get; set; }
        public string BudgAmount { get; set; }
        public string AssetDesc { get; set; }
        public string KeyResult { get; set; }
        public string Location { get; set; }
        public string Justification { get; set; }
        public string IsAssetRequired { get; set; }
        public bool? ClosedForAgency { get; set; }
    }
}
