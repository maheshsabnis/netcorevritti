using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesFamily
    {
        public string PksalesFamilyId { get; set; }
        public string CustVendorMstId { get; set; }
        public string FamilyCode { get; set; }
        public string FamilyDesc { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public decimal? UserLevel { get; set; }
        public decimal? CreationLevel { get; set; }
        public string IsActive { get; set; }
    }
}
