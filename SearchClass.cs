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
    class SearchClass
    {
        public Main frm;
        public SearchClass(Main frm)
        {
            this.frm = frm;
            search();
        }

        public void search()
        {
            frm.dataGridView1.DataSource = null;

            if (frm.dataSearchColumns.Text == "All")
            {
                if(frm.textSearch.Text=="" || frm.textSearch.Text==" ")
                {
                    frm.dataGridView1.EnableHeadersVisualStyles = false;
                    Encoding encode = System.Text.Encoding.GetEncoding("ks_c_5601-1987");
                    string filePath = InsertCSV.file_path;
                    DataTable dt = new DataTable();
                    string[] lines = System.IO.File.ReadAllLines(filePath, encode);
                    if (lines.Length > 0)
                    {
                        //first line to create header
                        string firstLine = lines[0];
                        string[] headerLabels = firstLine.Split(',');
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
                }

                else
                {
                    frm.dataGridView1.EnableHeadersVisualStyles = false;
                    Encoding encode = System.Text.Encoding.GetEncoding("ks_c_5601-1987");
                    string filePath = InsertCSV.file_path;
                    DataTable dt = new DataTable();
                    string[] lines = System.IO.File.ReadAllLines(filePath, encode);
                    if (lines.Length > 0)
                    {
                        //first line to create header
                        string firstLine = lines[0];
                        string[] headerLabels = firstLine.Split(',');
                        foreach (string headerWord in headerLabels)
                        {
                            dt.Columns.Add(new DataColumn(headerWord));
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            
                            string[] dataWords = lines[i].Split(',');
                            if (lines[i].Contains(frm.textSearch.Text))
                            {
                                DataRow dr = dt.NewRow();
                            int columnIndex = 0;
                            foreach (string headerWord in headerLabels)
                            {
                                dr[headerWord] = dataWords[columnIndex++];
                            }
                            dt.Rows.Add(dr);
                            }
                            
                        }
                    }
                    if (dt.Rows.Count > 0)
                    {
                        frm.dataGridView1.DataSource = dt;
                    }
                }
            }

            // 지금 에러가 발생하는 부분, 데이터 바인딩 부분
            // 인덱스 0인 부분에서 오류가남, 숫자부분에서 문자 혹은 문자 부분에서 숫자를 작성하면 오류 발생.
            // 2020-02-16 오류 해결 완료

            else
            {

                frm.dataGridView1.EnableHeadersVisualStyles = false;
                Encoding encode = System.Text.Encoding.GetEncoding("ks_c_5601-1987");
                string filePath = InsertCSV.file_path;
                DataTable dt = new DataTable();
                string[] lines = System.IO.File.ReadAllLines(filePath, encode);
                if (lines.Length > 0)
                {
                    //first line to create header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    int x = Array.IndexOf(headerLabels, frm.dataSearchColumns.Text);
                    //For Data
                    int countX = 0;
                    bool okayCount = false;
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            
                            if ((dataWords[x]).Contains(frm.textSearch.Text))
                            {
                                dr[headerWord] = dataWords[columnIndex]+"";
                                columnIndex++;
                                okayCount = true;
                                countX++;
                            }
                            else
                            {
                                okayCount = false;
                            }

                           
                          
                        }
                        if (okayCount)
                        {
                            dt.Rows.Add(dr.ItemArray);
                        }
                        
                    }

                    
                }
                if (dt.Rows.Count > 0)
                {
                    frm.dataGridView1.DataSource = dt;
                }

            }
        }
    }

}
