using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class GininvHdr
    {
        public string GininvHdrId { get; set; }
        public string Ginno { get; set; }
        public DateTime? Gindt { get; set; }
        public string SupplierId { get; set; }
        public string GintypeId { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDt { get; set; }
        public string VehicleNo { get; set; }
        public string PartyDcno { get; set; }
        public DateTime? PartyDcdate { get; set; }
        public string OctroiCh { get; set; }
        public decimal? Octroi { get; set; }
        public string OurRef { get; set; }
        public string ExciseGp { get; set; }
        public decimal? ExciseAmt { get; set; }
        public DateTime? ExciseDt { get; set; }
        public string ModVat { get; set; }
        public bool? Printed { get; set; }
        public string GinmodeId { get; set; }
        public string TranCode { get; set; }
        public string TranName { get; set; }
        public string TranFrom { get; set; }
        public string InverdNo { get; set; }
        public string LrNo { get; set; }
        public decimal? Freight { get; set; }
        public string FrPayCode { get; set; }
        public string RecdTime { get; set; }
        public string Ginstatus { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string BillentryNo { get; set; }
        public DateTime? BillentryDate { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? GinotherCharges { get; set; }
        public DateTime? InverdDt { get; set; }
        public decimal? GinfreightAmnt { get; set; }
        public decimal? GinpootherAmnt { get; set; }
        public decimal? GinbasicAmnt { get; set; }
        public decimal? GindiscountAmnt { get; set; }
        public decimal? GinchargeAmnt { get; set; }
        public decimal? GinpackingAmnt { get; set; }
        public decimal? GintaxAmnt { get; set; }
        public decimal? GingrossAmnt { get; set; }
        public decimal? GininsBnkAmnt { get; set; }
        public string RefRecId { get; set; }
        public string RefRecType { get; set; }
        public string DocType { get; set; }
        public decimal? BillNoDigits { get; set; }
        public bool? CreditFor180Days { get; set; }
    }
}
