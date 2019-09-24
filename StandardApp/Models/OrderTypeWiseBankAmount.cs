using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OrderTypeWiseBankAmount
    {
        public string PkBankCollectionId { get; set; }
        public string BankMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string OrderTypeMasterId { get; set; }
        public decimal? CashAmount { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? Addeddt { get; set; }
    }
}
