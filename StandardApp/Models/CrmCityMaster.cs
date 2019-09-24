using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCityMaster
    {
        public string PkcityId { get; set; }
        public string CityName { get; set; }
        public string FktalukaId { get; set; }
        public string FkdistrictId { get; set; }
        public string FkstateId { get; set; }
        public string FkcountryId { get; set; }
        public string PinCode { get; set; }
        public string FkterritoryId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
