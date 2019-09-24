using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmOasheader
    {
        public string OasmasterId { get; set; }
        public string Oasno { get; set; }
        public string CustomerOrderNo { get; set; }
        public string RefNo { get; set; }
        public string Sono { get; set; }
        public string SchemeName { get; set; }
        public string AgencyName { get; set; }
        public string Billinginformation { get; set; }
        public string ContactNoCustomer { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string BillinginfUser { get; set; }
        public string BillingCycle { get; set; }
        public DateTime? QuotationDate { get; set; }
        public decimal? QuotationAmount { get; set; }
        public string PreBidNo { get; set; }
        public DateTime? PreBidNoDate { get; set; }
        public string OrderreferBy { get; set; }
        public string OrderBy { get; set; }
        public string SpecialInstruction { get; set; }
        public string Reference { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
