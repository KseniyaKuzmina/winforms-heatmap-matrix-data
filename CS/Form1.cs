using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Heatmap;
using System.Drawing;
using System.Windows.Forms;

namespace HeatmapMatrixData {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            HeatmapMatrixAdapter dataAdapter = new HeatmapMatrixAdapter();
            dataAdapter.XArguments = new string[] { "North", "South", "West", "East", "Central" };
            dataAdapter.YArguments = new string[] { "Components", "Clothing", "Bikes", "Accessories" };
            dataAdapter.Values = new double[,] {
                { 21.3, 50.1, 63.2, 64.4, 33.4 },
                { 32.3, 54.4, 81.3, 53.4, 54.9 },
                { 60.3, 49.1, 42.6, 48.4, 65.4 },
                { 45.3, 54.7, 70.3, 66.4, 56.6 }
            };
            heatmap.DataAdapter = dataAdapter;

            Palette palette = new Palette("Custom") {
                Color.White,
                Color.SkyBlue,
                Color.DarkBlue
            };

            HeatmapRangeColorProvider colorProvider = new HeatmapRangeColorProvider() {
                Palette = palette,
                ApproximateColors = true
            };
            colorProvider.RangeStops.Add(new HeatmapRangeStop(0, HeatmapRangeStopType.Percentage));
            colorProvider.RangeStops.Add(new HeatmapRangeStop(20, HeatmapRangeStopType.Absolute));
            colorProvider.RangeStops.Add(new HeatmapRangeStop(40, HeatmapRangeStopType.Absolute));
            colorProvider.RangeStops.Add(new HeatmapRangeStop(60, HeatmapRangeStopType.Absolute));
            colorProvider.RangeStops.Add(new HeatmapRangeStop(90, HeatmapRangeStopType.Absolute));
            colorProvider.RangeStops.Add(new HeatmapRangeStop(1, HeatmapRangeStopType.Percentage));

            heatmap.ColorProvider = colorProvider;

            heatmap.Titles.Add(new HeatmapTitle { Text = "Sales by Categories" });

            heatmap.Label.Visible = true;
            heatmap.Label.Pattern = "{V}";
        }
    }
}
