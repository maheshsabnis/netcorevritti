using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Momdefinition
    {
        public string Momid { get; set; }
        public string Momtitle { get; set; }
        public string ProjectMasterId { get; set; }
        public string Venue { get; set; }
        public string Duration { get; set; }
        public string MeetingTypeId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? DateOfMeeting { get; set; }
        public DateTime? FromTime { get; set; }
        public double? Momduration { get; set; }
        public DateTime? ToTime { get; set; }
        public string Agenda { get; set; }
        public string IsFinalMom { get; set; }
        public string MeetingTaker { get; set; }
        public DateTime? ActFromTime { get; set; }
        public DateTime? ActToTime { get; set; }
        public double? ActDuration { get; set; }
        public string CallId { get; set; }
    }
}
