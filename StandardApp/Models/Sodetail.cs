﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Sodetail
    {
        public string SodetailId { get; set; }
        public string SoheaderId { get; set; }
        public decimal? SeqNo { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public string PlantId { get; set; }
        public string WareHouseId { get; set; }
        public string ShipToId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Destination { get; set; }
        public string ConsigneeName { get; set; }
        public string Mobile { get; set; }
        public string ContactPerson { get; set; }
        public string Transporter { get; set; }
        public string TransporterAddress { get; set; }
        public string Forwarder { get; set; }
        public string InsuranceCompany { get; set; }
        public bool? SampleSubmission { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public string DeliveryTerms { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SodetailStatus { get; set; }
        public string UommasterId { get; set; }
        public decimal? NoOfPairs { get; set; }
        public decimal? NoOfPack { get; set; }
        public string TaxClassMasterId { get; set; }
        public decimal? LineAmt { get; set; }
        public decimal? FlineAmt { get; set; }
        public decimal? LineTaxes { get; set; }
        public decimal? FlineTaxes { get; set; }
        public decimal? LineCharges { get; set; }
        public decimal? FlineCharges { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? FlineTotal { get; set; }
        public string Remark { get; set; }
        public decimal? DiscPc { get; set; }
        public decimal? DiscAmount { get; set; }
        public string QuotationDtlId { get; set; }
        public decimal? FdiscAmount { get; set; }
        public decimal? OrgQty { get; set; }
        public decimal? RetQty { get; set; }
        public DateTime? Startdt { get; set; }
        public DateTime? Enddt { get; set; }
        public string WarrantyCode { get; set; }
        public string LicenseNo { get; set; }
        public string SuggLotNo { get; set; }
        public string PricePoint { get; set; }
        public string LabourChargeItemId { get; set; }
        public string ItemProcessId { get; set; }
        public string IsInsurancereqd { get; set; }
        public string ItemClassificationId { get; set; }
        public string SegmentId { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public DateTime? RecStartDate { get; set; }
        public DateTime? RecEndDate { get; set; }
        public decimal? RecurDaysCount { get; set; }
        public decimal? RecurWeeksCount { get; set; }
        public bool? IsSunday { get; set; }
        public bool? IsMonday { get; set; }
        public bool? IsTuesday { get; set; }
        public bool? IsWednesday { get; set; }
        public bool? IsThursday { get; set; }
        public bool? IsFriday { get; set; }
        public bool? IsSaturday { get; set; }
        public decimal? EveryMonthCount { get; set; }
        public decimal? MonthlyDayNo { get; set; }
        public decimal? MonthlyMonth { get; set; }
        public string MonthlyWeek { get; set; }
        public string MonthlyDay { get; set; }
        public decimal? RecurYearCount { get; set; }
        public string YearlyMonthName { get; set; }
        public string YearlyWeek { get; set; }
        public string YearlyDay { get; set; }
        public string YearlyMonth { get; set; }
        public string TypeOfPeriod { get; set; }
        public decimal? Occurrences { get; set; }
        public string IsNoEndDate { get; set; }
        public string IsProRata { get; set; }
        public string ProFigure { get; set; }
        public string ProUnit { get; set; }
        public string BillingCategoryId { get; set; }
        public DateTime? PeriodicEndDate { get; set; }
        public decimal? ItemSize { get; set; }
        public string RenewalStatus { get; set; }
        public decimal? InterestRate { get; set; }
        public string Merchantid { get; set; }
        public string Merchantname { get; set; }
        public decimal? NoOfHu { get; set; }
        public decimal? Poqty { get; set; }
        public string AllowPartShipment { get; set; }
    }
}
