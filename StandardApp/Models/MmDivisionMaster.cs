using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmDivisionMaster
    {
        public string DivisionId { get; set; }
        public string RegionalId { get; set; }
        public string DivisionCd { get; set; }
        public string DivisionName { get; set; }
        public string Designation { get; set; }
        public string FunctionArea { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
