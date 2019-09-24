using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Emp
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmailId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
