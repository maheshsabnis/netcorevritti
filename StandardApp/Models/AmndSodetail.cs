using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AmndSodetail
    {
        public string AmndSodetailId { get; set; }
        public string AmndSoheaderId { get; set; }
        public string SeqNo { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public string PlantId { get; set; }
        public string WareHouseId { get; set; }
        public string ShipToId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Destination { get; set; }
        public string ConsigneeName { get; set; }
        public string Mobile { get; set; }
        public string ContactPerson { get; set; }
        public string Transporter { get; set; }
        public string TransporterAddress { get; set; }
        public string Forwarder { get; set; }
        public string InsuranceCompany { get; set; }
        public bool? SampleSubmission { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public string DeliveryTerms { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SodetailStatus { get; set; }
        public string UommasterId { get; set; }
        public decimal? NoOfPairs { get; set; }
        public decimal? NoOfPack { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? LineAmt { get; set; }
        public decimal? FlineAmt { get; set; }
        public decimal? LineTaxes { get; set; }
        public decimal? FlineTaxes { get; set; }
        public decimal? LineCharges { get; set; }
        public decimal? FlineCharges { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? FlineTotal { get; set; }
        public string Remark { get; set; }
    }
}
