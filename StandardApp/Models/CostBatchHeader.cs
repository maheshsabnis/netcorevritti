using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostBatchHeader
    {
        public string CostBatchHeaderId { get; set; }
        public string CostBatchCode { get; set; }
        public DateTime? CostBatchRunDt { get; set; }
        public DateTime? CostRateUpToDt { get; set; }
        public string PlantMasterId { get; set; }
        public string CostBatchDesc { get; set; }
        public string CostBatchRunBy { get; set; }
        public string Run { get; set; }
        public DateTime? PresTillDt { get; set; }
        public string Released { get; set; }
        public DateTime? ReleaseDt { get; set; }
        public string ReleasedBy { get; set; }
        public string ReleaseYear { get; set; }
        public string LatestCost { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
