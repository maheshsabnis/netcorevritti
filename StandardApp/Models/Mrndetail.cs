using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrndetail
    {
        public string MrndetailId { get; set; }
        public string MrnheaderId { get; set; }
        public string MisdetailId { get; set; }
        public string ItemMasterId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public decimal? Mrnqty { get; set; }
        public string LotNo { get; set; }
        public string UommasterId { get; set; }
        public string Ref { get; set; }
        public string Remark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? Rmdaqty { get; set; }
        public decimal? ActualMrnqty { get; set; }
        public decimal? NoOfPacket { get; set; }
        public string IsPacketAppl { get; set; }
        public string PacketMasterId { get; set; }
        public string PacketState { get; set; }
    }
}
