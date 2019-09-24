﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SaleRetnChargeDtl
    {
        public string SaleRetnChargeDtlId { get; set; }
        public string SaleRetnHdrId { get; set; }
        public string ChrgMasterId { get; set; }
        public string CalcMethod { get; set; }
        public decimal? ChargeAmount { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? RatePercent { get; set; }
        public decimal? QtyValue { get; set; }
    }
}
