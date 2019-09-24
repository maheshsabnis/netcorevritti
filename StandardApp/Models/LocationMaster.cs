using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class LocationMaster
    {
        public string LocationMasterId { get; set; }
        public string LocationCode { get; set; }
        public string LocationDesc { get; set; }
        public string WarehouseId { get; set; }
        public string LocationStatus { get; set; }
        public bool? Valid { get; set; }
        public decimal? LocationCapacity { get; set; }
        public string Uomid { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? ForRejMtrl { get; set; }
        public string LocationTypeId { get; set; }
        public string LocationRateCategoryId { get; set; }
        public string NegStockAllowed { get; set; }
        public bool? ForSbcmtrl { get; set; }
        public bool? ForBackFlush { get; set; }
        public string Aisle { get; set; }
        public string Bay { get; set; }
        public string Level { get; set; }
        public string Bin { get; set; }
        public bool? DockLoc { get; set; }
        public bool? StagingLoc { get; set; }
        public bool? BulkLoc { get; set; }
        public string OperationMasterId { get; set; }
        public string LocationWeight { get; set; }
    }
}
