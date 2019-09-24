using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OutwDocReg
    {
        public string DocRegId { get; set; }
        public string DocType { get; set; }
        public string DocCode { get; set; }
        public string From { get; set; }
        public DateTime? DispatchedDt { get; set; }
        public string DocCategory { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string DocNo { get; set; }
        public string To { get; set; }
        public string City { get; set; }
        public DateTime? DelieveredDt { get; set; }
        public bool? IsPodreq { get; set; }
        public bool? IsRetMaterial { get; set; }
        public string RetMaterialName { get; set; }
        public DateTime? ExpReturningDt { get; set; }
        public string Priority { get; set; }
        public DateTime? ExpDeliveryDt { get; set; }
        public string Status { get; set; }
        public string DeliveryMode { get; set; }
        public string CarrierId { get; set; }
    }
}
