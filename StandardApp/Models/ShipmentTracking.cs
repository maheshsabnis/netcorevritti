using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ShipmentTracking
    {
        public string PkrequestId { get; set; }
        public string RequestType { get; set; }
        public string VendorName { get; set; }
        public string CustomerAddress { get; set; }
        public string VendorAddress { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public decimal? Pincode { get; set; }
        public string ContactName { get; set; }
        public string RequisitionerPhoneNo { get; set; }
        public string RequisitionerMobileNo { get; set; }
        public string RequisitionerEmail { get; set; }
        public string VendorPhoneNo { get; set; }
        public string VendorMobileNo { get; set; }
        public string VendorEmail { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string CustomerMobileNo { get; set; }
        public string CustomerEmail { get; set; }
        public string MaterialDesc { get; set; }
        public decimal? NoOfPackage { get; set; }
        public decimal? Weight { get; set; }
        public string Pieces { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public DateTime? MaterialReadinessDate { get; set; }
        public DateTime? ExceptedDeliverydate { get; set; }
        public string ModeOfTransport { get; set; }
        public string Project { get; set; }
        public string Ledger { get; set; }
        public string ActivityCenter { get; set; }
        public string RequisitionerId { get; set; }
        public string PurposeOfRemoval { get; set; }
        public string MaterialMovement { get; set; }
        public string InwardNo { get; set; }
        public DateTime? AirwayBillDate { get; set; }
        public string AirwayBillNo { get; set; }
        public string PackgingRequired { get; set; }
        public string FreightForwarder { get; set; }
        public string SpecialInstructions { get; set; }
        public string PoNo { get; set; }
        public string CurrentStatgeId { get; set; }
        public string UnitId { get; set; }
        public string ActivityId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Addeddt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string RequisitionerNo { get; set; }
        public string IsDeleted { get; set; }
        public string GroupName { get; set; }
        public int? Quantity { get; set; }
        public string Contents { get; set; }
        public string Barcode { get; set; }
        public string CcontactName { get; set; }
        public string WorkFlowId { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }
        public string CustPin { get; set; }
        public string TrackNo { get; set; }
        public string Through { get; set; }
    }
}
