using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ShipToMaster
    {
        public string ShipToMasterId { get; set; }
        public string CustomerId { get; set; }
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
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string Reftype { get; set; }
        public string RefId { get; set; }
        public string Addtype { get; set; }
        public string TaxClass { get; set; }
        public string StateMasterId { get; set; }
        public string Oms { get; set; }
        public string BillToAddress { get; set; }
        public bool? IsDefaultShipTo { get; set; }
        public bool? IsDefaultBillTo { get; set; }
        public bool? IsDefaultDeliv { get; set; }
        public bool? IsDefaultNotify { get; set; }
        public string PreCarrBy { get; set; }
        public string PlcRcptPreCarr { get; set; }
        public string PortLoad { get; set; }
        public string PortDischarge { get; set; }
        public string VesselNo { get; set; }
        public decimal? TransitLeadtime { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Distance { get; set; }
        public string RouteMasterId { get; set; }
        public string Gststate { get; set; }
        public string Gstcode { get; set; }
        public string GeoLocation { get; set; }
        public string Tanno { get; set; }
        public string TannoName { get; set; }
        public string Pan { get; set; }
        public string IsBlocked { get; set; }
        public string Rating { get; set; }
        public string EmailId { get; set; }
        public string TanGstinNumber { get; set; }
    }
}
