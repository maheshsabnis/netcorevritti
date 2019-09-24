using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmMaterialReceivedDtls
    {
        public string PkmaterialReceiveDtlId { get; set; }
        public string FkrecipientId { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public string Remarks { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string FkhandedOverId { get; set; }
        public string FktoLocationId { get; set; }
        public string ReceivedStatus { get; set; }
        public string FkmaterialmovementId { get; set; }
    }
}
