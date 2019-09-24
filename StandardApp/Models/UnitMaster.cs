using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UnitMaster
    {
        public string UnitId { get; set; }
        public string ModuleId { get; set; }
        public string UnitName { get; set; }
        public string UnitDesc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Priority { get; set; }
        public string UserLoginId { get; set; }
        public string Remarks { get; set; }
        public string Active { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public int? Days { get; set; }
        public int? Hours { get; set; }
        public string IssuedTo { get; set; }
        public decimal? BillingAmt { get; set; }
        public string UnitTypeMasterId { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string IsDefaultUnit { get; set; }
        public string ClientId { get; set; }
        public string SourceId { get; set; }
        public string Prefix { get; set; }
    }
}
