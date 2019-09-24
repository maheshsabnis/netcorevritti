using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class GpexciseHeader
    {
        public string GpexciseHeaderId { get; set; }
        public string OutWordGpheaderId { get; set; }
        public string SrNo { get; set; }
        public DateTime? ChallanDt { get; set; }
        public string MaterialDesc { get; set; }
        public decimal? Quantity { get; set; }
        public string Uomid { get; set; }
        public decimal? TotalValue { get; set; }
        public string TarrifClassification { get; set; }
        public string IdentificationNo { get; set; }
        public string BondEntryNo { get; set; }
        public decimal? TarrifDuty { get; set; }
        public string ProcNature { get; set; }
        public string PartyName { get; set; }
        public string PartyAddress { get; set; }
        public DateTime? RemovalDate { get; set; }
        public string RemovalTime { get; set; }
        public string ModeOfTrans { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string StatusId { get; set; }
        public string PlantMasterId { get; set; }
    }
}
