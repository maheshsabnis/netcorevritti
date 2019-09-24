using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ExciseHeading
    {
        public string ExciseHeadingId { get; set; }
        public string ItemType { get; set; }
        public string HeadingNo { get; set; }
        public string HeadingDesc { get; set; }
        public string SubHeadingNo { get; set; }
        public string SubHeadingDesc { get; set; }
        public decimal? AssessableRate { get; set; }
        public decimal? TarrifDuty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string DbktarrifHeadName { get; set; }
        public decimal? Dbkrate { get; set; }
    }
}
