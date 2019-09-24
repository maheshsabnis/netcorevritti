using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Poheader
    {
        public string PoheaderId { get; set; }
        public string RevisionNo { get; set; }
        public bool? PurchaseProcess { get; set; }
        public string Pono { get; set; }
        public DateTime? Podt { get; set; }
        public string PlantId { get; set; }
        public string SupplierId { get; set; }
        public string BuyerId { get; set; }
        public string Ref { get; set; }
        public string DeptMasterId { get; set; }
        public string PayTermId { get; set; }
        public string DeliverTermsId { get; set; }
        public string CurrencyMasterId { get; set; }
        public decimal? ExchRate { get; set; }
        public string PriceTermsId { get; set; }
        public decimal? InsuBankCharges { get; set; }
        public decimal? PackagingCharges { get; set; }
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
        public string ModeOfTransport { get; set; }
        public string MethodOfPackaging { get; set; }
        public string SpecialCondition { get; set; }
        public decimal? Poamt { get; set; }
        public decimal? PotaxAmt { get; set; }
        public decimal? Pocharges { get; set; }
        public decimal? PototalAmt { get; set; }
        public decimal? Fpoamt { get; set; }
        public decimal? FpotaxAmt { get; set; }
        public decimal? Fpocharges { get; set; }
        public decimal? FpototalAmt { get; set; }
        public string Postatus { get; set; }
        public string Comments { get; set; }
        public string ImportExport { get; set; }
        public string Ct3no { get; set; }
        public string Pcno { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? FreightCharges { get; set; }
        public decimal? PackingCharges { get; set; }
        public decimal? InsuranceBankingCharges { get; set; }
        public decimal? Protype { get; set; }
        public string Ct3pc { get; set; }
        public string Cenvatno { get; set; }
        public DateTime? ApprovalDt { get; set; }
        public DateTime? ShortCloseDt { get; set; }
        public string ChrgGlidFreight { get; set; }
        public string ChrgGlidInsBnk { get; set; }
        public string ChrgGlidOther { get; set; }
        public string ChrgGlidPack { get; set; }
        public string CapexFormId { get; set; }
        public string EssDoc { get; set; }
        public string ItemClassificationId { get; set; }
        public string WarrantyTerms { get; set; }
        public string InsuranceDtl { get; set; }
        public string OrderTypeMasterId { get; set; }
        public decimal? DiscAmt { get; set; }
        public string PoType { get; set; }
        public string RouteName { get; set; }
        public string SegmentType { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public decimal? AdvancePaymentAmount { get; set; }
        public string AdvancePaymentReason { get; set; }
    }
}
