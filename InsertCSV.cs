using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace DataAnalysis
{
    
    class InsertCSV
    {
        public static String file_path = "";
        
        public Main frm;
        public InsertCSV(Main frm)
        {
            this.frm = frm;
            BindData();
        }

        private void BindData()
        {
            frm.dataGridView1.EnableHeadersVisualStyles = false;
     

            Encoding encode = System.Text.Encoding.GetEncoding("ks_c_5601-1987");
            string filePath = file_path;
            int x = 0;
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath, encode);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                x = headerLabels.Length;
                frm.dataSearchColumns.Text = "All";
                frm.dataSearchColumns.Items.AddRange(headerLabels);
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                frm.dataGridView1.DataSource = dt;
            }

          
            frm.dataInfo03.Text = x + "";
            frm.dataInfo04.Text = lines.Length+"";

        }
    }
}
