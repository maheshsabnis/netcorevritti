using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Forecast
    {
        public string ForecastId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ForecastDate { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ReqQtyinStkUnit { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? Confirm { get; set; }
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
        public bool? SetRecur { get; set; }
        public bool? ExSunday { get; set; }
        public bool? ExMonday { get; set; }
        public bool? ExTuesday { get; set; }
        public bool? ExWednesday { get; set; }
        public bool? ExThursday { get; set; }
        public bool? ExFriday { get; set; }
        public bool? ExSaturday { get; set; }
        public bool? ExHoliday { get; set; }
    }
}
