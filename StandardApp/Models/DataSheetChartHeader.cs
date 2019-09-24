using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DataSheetChartHeader
    {
        public DataSheetChartHeader()
        {
            DataSheetChartSeries = new HashSet<DataSheetChartSeries>();
        }

        public string PkchartHeaderId { get; set; }
        public string ChartTitle { get; set; }
        public string ChartDesc { get; set; }
        public string ChartType { get; set; }
        public string XseriesName { get; set; }
        public string YseriesName { get; set; }
        public string Xtitle { get; set; }
        public int? XtitleFontSize { get; set; }
        public string XtitleFontName { get; set; }
        public string XtitleFontColor { get; set; }
        public int? XnoofPlottings { get; set; }
        public string XrepeatStyle { get; set; }
        public string XaxisMax { get; set; }
        public string XaxisMin { get; set; }
        public string XmajorInterval { get; set; }
        public string XminorInterval { get; set; }
        public string Ytitle { get; set; }
        public int? YtitleFontSize { get; set; }
        public string YtitleFontName { get; set; }
        public string YtitleFontColor { get; set; }
        public string YaxisMax { get; set; }
        public string YaxisMin { get; set; }
        public string YmajorInterval { get; set; }
        public string LegendDocking { get; set; }
        public string LegendAlignment { get; set; }
        public bool? LegendDisabled { get; set; }
        public bool? LegendReversed { get; set; }
        public string LegendFontName { get; set; }
        public int? LegendFontSize { get; set; }
        public string LegendFontColor { get; set; }
        public int? TitleFontSize { get; set; }
        public string TitleFontColor { get; set; }
        public string TitleBorderColor { get; set; }
        public string TitleBackColor { get; set; }
        public string TitleAlignment { get; set; }
        public int? ChartAreaHeight { get; set; }
        public int? ChartAreaWidth { get; set; }
        public int? ChartAreaX { get; set; }
        public int? ChartAreaY { get; set; }
        public string ChartAreaGradient { get; set; }
        public int? PlotAreaX { get; set; }
        public int? PlotAreaY { get; set; }
        public int? PlotAreaHeight { get; set; }
        public int? PlotAreaWidth { get; set; }
        public string PlotAreaAlignment { get; set; }
        public string FkcssformsId { get; set; }
        public string ChartToolTip { get; set; }
        public string LegendStyle { get; set; }
        public string Gradient { get; set; }
        public string YminorInterval { get; set; }
        public string TitleFontName { get; set; }
        public string LegendBackColor { get; set; }
        public string GroupBy { get; set; }

        public virtual ICollection<DataSheetChartSeries> DataSheetChartSeries { get; set; }
    }
}
