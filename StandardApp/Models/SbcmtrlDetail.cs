using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SbcmtrlDetail
    {
        public string SbcmtrlDetailId { get; set; }
        public string SoheaderId { get; set; }
        public string RecType { get; set; }
        public string RefRecType { get; set; }
        public string RefRecId { get; set; }
        public string ItemMasterId { get; set; }
        public string BomdetailId { get; set; }
        public string Uomid { get; set; }
        public decimal? ReqQty { get; set; }
        public decimal? RecQty { get; set; }
        public decimal? RetQty { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
