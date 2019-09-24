using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class InwDocReg
    {
        public string DocRegId { get; set; }
        public string DocType { get; set; }
        public string DocCode { get; set; }
        public string RecdFrom { get; set; }
        public DateTime? RecdDt { get; set; }
        public string HandedOver { get; set; }
        public DateTime? HandedOn { get; set; }
        public string DocCategory { get; set; }
        public string GrnheaderId { get; set; }
        public string CreationLevel { get; set; }
        public string UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string DocNo { get; set; }
        public string Receipant { get; set; }
        public string TransferTo { get; set; }
        public string Status { get; set; }
    }
}
