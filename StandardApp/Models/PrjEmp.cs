using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PrjEmp
    {
        public string PrjEmpId { get; set; }
        public string ProjectId { get; set; }
        public string EmployeeId { get; set; }
        public string PrjRoleId { get; set; }
        public string IsPrimeController { get; set; }
        public string Isdeleted { get; set; }
    }
}
