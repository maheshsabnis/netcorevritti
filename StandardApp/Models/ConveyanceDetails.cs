using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ConveyanceDetails
    {
        public Guid ConveyanceDetailId { get; set; }
        public Guid? ConveyanceHeaderId { get; set; }
        public DateTime? Dt { get; set; }
        public string ModuleMastId { get; set; }
        public string ProjectId { get; set; }
        public string ActivityId { get; set; }
        public decimal? Exp1 { get; set; }
        public decimal? Total { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ToLocation { get; set; }
    }
}
