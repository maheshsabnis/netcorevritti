using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqtQuotationDtl
    {
        public string BqtQuotationDtlId { get; set; }
        public string BqtQuotationHeaderId { get; set; }
        public string MachineGroupMasterId { get; set; }
        public string TimeSlot { get; set; }
        public decimal? SeqNo { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public string PlantId { get; set; }
        public string WareHouseId { get; set; }
        public string QuotStatus { get; set; }
        public string UommasterId { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? LineAmt { get; set; }
        public decimal? FlineAmt { get; set; }
        public decimal? LineTaxes { get; set; }
        public decimal? FlineTaxes { get; set; }
        public decimal? LineCharges { get; set; }
        public decimal? FlineCharges { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? FlineTotal { get; set; }
        public string IsDeleted { get; set; }
        public string Remark { get; set; }
        public decimal? DiscPc { get; set; }
        public decimal? DiscAmount { get; set; }
        public string AdditionalDesc { get; set; }
        public decimal? BalQty { get; set; }
        public decimal? FdiscAmount { get; set; }
        public string ItemPurchaseGroupId { get; set; }
        public string QuotationType { get; set; }
        public string Comment { get; set; }
    }
}
