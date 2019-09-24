﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCallList
    {
        public string CallId { get; set; }
        public string ProspectId { get; set; }
        public DateTime? CallStart { get; set; }
        public string Source { get; set; }
        public string SouceId { get; set; }
        public string Seid { get; set; }
        public string CallStatus { get; set; }
        public string BackOfficeExecutiveId { get; set; }
        public string CurrentCallOwner { get; set; }
        public string LatestRemark { get; set; }
        public string SpecialPrizeRequest { get; set; }
        public string SpecialPrizeApprover { get; set; }
        public string SpecialPrizeStatus { get; set; }
        public string PresalesSupportRequired { get; set; }
        public string PresalesExecutiveId { get; set; }
        public string PresalesSupportDetails { get; set; }
        public DateTime? PresalesSupportDueDate { get; set; }
        public string DemoRequired { get; set; }
        public DateTime? DemoDatetime { get; set; }
        public string DemoStatus { get; set; }
        public string PrebidRequired { get; set; }
        public string PrebidStatus { get; set; }
        public string PrebidDocId { get; set; }
        public string QuotationNo { get; set; }
        public DateTime? QuotationDate { get; set; }
        public decimal? QuotationValue { get; set; }
        public string QuotationDoc { get; set; }
        public string OrderStatus { get; set; }
        public string OrderReferenceId { get; set; }
        public DateTime? OrderReceivedDate { get; set; }
        public decimal? OrderValue { get; set; }
        public string OrderLostReasonCode { get; set; }
        public string OrderLostDetails { get; set; }
        public string ActivityId { get; set; }
        public decimal? TeleCallCount { get; set; }
        public decimal? MeetingCount { get; set; }
        public decimal? DemoCount { get; set; }
        public decimal? QuotationCount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ProductId { get; set; }
        public string CallTransferReasonCode { get; set; }
        public string DemoAssignedTo { get; set; }
        public decimal? ExpectedPrize { get; set; }
        public string Justification { get; set; }
        public string ContractReviewRequired { get; set; }
        public string ContractResponsibility { get; set; }
        public string ContractStatus { get; set; }
        public string ContractDocIdurl { get; set; }
        public DateTime? DateHotCallChanged { get; set; }
        public DateTime? DateWarmCallChanged { get; set; }
        public string ReshedulingVerified { get; set; }
        public string OrderRecievedBy { get; set; }
        public string OrderPono { get; set; }
        public decimal? OrderPovalue { get; set; }
        public string Isclose { get; set; }
        public string DemoReasonCode { get; set; }
        public string NextAction { get; set; }
        public DateTime? NextActionDateTime { get; set; }
        public string OutcomeCode { get; set; }
        public long? EmailCount { get; set; }
        public long? VisitCount { get; set; }
        public string TotalHoursSpent { get; set; }
        public string PrebidAssignedTo { get; set; }
        public string CallCloseReason { get; set; }
        public string CallCloseDetails { get; set; }
        public string OrderRegradeReason { get; set; }
        public string OrderRegradeReasonDetails { get; set; }
        public string QuotationAssignedTo { get; set; }
        public string QuotationStatus { get; set; }
        public string QuotationRequest { get; set; }
        public string CallRatingChangeReason { get; set; }
        public decimal? ExpectedValue { get; set; }
        public DateTime? ExpectedCloserDate { get; set; }
        public DateTime? DemoCompleteDatetime { get; set; }
        public DateTime? PrebidCompleteDatetime { get; set; }
        public decimal OverdueDays { get; set; }
        public string EmailMsgId { get; set; }
        public string CallAgainReason { get; set; }
        public string CallRescheduleReason { get; set; }
        public string SoheaderId { get; set; }
        public decimal CustomerBudget { get; set; }
        public string CustomerBudgetSanctioned { get; set; }
        public int Points { get; set; }
        public string Alias { get; set; }
        public int OrderLostFlag { get; set; }
        public int OrderRegretFlag { get; set; }
        public int CallCloseWihoutOrderFlag { get; set; }
        public int CallLife { get; set; }
        public int CallType { get; set; }
        public string PresalesSupportDocId { get; set; }
        public string PresalesSupportStatus { get; set; }
        public DateTime PscompletedDatetime { get; set; }
        public string PresalesSupportedBy { get; set; }
        public string ContactId { get; set; }
        public string OrderRegrteApprover { get; set; }
        public string OrderLostApprover { get; set; }
        public string CallCloseApprover { get; set; }
        public decimal? DueDays { get; set; }
        public int RescheduleCount { get; set; }
        public string Compaign { get; set; }
        public int MaxDaysReschedule { get; set; }
        public int ExpectedClosureDaysRescheduled { get; set; }
        public int? IsReminderSent { get; set; }
        public string AppoinmentTransferReasonId { get; set; }
        public string FkplantId { get; set; }
        public string ChannelId { get; set; }
        public string AssignToChannelId { get; set; }
        public string ChannelSeid { get; set; }
        public int PriviousRating { get; set; }
        public int HighestRating { get; set; }
        public bool? AssignTochannel { get; set; }
        public string CustomerVisitAssignedTo { get; set; }
        public DateTime CustomerVisitDateTime { get; set; }
        public string EmpReferenceId { get; set; }
        public string OrderTypeMasterId { get; set; }
        public string Boeid { get; set; }
        public string Currency { get; set; }
        public decimal Pbt { get; set; }
        public decimal Pat { get; set; }
        public decimal Network { get; set; }
        public decimal Borrowings { get; set; }
        public string Rating { get; set; }
        public string ParticipateInSyndications { get; set; }
        public string PrepaymentSecuterization { get; set; }
        public string Ipfb { get; set; }
        public string Icp { get; set; }
        public string ManagementComments { get; set; }
        public string CurrencyValue { get; set; }
        public string IsNoGstin { get; set; }
        public string Campaign { get; set; }
        public string DurationOfClass { get; set; }
        public string PrefferedTutor { get; set; }
        public string IdeaAboutPayment { get; set; }
        public string NoOfDaysInWeek { get; set; }
        public string PrefferedTime { get; set; }
        public string PrefferedTimeTo { get; set; }
        public DateTime? CallReviewDate { get; set; }
        public string CallNo { get; set; }
        public string ApplicationNo { get; set; }
        public string DocHouserId { get; set; }
        public string ExgsavAcno { get; set; }
        public string Fdrdacno { get; set; }
        public decimal? DisbursedVal { get; set; }
        public string Tenure { get; set; }
        public string ProcessedAs { get; set; }
        public string ProposalNo { get; set; }
    }
}
