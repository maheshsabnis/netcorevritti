using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProdOprtrDetail
    {
        public string ProdOprtrDetailId { get; set; }
        public string ProdEntryId { get; set; }
        public string EmployeeMasterId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
