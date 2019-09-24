using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProjIncoExp
    {
        public string ProjIncoExpId { get; set; }
        public DateTime? TransDate { get; set; }
        public string Source { get; set; }
        public string Ref { get; set; }
        public string Description { get; set; }
        public string Entity { get; set; }
        public string Amount { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string UserName { get; set; }
    }
}
