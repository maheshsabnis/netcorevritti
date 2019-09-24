using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Sdrheader
    {
        public string SdrheaderId { get; set; }
        public string Sdrno { get; set; }
        public DateTime? Sdrdt { get; set; }
        public string DeptMasteerId { get; set; }
        public string SdragainstId { get; set; }
        public string ProdetailId { get; set; }
        public string Remark { get; set; }
        public string AuthorisedById { get; set; }
        public string ApprovedById { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
