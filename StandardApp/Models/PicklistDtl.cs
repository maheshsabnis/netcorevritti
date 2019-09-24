using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PicklistDtl
    {
        public string PicklistDtlId { get; set; }
        public string PicklistHdrId { get; set; }
        public string SoScheduleId { get; set; }
        public decimal? QtyToPick { get; set; }
        public decimal? QtyPicked { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? NoofHu { get; set; }
        public string ItemMasterId { get; set; }
        public string MrsdetailId { get; set; }
        public string PickListType { get; set; }
    }
}
