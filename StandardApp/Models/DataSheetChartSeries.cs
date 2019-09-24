using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DataSheetChartSeries
    {
        public string PkchartSeriesId { get; set; }
        public string FkdataSheetChartHeader { get; set; }
        public string SeriesName { get; set; }
        public int? PointWidth { get; set; }
        public bool? Show3D { get; set; }
        public string Color { get; set; }
        public string Hatching { get; set; }
        public string Position { get; set; }
        public string FontName { get; set; }
        public int? FontSize { get; set; }
        public string FontColor { get; set; }
        public int? LabelAngle { get; set; }
        public string MarkerShape { get; set; }
        public int? MarkerSize { get; set; }
        public string MarkerColor { get; set; }
        public string MarkerBorderColor { get; set; }
        public string AxisPosition { get; set; }
        public string PrimaryBackColor { get; set; }
        public bool? ShowTarget { get; set; }
        public bool? DrawSeparateChartForEachDatasheet { get; set; }
        public string DataPointPosition { get; set; }
        public string DataPointFontName { get; set; }
        public int? DataPointFontSize { get; set; }
        public string DataPointFontColor { get; set; }
        public int? DataLabelAngle { get; set; }
        public bool? Selected { get; set; }
        public string PkquesId { get; set; }

        public virtual DataSheetChartHeader FkdataSheetChartHeaderNavigation { get; set; }
    }
}
