using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ActivityAllocationMaster
    {
        public string ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string UserMasterId { get; set; }
        public string UnitId { get; set; }
        public string ActivityTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string IssuedTo { get; set; }
        public decimal? Status { get; set; }
        public string Remarks { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string HoursRequired { get; set; }
        public string ProposedUserId { get; set; }
        public string PriorityId { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public bool? IsApproval { get; set; }
        public string IsApproved { get; set; }
        public decimal? ChargedAmount { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public bool? IsChargable { get; set; }
        public string Reason { get; set; }
        public DateTime? ApprovalDt { get; set; }
        public string PeriodicBillId { get; set; }
        public string CompletionIntimate { get; set; }
        public decimal? AssignedCount { get; set; }
        public string AttachmentName { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public DateTime? ExpectedCompleteDate { get; set; }
        public string ActivityCode { get; set; }
        public decimal? ExecutionAmount { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
        public string ReassignedBy { get; set; }
        public DateTime? ReassignedDt { get; set; }
        public string PksubActivityId { get; set; }
        public string ParentActId { get; set; }
        public string IsSubActivity { get; set; }
        public string TicketCategory { get; set; }
        public string WarrantyCode { get; set; }
        public string IsCompActPresent { get; set; }
        public string CompletionActId { get; set; }
        public string TktCustReportedBy { get; set; }
        public string TktCustApprovedBy { get; set; }
        public string WarrantyId { get; set; }
        public string IsFromContract { get; set; }
        public string ActivityRecId { get; set; }
        public DateTime? LastReminderDt { get; set; }
        public decimal? ClosureReminderCount { get; set; }
        public DateTime? DateOfResumtion { get; set; }
        public string StatusAliasId { get; set; }
        public string AttachmentContent { get; set; }
        public string IsUnplanned { get; set; }
        public int? ServiceChargetoCust { get; set; }
        public string ProjectMasterId { get; set; }
        public int? Rating { get; set; }
        public string ReasonForowRating { get; set; }
        public string Fyyear { get; set; }
        public string ServiceId { get; set; }
    }
}
