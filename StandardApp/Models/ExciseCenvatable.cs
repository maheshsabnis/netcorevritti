using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ExciseCenvatable
    {
        public decimal RecId { get; set; }
        public string ExciseCenvatableId { get; set; }
        public string ExciseCenvatableNo { get; set; }
        public string FinDivId { get; set; }
        public string EntityCode { get; set; }
        public string EntityName { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public string IsGta { get; set; }
        public string IsCenvatable { get; set; }
        public string IsGtacenvatable { get; set; }
        public string CenvatTaken { get; set; }
        public string StatusId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
