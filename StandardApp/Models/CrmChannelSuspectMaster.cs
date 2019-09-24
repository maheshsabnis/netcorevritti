using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmChannelSuspectMaster
    {
        public string PksuspectId { get; set; }
        public string SuspectCode { get; set; }
        public string FirmName { get; set; }
        public string Address { get; set; }
        public string FkcityId { get; set; }
        public string BusinessDetails { get; set; }
        public string FkbusiSegmentId { get; set; }
        public decimal? Turnover { get; set; }
        public decimal? NoOfEmployees { get; set; }
        public decimal? NoOfOffices { get; set; }
        public string FkcustomerId { get; set; }
        public bool? IsProspect { get; set; }
        public bool? IsLead { get; set; }
        public bool? IsOrder { get; set; }
        public DateTime? ProspectStatusChangedDate { get; set; }
        public string ProspectStatusChangedBy { get; set; }
        public DateTime? LeadStatusChangedDate { get; set; }
        public string LeadStatusChangedBy { get; set; }
        public DateTime? OrderStatusChangedDate { get; set; }
        public string OrderStatusChangedBy { get; set; }
        public int? MoveToArchieve { get; set; }
        public string MoveToArchieveBy { get; set; }
        public string ReasonCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string FkterritoryId { get; set; }
        public string FkenqSourceId { get; set; }
        public string CompanyUrl { get; set; }
        public string LeadGivenByid { get; set; }
        public string EmailMsgId { get; set; }
        public DateTime? MoveToArchieveDt { get; set; }
        public string MoveToArchieveReason { get; set; }
        public string MoveToArchieveNotes { get; set; }
        public int OpenCalls { get; set; }
        public int CloseCalls { get; set; }
        public int OrderReceived { get; set; }
        public int OrderLost { get; set; }
        public int OrderRegrete { get; set; }
        public int CallCloseWithoutOrder { get; set; }
        public string FirmAlias { get; set; }
        public string FkconsigneeId { get; set; }
        public DateTime LastCssdate { get; set; }
        public string LastCssrating { get; set; }
        public DateTime FuturePlanDate { get; set; }
        public DateTime? LastSodate { get; set; }
        public DateTime? LastSoscheduleDate { get; set; }
        public DateTime? LastShipmentDate { get; set; }
        public string FkplantId { get; set; }
        public int SuspStatus { get; set; }
        public string ByChannelId { get; set; }
        public string LockFor { get; set; }
        public DateTime LockTillDate { get; set; }
        public string RejectionReason { get; set; }
        public string IsLocked { get; set; }
    }
}
