using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WareHouseMaster
    {
        public string WareHouseMasterId { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDescription { get; set; }
        public string PlantId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string DivisionId { get; set; }
        public string Designation { get; set; }
        public string FunctionArea { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool? BackFlushing { get; set; }
        public string CustVendorMasterId { get; set; }
        public string WhmgrId { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string ConsigneeName { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string StateMasterId { get; set; }
        public string IsPlanning { get; set; }
        public string IsShipping { get; set; }
        public string IsReceived { get; set; }
        public string Whcountry { get; set; }
        public string Whcity { get; set; }
        public string Whstate { get; set; }
        public string Whaddress { get; set; }
        public string WhmgrMobile { get; set; }
        public string IsSubcontract { get; set; }
    }
}
