using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DatasheetActivityRelation
    {
        public string PkdsactId { get; set; }
        public string FkcssheaderId { get; set; }
        public string FkcssformQuestionDetails { get; set; }
        public string FkactivityId { get; set; }
    }
}
