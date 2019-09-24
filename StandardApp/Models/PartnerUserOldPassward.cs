using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PartnerUserOldPassward
    {
        public string PkoldPassId { get; set; }
        public string FkuserId { get; set; }
        public string OldPassword { get; set; }
        public DateTime? OldPassDate { get; set; }
    }
}
