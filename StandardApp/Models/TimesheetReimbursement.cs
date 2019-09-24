﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TimesheetReimbursement
    {
        public Guid TimesheetReimbursementId { get; set; }
        public string TimesheetId { get; set; }
        public string Mode { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public decimal? Exp1 { get; set; }
        public decimal? Exp2 { get; set; }
        public decimal? Exp3 { get; set; }
        public decimal? Exp4 { get; set; }
        public decimal? Exp5 { get; set; }
        public decimal? Exp6 { get; set; }
        public decimal? Exp7 { get; set; }
        public decimal? Exp8 { get; set; }
        public decimal? Exp9 { get; set; }
        public decimal? Exp10 { get; set; }
        public decimal? Total { get; set; }
        public string ClaimDetailId { get; set; }
        public string ProjectId { get; set; }
        public string Distance { get; set; }
        public string SoheaderId { get; set; }
        public string IsclientReimbursement { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string SyncInfo { get; set; }
        public string UserMasterId { get; set; }
        public DateTime? Dt { get; set; }
    }
}
