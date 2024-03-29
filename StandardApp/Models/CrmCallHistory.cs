﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCallHistory
    {
        public string CallHistoryId { get; set; }
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
        public string HistoryNotes { get; set; }
        public DateTime? DemoCompleteDatetime { get; set; }
        public DateTime? PrebidCompleteDatetime { get; set; }
        public string EmailMsgId { get; set; }
        public string CallAgainReason { get; set; }
        public string CallRescheduleReason { get; set; }
        public string ChannelId { get; set; }
        public string AssignToChannelId { get; set; }
        public string ChannelSeid { get; set; }
        public string CustomerVisitAssignedTo { get; set; }
        public DateTime CustomerVisitDateTime { get; set; }
        public string OrderTypeMasterId { get; set; }
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
