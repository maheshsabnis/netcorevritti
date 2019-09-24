using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DocApprDtl
    {
        public string DocApprDtlId { get; set; }
        public string DocApprHdrId { get; set; }
        public string UserMstId { get; set; }
        public string AppvLvl { get; set; }
        public string StatusId { get; set; }
        public DateTime? ApprDt { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
        public decimal? UserLevel { get; set; }
        public decimal? CreationLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
