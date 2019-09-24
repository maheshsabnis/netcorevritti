using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrpmodetail
    {
        public string MrpmodetailId { get; set; }
        public string MoheaderId { get; set; }
        public string ModetailId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ReqQty { get; set; }
        public DateTime? ReqAvailableDt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
