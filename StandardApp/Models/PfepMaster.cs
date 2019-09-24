using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PfepMaster
    {
        public string PfepMasterId { get; set; }
        public string IsLive { get; set; }
        public string PartNo { get; set; }
        public string AlternatPartNo { get; set; }
        public string FuturePartNo { get; set; }
        public string PartDesc { get; set; }
        public string PartCategory { get; set; }
        public string Spq { get; set; }
        public string ShopLine { get; set; }
        public string VendorCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string Model { get; set; }
        public string Usage { get; set; }
        public string UnloadingDockNo { get; set; }
        public string TransitLeadTime { get; set; }
        public string DlockRackNo { get; set; }
        public string DlocMinQty { get; set; }
        public string DlocMaxQty { get; set; }
        public string DlocStackHeight { get; set; }
        public string SecondaryLocation { get; set; }
        public string PullMethod { get; set; }
        public string NoOfUlock { get; set; }
        public string UlocLocationNumber { get; set; }
        public string UlocMinQty { get; set; }
        public string UlocMaxQty { get; set; }
        public string UlocstackHeight { get; set; }
        public string SupplyStrategyToBin { get; set; }
        public string KitSeqLocation { get; set; }
        public string SupplyStrategyToSeq { get; set; }
        public string KlocMinQty { get; set; }
        public string KlocMaxQty { get; set; }
        public string FollowScedulerCode { get; set; }
        public string Incoterms { get; set; }
        public string ModeOfShipment { get; set; }
        public string WeightOfParts { get; set; }
        public string PartLength { get; set; }
        public string PartWidth { get; set; }
        public string PartHeight { get; set; }
        public byte[] PartImage { get; set; }
        public string PrimaryContainerType { get; set; }
        public string PrimLength { get; set; }
        public string PrimWidth { get; set; }
        public string PrimHeight { get; set; }
        public string PrimQty { get; set; }
        public string ContainerWeight { get; set; }
        public string SecondaryContainerType { get; set; }
        public string SecContainerLength { get; set; }
        public string SecContainerWidth { get; set; }
        public string SecContainerHeight { get; set; }
        public string SecContainerQty { get; set; }
        public string SecContainerWeigth { get; set; }
        public string LineSide { get; set; }
        public string SecL { get; set; }
        public string SecW { get; set; }
        public string SecH { get; set; }
        public string Quantity { get; set; }
        public string LineLocationNumber { get; set; }
        public string PackagingType { get; set; }
        public string SchedulePakQty { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
        public string Remark { get; set; }
    }
}
