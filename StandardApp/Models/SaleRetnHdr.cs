using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SaleRetnHdr
    {
        public string SaleRetnHdrId { get; set; }
        public string SaleRetnNo { get; set; }
        public DateTime? SaleRetnDate { get; set; }
        public string CustomerMasterId { get; set; }
        public string ShipToMasterId { get; set; }
        public string Destination { get; set; }
        public string ConsigneeName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string ContactPerson { get; set; }
        public string Awbno { get; set; }
        public string Transporter { get; set; }
        public string TransporterAddress { get; set; }
        public string Forwarder { get; set; }
        public string InsuranceCompany { get; set; }
        public string CustOrderPono { get; set; }
        public string QuotationNo { get; set; }
        public string CustomerRfpno { get; set; }
        public string Program { get; set; }
        public string OrderTypeMasterId { get; set; }
        public string CurrencyMasterId { get; set; }
        public string DeliveryTerms { get; set; }
        public string CreditTerm { get; set; }
        public decimal? CreditDays { get; set; }
        public decimal? TotalOrderValue { get; set; }
        public decimal? TotalOrderQty { get; set; }
        public bool? Mocreated { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SaleRetnStatus { get; set; }
        public string PlantMasterId { get; set; }
        public DateTime? CustOrderPodt { get; set; }
        public string Sotype { get; set; }
        public bool? IsReqMo { get; set; }
        public string DeliveryId { get; set; }
        public string NotifyId { get; set; }
        public string Comments { get; set; }
        public string RevisionNo { get; set; }
        public string RefRecType { get; set; }
        public string RefRecId { get; set; }
        public decimal? BasicAmt { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? GrossAmt { get; set; }
        public decimal? DiscAmt { get; set; }
        public decimal? DiscPer { get; set; }
        public string DiscType { get; set; }
        public decimal? Pccount { get; set; }
        public string BillToId { get; set; }
        public string OrderTypeId { get; set; }
        public string PriceListHdrId { get; set; }
        public string PriceListDtlId { get; set; }
        public decimal? TotTaxAmt { get; set; }
        public decimal? TotChargeAmt { get; set; }
        public decimal? TotDiscAmt { get; set; }
        public decimal? NetAmt { get; set; }
        public string RetnType { get; set; }
        public string Approver { get; set; }
        public DateTime? SaleExpectedDate { get; set; }
        public string Reason { get; set; }
    }
}
