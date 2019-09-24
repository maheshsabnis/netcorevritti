using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MtrlTranNote
    {
        public string MtrlTranNoteId { get; set; }
        public string Mtnno { get; set; }
        public DateTime? Mtndt { get; set; }
        public string SrcItemMasterId { get; set; }
        public string SrcPlantMasterId { get; set; }
        public decimal? SrcTranQty { get; set; }
        public decimal? SrcTranRate { get; set; }
        public string SrcStockDetailId { get; set; }
        public string SrcWareHouseMasterId { get; set; }
        public string SrcLocationMasterId { get; set; }
        public string SrcUommasterId { get; set; }
        public string SrcLotNo { get; set; }
        public string DestItemMasterId { get; set; }
        public string DestPlantMasterId { get; set; }
        public decimal? DestTranQty { get; set; }
        public decimal? DestTranRate { get; set; }
        public string DestStockDetailId { get; set; }
        public string DestWareHouseMasterId { get; set; }
        public string DestLocationMasterId { get; set; }
        public string DestUommasterId { get; set; }
        public string DestLotNo { get; set; }
        public string Remark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string RecType { get; set; }
        public string RefRecType { get; set; }
        public string RefRecId { get; set; }
        public string PacketMasterId { get; set; }
        public string IsPacketAppl { get; set; }
        public bool? IsForStock { get; set; }
    }
}
