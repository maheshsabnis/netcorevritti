using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmWishListHeader
    {
        public string WlheaderId { get; set; }
        public string Wlnumber { get; set; }
        public DateTime? Wldate { get; set; }
        public DateTime? ReqContractFrom { get; set; }
        public DateTime? ReqContractTo { get; set; }
        public string CustomerId { get; set; }
        public string Wlstatus { get; set; }
        public DateTime? WlexpDt { get; set; }
        public string WlheaderRemark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Wlname { get; set; }
    }
}
