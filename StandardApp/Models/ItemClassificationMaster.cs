using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemClassificationMaster
    {
        public string ItemClassificationId { get; set; }
        public string ModuleName { get; set; }
        public string FormName { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ItmClsDesc { get; set; }
        public string Code { get; set; }
        public string Poopen { get; set; }
        public string UommasterId { get; set; }
        public string CodeMasterId { get; set; }
        public string PurAccNo { get; set; }
        public string SaleAccNo { get; set; }
        public string SectionId { get; set; }
        public string AssetAccNo { get; set; }
        public string ItmClassColor { get; set; }
        public string LotCodeId { get; set; }
        public string CalibCertiPrntProg { get; set; }
        public string AdditionalDesc { get; set; }
        public string ItemDescPrintPrgm { get; set; }
        public bool? ReqToolClsfn { get; set; }
        public string Sampletype { get; set; }
        public string IdentificationCodeType { get; set; }
        public decimal? RetentionPeroid { get; set; }
        public string Samplesizenature { get; set; }
        public decimal? Samplesize { get; set; }
        public string AllowSale { get; set; }
        public string AllowPurchase { get; set; }
        public string PifreqDays { get; set; }
        public string Alwaysusedtemplate { get; set; }
    }
}
