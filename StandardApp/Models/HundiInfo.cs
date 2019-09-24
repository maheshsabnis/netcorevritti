using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class HundiInfo
    {
        public decimal RecId { get; set; }
        public string HundiInfoId { get; set; }
        public string LocentryId { get; set; }
        public string HundiNo { get; set; }
        public string BankRefNo { get; set; }
        public DateTime? BankRefDate { get; set; }
        public string AcceptanceToBank { get; set; }
        public DateTime? DueDate { get; set; }
        public string TransDetails { get; set; }
        public decimal? HundiAmount { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
