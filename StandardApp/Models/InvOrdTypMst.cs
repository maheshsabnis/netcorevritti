using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class InvOrdTypMst
    {
        public string InvOrdTypMstId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string IndentCdGeneId { get; set; }
        public string PocdGeneId { get; set; }
        public string ProcdGeneId { get; set; }
        public string GrncdGeneId { get; set; }
        public string GincdGeneId { get; set; }
        public string SupgrncdGeneId { get; set; }
        public string QccdGeneId { get; set; }
        public string OgpcdGeneId { get; set; }
        public string StkAdjCdGeneId { get; set; }
        public string MtncdGeneId { get; set; }
        public string RmdacdGeneId { get; set; }
        public string AccdGeneId { get; set; }
        public string MrscdGeneId { get; set; }
        public string MiscdGeneId { get; set; }
        public string MrncdGeneId { get; set; }
        public string MrnrcdGeneId { get; set; }
        public string IndentPrntProg { get; set; }
        public bool? PrntApprIndent { get; set; }
        public string PoprntProg { get; set; }
        public bool? PrntApprPo { get; set; }
        public string ProprntProg { get; set; }
        public string GrnprntProg { get; set; }
        public string GinprntProg { get; set; }
        public string SupgrnprntProg { get; set; }
        public string QcprntProg { get; set; }
        public string OgpprntProg { get; set; }
        public string IndentApprWf { get; set; }
        public string PoapprWf { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string LotCdGeneId { get; set; }
        public string ImportExport { get; set; }
        public string IsProjectOrder { get; set; }
    }
}
