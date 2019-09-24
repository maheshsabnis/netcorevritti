﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProdetailTaxLine
    {
        public string ProdetailTaxLineId { get; set; }
        public string ProdetailId { get; set; }
        public string TaxMasterId { get; set; }
        public decimal? TaxPc { get; set; }
        public bool? Invoiced { get; set; }
        public string BaseAmountType { get; set; }
        public decimal? SeqNo { get; set; }
        public string LineNumber { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
