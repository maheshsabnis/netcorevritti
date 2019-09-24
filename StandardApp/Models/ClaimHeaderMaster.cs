using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ClaimHeaderMaster
    {
        public Guid ClaimHeaderId { get; set; }
        public string ClaimCode { get; set; }
        public string Empid { get; set; }
        public string PlantId { get; set; }
        public string AuthorizedById { get; set; }
        public string Purpose { get; set; }
        public DateTime? Date { get; set; }
        public string TotalAmt { get; set; }
        public string AdvanceTaken { get; set; }
        public string Balance { get; set; }
        public string PaidAmount { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string SyncInfo { get; set; }
        public string Approved { get; set; }
        public string ActivityId { get; set; }
        public string Status { get; set; }
        public string ProjectId { get; set; }
        public bool? ClaimReimburse { get; set; }
        public string CostCtrMasterId { get; set; }
        public string CallId { get; set; }
        public string Type { get; set; }
        public string IsReimbursed { get; set; }
        public string IsClient { get; set; }
    }
}
