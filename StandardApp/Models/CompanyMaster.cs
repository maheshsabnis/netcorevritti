using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CompanyMaster
    {
        public string CompanyId { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ActiveImage { get; set; }
        public string Remarks { get; set; }
    }
}
