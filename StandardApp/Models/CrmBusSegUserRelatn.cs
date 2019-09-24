using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmBusSegUserRelatn
    {
        public string PkbusUserId { get; set; }
        public string FkbusiSegmentId { get; set; }
        public string FkuserMasterId { get; set; }
        public string IsDeleted { get; set; }
    }
}
