using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ChargeMaster
    {
        public decimal RecId { get; set; }
        public string ChrgMasterId { get; set; }
        public string ChrgCode { get; set; }
        public string ChrgDesc { get; set; }
        public string AccId { get; set; }
        public string SecId { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string LoadToInv { get; set; }
        public string SeperateAcc { get; set; }
        public string Hsnsaccode { get; set; }
        public string IsBank { get; set; }
    }
}
