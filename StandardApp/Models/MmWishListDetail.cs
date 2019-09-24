using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmWishListDetail
    {
        public string WldetailId { get; set; }
        public string WlheaderId { get; set; }
        public string ItemPlantId { get; set; }
        public string WlitemStatus { get; set; }
        public string WldetailRemark { get; set; }
        public decimal? WldetailRate { get; set; }
        public decimal? RequestedRate { get; set; }
        public decimal? RateDiscountPerc { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
