using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Poschedule
    {
        public string PoscheduleId { get; set; }
        public string PodetailId { get; set; }
        public string IndentScheduleId { get; set; }
        public string ItemMasterId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public DateTime? PromisedDate { get; set; }
        public decimal? ScheduleQty { get; set; }
        public decimal? RecQty { get; set; }
        public decimal? RejectedQty { get; set; }
        public DateTime? FirstRecDate { get; set; }
        public decimal? NoOfRec { get; set; }
        public DateTime? LastRecDate { get; set; }
        public string Comments { get; set; }
        public string PoscheduleStatus { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
