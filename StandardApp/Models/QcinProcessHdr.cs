using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class QcinProcessHdr
    {
        public string QcinProcessHdrId { get; set; }
        public string MoheaderId { get; set; }
        public string RoutOperationId { get; set; }
        public int? NoOfSamples { get; set; }
        public string ItmPlntId { get; set; }
        public string CertNo { get; set; }
        public string Specification { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string QcstatusId { get; set; }
        public bool? ActualQcentered { get; set; }
    }
}
