using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTargetDetail
    {
        public string PktargetDetailId { get; set; }
        public string FktargetHeadId { get; set; }
        public string ExecutiveId { get; set; }
        public int? TargetMonth { get; set; }
        public decimal? TargetYear { get; set; }
        public decimal? TargetValue { get; set; }
        public string DisplayYear { get; set; }
        public DateTime DisplayDate { get; set; }
        public string ProductId { get; set; }
        public string SalesFamilyId { get; set; }
        public decimal? ActualValue { get; set; }
        public string TerritoryId { get; set; }
    }
}
