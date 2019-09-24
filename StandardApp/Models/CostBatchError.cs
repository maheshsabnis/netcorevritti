using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostBatchError
    {
        public decimal CostBatchErrorId { get; set; }
        public string CostBatchHeaderId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ItemsId { get; set; }
        public decimal? CompId { get; set; }
        public decimal? RoutId { get; set; }
        public string CostRateId { get; set; }
        public string Error { get; set; }
    }
}
