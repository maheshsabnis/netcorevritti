using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AuthRequest
    {
        public string PkauthRquestId { get; set; }
        public string FkuserMastId { get; set; }
        public string FktaskId { get; set; }
        public string FkapproverId { get; set; }
        public decimal CreationLevel { get; set; }
        public decimal UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDt { get; set; }
        public string RequStatus { get; set; }
    }
}
