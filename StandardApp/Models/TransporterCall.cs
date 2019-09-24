using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransporterCall
    {
        public string TransporterCallId { get; set; }
        public string Vr { get; set; }
        public string Consignee { get; set; }
        public string Transporter { get; set; }
        public string VehicleType { get; set; }
        public DateTime? ReqDtTm { get; set; }
        public string Destination { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string Smsstatus { get; set; }
    }
}
