using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserContactInfo
    {
        public int PkuserContactId { get; set; }
        public string UserMasterId { get; set; }
        public string Moblieno { get; set; }
        public string DeviceRegId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
