﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SuggPutAway
    {
        public string SuggPutAwayId { get; set; }
        public string GrndetailId { get; set; }
        public string LocationMasterId { get; set; }
        public decimal? PutAwayQty { get; set; }
        public string Status { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? PostedDate { get; set; }
    }
}
