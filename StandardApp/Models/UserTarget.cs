using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserTarget
    {
        public string UserMasterId { get; set; }
        public string UserLoginId { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string HintQuestion { get; set; }
        public string Answer { get; set; }
        public string DeptMasterId { get; set; }
        public string LocationId { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string ExtNo { get; set; }
        public string Mobile { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string HighestQual { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string IsAdmin { get; set; }
        public string IsActive { get; set; }
        public string IsReportingUsingExcel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
