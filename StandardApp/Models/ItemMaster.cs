using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemMaster
    {
        public string ItemMasterId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
        public string TechnicalDesc { get; set; }
        public string ItemClassificationId { get; set; }
        public string ItemGroupId { get; set; }
        public string ItemSubTypeId { get; set; }
        public string ItemTypeId { get; set; }
        public bool? Active { get; set; }
        public bool? SerialKeyRequired { get; set; }
        public string OtherInfo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ItemSysDesc { get; set; }
        public string ItemCodeIds { get; set; }
        public DateTime? StatusDate { get; set; }
        public string PositionCategoryId { get; set; }
        public string Ilength { get; set; }
        public string Ibreadth { get; set; }
        public string Area { get; set; }
        public string DisplayCode { get; set; }
        public string DrawingNo { get; set; }
        public bool? IsCustInventory { get; set; }
        public string ItemPhoto { get; set; }
        public string ItemFileName { get; set; }
        public string Useforfeature { get; set; }
        public string BoxTypeId { get; set; }
        public string ModelSize { get; set; }
        public string ModelNo { get; set; }
    }
}
