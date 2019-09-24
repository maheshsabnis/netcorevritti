using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTenderDetails
    {
        public string TenderDetailId { get; set; }
        public string CallId { get; set; }
        public string TenderNo { get; set; }
        public DateTime? TenderDt { get; set; }
        public string TenderFee { get; set; }
        public DateTime? PrebidDt { get; set; }
        public string PrebidTime { get; set; }
        public string SecurityDeposite { get; set; }
        public string Emdamount { get; set; }
        public DateTime? PurchaseDt { get; set; }
        public string PurchaseTime { get; set; }
        public string ModeofPayment { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addeddt { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddt { get; set; }
        public string IsDeleted { get; set; }
        public string IsActive { get; set; }
        public string SubmissionTime { get; set; }
        public DateTime? SubmissionDt { get; set; }
        public DateTime? RevisedDueDate { get; set; }
        public DateTime? DateofIssue { get; set; }
        public string CorrigendumNotes { get; set; }
        public string Pqreq { get; set; }
        public string TechCriteria { get; set; }
        public string TechNotes { get; set; }
        public string FinCriteria { get; set; }
        public string FinNotes { get; set; }
        public string AuthLetReq { get; set; }
        public string CorrigendumNo { get; set; }
        public string SdmodeofPayment { get; set; }
        public string EmdmodeofPayment { get; set; }
        public string QuotType { get; set; }
        public string OfferType { get; set; }
    }
}
