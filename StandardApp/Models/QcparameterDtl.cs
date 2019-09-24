using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class QcparameterDtl
    {
        public string QcparameterDtlId { get; set; }
        public string QcdetailId { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public string Qctype { get; set; }
        public string Code { get; set; }
        public string Qcdesc { get; set; }
        public decimal? BasicVal { get; set; }
        public string Bvuomid { get; set; }
        public decimal? MxTolrnc { get; set; }
        public string MxTolrncUom { get; set; }
        public decimal? MnTolrnc { get; set; }
        public string MnTolrncUom { get; set; }
        public string ObsrvVal { get; set; }
        public string Nogoval { get; set; }
        public string Goval { get; set; }
        public string ItemPlantId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? Fifo { get; set; }
        public decimal? MActVal { get; set; }
        public string OActVal { get; set; }
        public bool? Goact { get; set; }
        public bool? Nogoact { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Remark { get; set; }
        public string RefId { get; set; }
        public decimal? SeqNo { get; set; }
    }
}
