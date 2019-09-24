using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransporterMaster
    {
        public string TransporterMasterId { get; set; }
        public string Code { get; set; }
        public string TransporterName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Sms { get; set; }
        public string Mobile { get; set; }
        public string ContactPerson { get; set; }
        public string Awbno { get; set; }
        public string ForwarderMasterId { get; set; }
        public string InsuranceCompanyId { get; set; }
        public string PinCode { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string PlantMasterId { get; set; }
        public string Reftype { get; set; }
        public string RefId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string EmailId { get; set; }
    }
}
