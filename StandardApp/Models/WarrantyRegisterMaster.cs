using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WarrantyRegisterMaster
    {
        public string PkwarrantyRegister { get; set; }
        public string WarrantyNo { get; set; }
        public string ShipToId { get; set; }
        public DateTime? ShipmentDt { get; set; }
        public string ItemPlantId { get; set; }
        public string SalesHeaderId { get; set; }
        public string BatchLot { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InstallDate { get; set; }
        public DateTime? SignOfDate { get; set; }
        public double? Amount { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? Date { get; set; }
        public string Branch { get; set; }
        public string WarrantyCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public DateTime? InvoiceDt { get; set; }
        public string IntimateCustomerEmailSms { get; set; }
        public DateTime? Fifo { get; set; }
        public string Remark { get; set; }
        public string ModeOfSupport { get; set; }
        public string IsApproved { get; set; }
        public DateTime? ApprovalDt { get; set; }
        public string ApprovalRemark { get; set; }
        public string ApprovedBy { get; set; }
        public string Version { get; set; }
        public string UsebyCustomer { get; set; }
        public string Mode { get; set; }
        public string IntimateEmailSmsto { get; set; }
        public string OtherEnviroment { get; set; }
        public string OtherEnvWarrantyId { get; set; }
        public string WarrantyStatus { get; set; }
        public string Ishosted { get; set; }
        public string Url { get; set; }
    }
}
