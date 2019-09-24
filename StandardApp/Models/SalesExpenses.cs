using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesExpenses
    {
        public decimal SalesExpenseId { get; set; }
        public decimal? SalesMainId { get; set; }
        public decimal? ExpSrNo { get; set; }
        public string ExpDesc { get; set; }
        public decimal? CreditTo { get; set; }
        public decimal? ExpAmt { get; set; }
    }
}
