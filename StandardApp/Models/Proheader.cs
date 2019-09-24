using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Proheader
    {
        public string ProheaderId { get; set; }
        public string Prono { get; set; }
        public DateTime? Prodt { get; set; }
        public string SubContractorId { get; set; }
        public string CurrencyMasterId { get; set; }
        public string RefNo { get; set; }
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
        public string BillToId { get; set; }
        public string PaymentTermsId { get; set; }
        public string DeliveryTermsId { get; set; }
        public decimal? BasicAmnt { get; set; }
        public decimal? TaxAmnt { get; set; }
        public decimal? OtherCharges { get; set; }
        public decimal? TotalAmnt { get; set; }
        public string Comments { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
