using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AmndSoheader
    {
        public string AmndSoheaderId { get; set; }
        public string Sono { get; set; }
        public DateTime? Sodate { get; set; }
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
        public string EmailId { get; set; }
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
        public string SoheaderStatus { get; set; }
        public string PlantMasterId { get; set; }
        public DateTime? CustOrderPodt { get; set; }
        public string Sotype { get; set; }
        public bool? IsReqMo { get; set; }
        public string DeliveryId { get; set; }
        public string NotifyId { get; set; }
        public string Approver { get; set; }
        public string SalesEngg { get; set; }
        public decimal? NoOfPersons { get; set; }
        public decimal? RatePerPerson { get; set; }
        public DateTime? EventFrmDt { get; set; }
        public DateTime? EventToDt { get; set; }
        public string TimeSlotId { get; set; }
        public string MachineGroupMasterId { get; set; }
        public string RefRecId { get; set; }
        public string RefRecType { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string RevisionNo { get; set; }
        public string Remarks { get; set; }
    }
}
