using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Misheader
    {
        public string MisheaderId { get; set; }
        public string Misno { get; set; }
        public DateTime? Misdt { get; set; }
        public string Mistype { get; set; }
        public string DeptMasterId { get; set; }
        public string StatusId { get; set; }
        public string IssuedBy { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string IsOgpcreated { get; set; }
        public string RecType { get; set; }
        public string RefRecType { get; set; }
        public string RefRecId { get; set; }
        public string Transporter { get; set; }
        public string VehicleNo { get; set; }
    }
}
