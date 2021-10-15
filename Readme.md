<!-- default badges list -->
Automatically generated badges
<!-- default badges end -->

# How to Create a Heatmap Based on Arrays of String and Numeric Values

This example shows how to use string and numeric value arrays to create a heatmap.

![Resulting heatmap](Images/resulting-heatmap.png)

To load array data to a heatmap, follow the steps below:

- Create a [HeatmapMatrixAdapter](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Heatmap.HeatmapMatrixAdapter?v=21.2) object. 

- Specify the following adapter properties:

    - [XArguments](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Heatmap.HeatmapMatrixAdapter.XArguments?v=21.2)
    - [YArguments](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Heatmap.HeatmapMatrixAdapter.YArguments?v=21.2)
    - [Values](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Heatmap.HeatmapMatrixAdapter.Values?v=21.2)

- Assign the adapter object to the [HeatmapControl.DataAdapter](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.Heatmap.HeatmapControl.DataAdapter?v=21.2) property.

<!-- default file list -->
## Files to Look At

- [Form1.cs](./CS/Form1.cs) ([Form1.vb](./VB/Form1.vb))

<!-- default file list end -->

## Documentation

- [HeatmapControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.Heatmap.HeatmapControl?v=21.2&p=netframework)
- [HeatmapMatrixAdapter](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Heatmap.HeatmapMatrixAdapter?v=21.2)