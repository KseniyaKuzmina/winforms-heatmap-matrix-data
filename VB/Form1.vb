Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Heatmap
Imports System.Drawing
Imports System.Windows.Forms

Namespace HeatmapMatrixData

    Public Partial Class Form1
        Inherits System.Windows.Forms.Form

        Public Sub New()
            Me.InitializeComponent()
            Dim dataAdapter As HeatmapMatrixAdapter = New HeatmapMatrixAdapter()
            dataAdapter.XArguments = New String() {"North", "South", "West", "East", "Central"}
            dataAdapter.YArguments = New String() {"Components", "Clothing", "Bikes", "Accessories"}
            dataAdapter.Values = New Double(,) {{21.3, 50.1, 63.2, 64.4, 33.4}, {32.3, 54.4, 81.3, 53.4, 54.9}, {60.3, 49.1, 42.6, 48.4, 65.4}, {45.3, 54.7, 70.3, 66.4, 56.6}}
            Me.heatmap.DataAdapter = dataAdapter
            Dim palette As Palette = New Palette("Custom") From {System.Drawing.Color.White, System.Drawing.Color.SkyBlue, System.Drawing.Color.DarkBlue}
            Dim colorProvider As HeatmapRangeColorProvider = New HeatmapRangeColorProvider() With {.Palette = palette, .ApproximateColors = True}
            colorProvider.RangeStops.Add(New HeatmapRangeStop(0, HeatmapRangeStopType.Percentage))
            colorProvider.RangeStops.Add(New HeatmapRangeStop(20, HeatmapRangeStopType.Absolute))
            colorProvider.RangeStops.Add(New HeatmapRangeStop(40, HeatmapRangeStopType.Absolute))
            colorProvider.RangeStops.Add(New HeatmapRangeStop(60, HeatmapRangeStopType.Absolute))
            colorProvider.RangeStops.Add(New HeatmapRangeStop(90, HeatmapRangeStopType.Absolute))
            colorProvider.RangeStops.Add(New HeatmapRangeStop(1, HeatmapRangeStopType.Percentage))
            Me.heatmap.ColorProvider = colorProvider
            Me.heatmap.Titles.Add(New HeatmapTitle With {.Text = "Sales by Categories"})
            Me.heatmap.Label.Visible = True
            Me.heatmap.Label.Pattern = "{V}"
        End Sub
    End Class
End Namespace
