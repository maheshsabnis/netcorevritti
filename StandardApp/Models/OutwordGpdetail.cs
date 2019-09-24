using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OutwordGpdetail
    {
        public string OutwordGpdetailId { get; set; }
        public string OutWordGpheaderId { get; set; }
        public string ItemMasterId { get; set; }
        public string ModetailId { get; set; }
        public decimal? ReqOgpqty { get; set; }
        public decimal? Ogpqty { get; set; }
        public decimal? NoOfBoxes { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string LotNo { get; set; }
        public string PartyId { get; set; }
        public string PartyName { get; set; }
        public string Remark { get; set; }
        public string ItemDesc { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? ReturnQty { get; set; }
    }
}
