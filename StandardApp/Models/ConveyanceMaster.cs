using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ConveyanceMaster
    {
        public Guid ConveyanceHeaderId { get; set; }
        public string ConveyanceCode { get; set; }
        public string Empid { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? AdvanceTaken { get; set; }
        public decimal? Balance { get; set; }
        public decimal? PaidAmount { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ProjectId { get; set; }
        public DateTime? Date { get; set; }
        public string ActivityId { get; set; }
    }
}
