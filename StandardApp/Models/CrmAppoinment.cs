using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmAppoinment
    {
        public string PkappointmentId { get; set; }
        public string CallId { get; set; }
        public string ExecutiveId { get; set; }
        public DateTime? AppoinmentDatetime { get; set; }
        public bool? StatusFlag { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public int? IsTransfer { get; set; }
        public string AppoinmentTransferReasonId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
