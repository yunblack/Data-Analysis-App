using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartDirector;

namespace CSharpChartExplorer
{
    public class threedscattergroups //: DemoModule
    {
        //Name of demo module
        public string getName() { return "3D Scatter Groups"; }

        //Number of charts produced in this demo module
        public int getNoOfCharts() { return 1; }

        //Main code for creating chart.
        //Note: the argument chartIndex is unused because this demo only has 1 chart.
        public void createChart(WinChartViewer viewer, int chartIndex)
        {
            // getSeries2(int len, double startValue, double mindelta, double maxdelta)


            // The random XYZ data for the first 3D scatter group
            //빨강
            RanSeries r0 = new RanSeries(1);
            double[] xData0 = { 0, 0, 0, 0 };//r0.getSeries2(10, 10, -10, 10);
            // 첫번째 값은 
            double[] yData0 =  { 0, 0, 0, 0 };//r0.getSeries2(10, 0, 0, 20);
            double[] zData0 =  { 0, 0, 0, 0 };//r0.getSeries2(10, 10, -10, 10);
            //double[] xData0 = r0.getSeries2(20, 1, 0, 0); // X축
            //double[] yData0 = r0.getSeries2(20, 1, 0, 0); // y축
            //double[] zData0 = r0.getSeries2(20, 1, 0, 0); // z축



            // The random XYZ data for the second 3D scatter group
            //초록
            RanSeries r1 = new RanSeries(1);
            double[] xData1 = { 100, 100, 100, 100 };
            double[] yData1 = { 100, 100, 100, 100 };
            double[] zData1 = { 100, 100, 100, 100 };


            // The random XYZ data for the third 3D scatter group
            //파랑
            RanSeries r2 = new RanSeries(1);
            double[] xData2 = { 50, 50, 50, 50 };
            double[] yData2 = { 50, 50, 50, 50 };
            double[] zData2 = { 50, 50, 50, 50 };

            // Create a ThreeDScatterChart object of size 800 x 520 pixels
            ThreeDScatterChart c = new ThreeDScatterChart(500, 300);

            // Add a title to the chart using 20 points Times New Roman Italic font
            c.addTitle("3D Scatter Groups", "Times New Roman Italic", 20);

            // Set the center of the plot region at (350, 240), and set width x depth x height to
            // 360 x 360 x 270 pixels
            c.setPlotRegion(210, 144, 216, 216, 144);// 차트 크기조절

            // Set the elevation and rotation angles to 15 and 30 degrees
            c.setViewAngle(15, 30);

            // Add a legend box at (640, 180)
            c.addLegend(400, 180);//그룹박스 위치

            // Add 3 scatter groups to the chart with 9 pixels glass sphere symbols of red (ff0000),
            // green (00ff00) and blue (0000ff) colors
            c.addScatterGroup(xData0, yData0, zData0, "Alpha", Chart.GlassSphere2Shape, 0, 0xff0000); // 8은 좌표에 표시되는 점 크기 표시
            c.addScatterGroup(xData1, yData1, zData1, "Beta", Chart.GlassSphere2Shape, 0, 0x00ff00);
            c.addScatterGroup(xData2, yData2, zData2, "Gamma", Chart.GlassSphere2Shape, 8, 0x0000ff);

            
            

            // Set the x, y and z axis titles
            c.xAxis().setTitle("X-Axis Place Holder 가");
            c.yAxis().setTitle("Y-Axis Place Holder 나");
            c.zAxis().setTitle("Z-Axis Place Holder 다");
            
            // Output the chart
            viewer.Chart = c;
        }
    }
}