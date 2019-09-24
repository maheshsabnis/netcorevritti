using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrtnProdDetail
    {
        public string CrtnProdDetailId { get; set; }
        public string CrtnProdHeaderId { get; set; }
        public string RecType { get; set; }
        public string CartonHeaderId { get; set; }
        public DateTime? CrtnProdPostDt { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public decimal? ProdQty { get; set; }
        public decimal? PostQty { get; set; }
        public decimal? RejQty { get; set; }
        public string RefType { get; set; }
        public string RefId { get; set; }
        public string StatusId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? QtyToPost { get; set; }
    }
}
