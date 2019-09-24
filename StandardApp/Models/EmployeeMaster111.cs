using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmployeeMaster111
    {
        public string EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string UserMasterId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string HighestQual { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
