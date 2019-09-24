using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class StkQchdr
    {
        public string StkQchdrId { get; set; }
        public string ItmPlntId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? Fifo { get; set; }
        public string CertNo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string QcstatusId { get; set; }
        public DateTime? PrntDt { get; set; }
        public string Sampletype { get; set; }
        public string IdentificationCodeType { get; set; }
        public decimal? RetentionPeroid { get; set; }
        public string Samplesizenature { get; set; }
        public decimal? Samplesize { get; set; }
        public string Mono { get; set; }
        public decimal? ApprovedQtyWithSample { get; set; }
        public string Prodqcno { get; set; }
    }
}
