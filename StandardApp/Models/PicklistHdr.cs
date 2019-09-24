using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PicklistHdr
    {
        public string PicklistHdrId { get; set; }
        public string PicklistNo { get; set; }
        public DateTime? PicklistDt { get; set; }
        public string PlantMasterId { get; set; }
        public string PicklistStatus { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string MtrlHandlerId { get; set; }
    }
}
