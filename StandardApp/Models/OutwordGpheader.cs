using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OutwordGpheader
    {
        public string OutWordGpheaderId { get; set; }
        public string GatePassNo { get; set; }
        public DateTime? GatePassDate { get; set; }
        public string OgptypeId { get; set; }
        public string DeptMasterId { get; set; }
        public string PoheaderId { get; set; }
        public string Lrno { get; set; }
        public string TransMode { get; set; }
        public string VehicleNo { get; set; }
        public string NameTrans { get; set; }
        public string AnnexNo { get; set; }
        public string Reason { get; set; }
        public decimal? TotalBoxes { get; set; }
        public decimal? TotalQty { get; set; }
        public string PartyId { get; set; }
        public string PartyName { get; set; }
        public string PreparedBy { get; set; }
        public string CheckedBy { get; set; }
        public string AuthorisedBy { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
    }
}
