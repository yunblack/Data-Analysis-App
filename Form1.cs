using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartDirector;

namespace CSharpChartExplorer
{
    public partial class Form1 : Form
    {
        
        threedscatter2 th = new threedscatter2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            th.createChart(chartViewer, 1, 0 , 100);
            chartViewer.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                chartViewer.updateViewPort(true, false);
            }
            else
                MessageBox.Show("값을 입력하세요");
        }

        private void chartViewer_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            th.AddPointChart(chartViewer, int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            th.createChart(chartViewer, 1, 0, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
