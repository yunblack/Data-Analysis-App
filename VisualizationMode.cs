using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpChartExplorer;
using ChartDirector;

namespace DataAnalysis
{
    public partial class VisualizationMode : MetroFramework.Forms.MetroForm
    {
        public VisualizationMode()
        {
            InitializeComponent();
        }

        private void VisualizationMode_Load(object sender, EventArgs e)
        {
            threedscatter2 th = new threedscatter2();
            chartViewer.Visible = true;

            for (int i = -1000; i < 1000; i++)
            {
                th.AddPointChart(chartViewer, i, i*i, i*i*i);
            }



            th.createChart(chartViewer, 1, 0, 1000);
        }

        private void btn01_Click(object sender, EventArgs e)
        {

        }
    }
}
