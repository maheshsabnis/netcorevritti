using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Grnheader
    {
        public string GrnheaderId { get; set; }
        public string Grnno { get; set; }
        public DateTime? Grndt { get; set; }
        public string SupplierId { get; set; }
        public string GrntypeId { get; set; }
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
        public string GrnmodeId { get; set; }
        public string TranCode { get; set; }
        public string TranName { get; set; }
        public string TranFrom { get; set; }
        public string InverdNo { get; set; }
        public string LrNo { get; set; }
        public decimal? Freight { get; set; }
        public string FrPayCode { get; set; }
        public string RecdTime { get; set; }
        public string Grnstatus { get; set; }
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
        public decimal? GrnotherCharges { get; set; }
        public DateTime? InverdDt { get; set; }
        public decimal? GrntaxAmnt { get; set; }
        public decimal? GrnfreightAmnt { get; set; }
        public decimal? GrnpootherAmnt { get; set; }
        public decimal? GrnbasicAmnt { get; set; }
        public decimal? GrnpackingAmnt { get; set; }
        public decimal? GrngrossAmnt { get; set; }
        public decimal? GrninsBnkAmnt { get; set; }
        public string RefRecId { get; set; }
        public string RefRecType { get; set; }
        public string DocType { get; set; }
        public decimal? BillNoDigits { get; set; }
        public decimal? BasicAmnt { get; set; }
        public decimal? ChargeAmnt { get; set; }
        public decimal? BasicTaxAmnt { get; set; }
        public decimal? ChargeTaxAmnt { get; set; }
        public string Grntype { get; set; }
        public string SupervisorId { get; set; }
        public string InwDocRegId { get; set; }
        public decimal? TotalDiscntAmt { get; set; }
        public string ConsigneeId { get; set; }
        public DateTime? InverdTime { get; set; }
        public bool? SentSms { get; set; }
        public string ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public bool? SentMail { get; set; }
        public string FormAreno { get; set; }
        public DateTime? FormAredt { get; set; }
        public string Mreceivedby { get; set; }
        public string PutAwayStatus { get; set; }
        public string TatReasonId { get; set; }
        public string TatRemark { get; set; }
        public decimal? RoundOff { get; set; }
        public string Pono { get; set; }
    }
}
