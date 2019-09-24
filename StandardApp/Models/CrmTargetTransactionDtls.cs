using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTargetTransactionDtls
    {
        public string PktargetDetailId { get; set; }
        public string FktargetHeadId { get; set; }
        public string PeriodId { get; set; }
        public string PeriodDescription { get; set; }
        public string ExecutiveId { get; set; }
        public string ProductId { get; set; }
        public string SalesFamilyId { get; set; }
        public string TerritoryId { get; set; }
        public string CustCategoryId { get; set; }
        public decimal? TargetValue { get; set; }
        public decimal? ActualValue { get; set; }
        public DateTime TarStartDate { get; set; }
        public DateTime TarEndDate { get; set; }
        public string Remarks { get; set; }
    }
}
