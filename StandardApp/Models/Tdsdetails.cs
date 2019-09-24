using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Tdsdetails
    {
        public decimal RecId { get; set; }
        public string TdsdetailsId { get; set; }
        public string TdsmasterId { get; set; }
        public string FinDivId { get; set; }
        public decimal? AmtRngFrom { get; set; }
        public decimal? AmtRngTo { get; set; }
        public decimal? Tdsper { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDt { get; set; }
    }
}
