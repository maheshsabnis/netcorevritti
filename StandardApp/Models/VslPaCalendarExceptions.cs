using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslPaCalendarExceptions
    {
        public string CalendarExceptionId { get; set; }
        public string CalendarId { get; set; }
        public DateTime? CalendarStartDate { get; set; }
        public DateTime? CalendarEndDate { get; set; }
        public string ExceptionName { get; set; }
        public string ExceptionTypeId { get; set; }
        public string IsWorking { get; set; }
        public string TypeOfPeriod { get; set; }
        public string Xmlinfo { get; set; }
        public string ClientId { get; set; }
        public string ResourceId { get; set; }
        public string ResourceType { get; set; }
        public string ResourceDesc { get; set; }
    }
}
