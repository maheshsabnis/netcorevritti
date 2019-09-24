﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemParameter
    {
        public string ItemParameterId { get; set; }
        public string ItemMasterId { get; set; }
        public string ParameterId { get; set; }
        public string ParameterValue { get; set; }
        public string ConfigTypeId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
