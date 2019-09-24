using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CartonHeader
    {
        public string CartonHeaderId { get; set; }
        public string CartonCode { get; set; }
        public DateTime? CartonDate { get; set; }
        public string CartonDesc { get; set; }
        public string CustomerId { get; set; }
        public decimal? NoOfPack { get; set; }
        public decimal? NoPackType { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? ProdQty { get; set; }
        public decimal? DispatchQty { get; set; }
        public string StatusId { get; set; }
        public string ShortingUnitNo { get; set; }
        public string CustOrderPono { get; set; }
        public string RefType { get; set; }
        public string RefId { get; set; }
        public string IsSomoqty { get; set; }
        public string Comments { get; set; }
    }
}
