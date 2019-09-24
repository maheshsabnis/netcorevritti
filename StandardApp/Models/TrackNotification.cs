using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TrackNotification
    {
        public string PktrackNotifyId { get; set; }
        public string UserMasterId { get; set; }
        public string FknotifDtlsId { get; set; }
        public string Type { get; set; }
        public bool? FlagRead { get; set; }
        public DateTime? MarkDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
