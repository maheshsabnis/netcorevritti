using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmMaterialMovementMaster
    {
        public string PkmaterialmovementId { get; set; }
        public string DocumentNo { get; set; }
        public string FksenderId { get; set; }
        public string FkfromPlantId { get; set; }
        public string FktoPlantId { get; set; }
        public string FkfromLocationId { get; set; }
        public string FktoLocationId { get; set; }
        public string FktransporterId { get; set; }
        public string Problemidentify { get; set; }
        public string ReasonforTransfer { get; set; }
        public string FkrecipientId { get; set; }
        public string FkmodeofDeliveryId { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string FkfromWarehouseId { get; set; }
        public string FktoWarehouseId { get; set; }
        public DateTime? Date { get; set; }
        public string FkmodeofTransport { get; set; }
        public string Lrno { get; set; }
    }
}
