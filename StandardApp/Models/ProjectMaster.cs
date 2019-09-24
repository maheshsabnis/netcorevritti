using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProjectMaster
    {
        public string ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsActive { get; set; }
        public string IsActivityMandatory { get; set; }
        public string IsDelayedActivityAllowed { get; set; }
        public string LocationId { get; set; }
        public string IsProjectMngr { get; set; }
        public string MembersCanCreate { get; set; }
        public string ShowToAllUsers { get; set; }
        public string OnlyProjectMngrCanCreate { get; set; }
        public string IsHoursMandatory { get; set; }
        public string Oano { get; set; }
        public string ClientName { get; set; }
        public string ContactPerson { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public DateTime? DateOfRequisition { get; set; }
        public DateTime? DateOfAuthorization { get; set; }
        public string Remarks { get; set; }
        public string CompanyId { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int? ProjectStatus { get; set; }
        public string AllowPrjChangeActivity { get; set; }
        public string DepMasterId { get; set; }
        public string IsActStatusUpdate { get; set; }
        public string AutoCodegen { get; set; }
        public string CodeGenMethodCode { get; set; }
        public bool? UserProjectRateCard { get; set; }
        public string TypeRate { get; set; }
        public bool? ClaimReimburse { get; set; }
        public string IsShowuser { get; set; }
        public string IsEndTime { get; set; }
        public string IsCompActPresent { get; set; }
        public string CompletionActId { get; set; }
        public string AllowUserToAssign { get; set; }
        public string IntimateActCompletion { get; set; }
        public string SodetailId { get; set; }
        public decimal? TypicalAmount { get; set; }
        public decimal? ActualAmount { get; set; }
        public decimal? BudgetVariation { get; set; }
        public string IsSystemGenerated { get; set; }
        public string ManulEntryOccurrence { get; set; }
        public string AllowUsrTimeSlotHrs { get; set; }
        public string AllowDate { get; set; }
        public string ItemMasterId { get; set; }
        public string AllowAttachDelete { get; set; }
    }
}
