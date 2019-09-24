using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VendorContractHeader
    {
        public string VendorContractHeaderId { get; set; }
        public string OrderTypeMasterId { get; set; }
        public string ContractNo { get; set; }
        public DateTime? ContractDt { get; set; }
        public string SupplierId { get; set; }
        public string Ref { get; set; }
        public string WareHouseMasterId { get; set; }
        public decimal? ExchRate { get; set; }
        public string Comments { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
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
        public string PayTermId { get; set; }
        public string DeliverTermsId { get; set; }
        public string ModeOfTransport { get; set; }
        public string MethodOfPackaging { get; set; }
        public string WarrantyTerms { get; set; }
        public string InsuranceDtl { get; set; }
        public string SpecialCondition { get; set; }
        public string PlantId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
