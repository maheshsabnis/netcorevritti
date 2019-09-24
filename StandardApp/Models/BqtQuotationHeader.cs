using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqtQuotationHeader
    {
        public string BqtQuotationHeaderId { get; set; }
        public string BqtEnquiryId { get; set; }
        public string QuotationNo { get; set; }
        public DateTime? EventFromDate { get; set; }
        public DateTime? EventToDate { get; set; }
        public string TimeSlot { get; set; }
        public string EventType { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public decimal? NoOfPersons { get; set; }
        public string MachineGroupMasterId { get; set; }
        public string BanquentClientId { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string HandledBy { get; set; }
        public string Status { get; set; }
        public string NextVersion { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Remarks { get; set; }
        public DateTime? QuotationDate { get; set; }
        public decimal? RatePerPerson { get; set; }
        public string WayOfCommunication { get; set; }
        public string EnquiryNo { get; set; }
        public string EnqStatus { get; set; }
        public string DocType { get; set; }
        public string TermsConditions { get; set; }
        public string Reference { get; set; }
        public decimal? GrossAmount { get; set; }
        public string PaymentTerms { get; set; }
        public string DeliveryTerms { get; set; }
        public string PayMode { get; set; }
        public string QuotValid { get; set; }
        public string Freight { get; set; }
        public decimal? BasicAmt { get; set; }
        public decimal? TotTaxAmt { get; set; }
        public decimal? TotChargeAmt { get; set; }
        public decimal? TotDiscAmt { get; set; }
        public decimal? NetAmt { get; set; }
        public string ContactPerson { get; set; }
        public string ContactMobile { get; set; }
        public string Currency { get; set; }
        public string PriceListId { get; set; }
        public decimal? ExRate { get; set; }
        public decimal? BasicAmtFc { get; set; }
        public decimal? TotTaxAmtFc { get; set; }
        public decimal? TotChargeAmtFc { get; set; }
        public decimal? TotDiscAmtFc { get; set; }
        public decimal? NetAmtFc { get; set; }
        public decimal? GrossAmountFc { get; set; }
        public string CallId { get; set; }
        public int RevisedQuote { get; set; }
        public decimal? Costperspot { get; set; }
        public decimal? Costpermonth { get; set; }
        public decimal? TotalCost { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public string RequisitionerId { get; set; }
    }
}
