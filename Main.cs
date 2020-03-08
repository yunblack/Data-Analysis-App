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
using System.IO;
using System.Data.OleDb;
using System.Globalization;


namespace DataAnalysis
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
            Main_Logo.BringToFront();
            openFileDialog1.FileName = "";

            //this.FormClosing += Main_FormClosing;
            this.ProgramNotifyIcon.MouseDoubleClick += ProgramNotifyIcon_MouseDoubleClick;
            this.ProgramExit.Click += ProgramExit_Click;
            this.ProgramOpen.Click += ProgramOpen_Click;

            this.ProgramView.Click += ProgramView_Click;
            this.ProgramModify.Click += ProgramModify_Click;
            this.ProgramCom.Click += ProgramCom_Click;
            this.ProgramVisual.Click += ProgramVisual_Click;
            this.ProgramAbout.Click += ProgramAbout_Click;
            this.ProgramPred.Click += ProgramPred_Click;
            this.ProgramImport.Click += ProgramImport_Click;


        }
        public bool isData = false;
        public string file_name = "";
        public string file_path = "";
        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Red Stone";
            TextSizeBar.Value = 9;
           
            Visual_Panel.BringToFront();

            Random rd = new Random();

          
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            this.Visible = false;
        }

        public void KoreanSetting()
        {

        }

        public void EnglishSetting()
        {

        }

        private void btnLabel01_Click(object sender, EventArgs e)
        {
            Btn01_Click(sender, e);
        }

        private void btnLabel02_Click(object sender, EventArgs e)
        {
            Btn02_Click(sender, e);
        }

        private void btnLabel03_Click(object sender, EventArgs e)
        {
            Btn03_Click(sender, e);
        }

        private void btnLabel04_Click(object sender, EventArgs e)
        {
            Btn04_Click(sender, e);
        }

        private void btnLabel05_Click(object sender, EventArgs e)
        {
            Btn05_Click(sender, e);
        }

        private void btnLabel06_Click(object sender, EventArgs e)
        {
            Btn06_Click(sender, e);
        }

        private void BtnOnAllFalse()
        {
            BtnOn01.Visible = false;
            BtnOn02.Visible = false;
            BtnOn03.Visible = false;
            BtnOn04.Visible = false;
            BtnOn05.Visible = false;
            BtnOn06.Visible = false;
            BtnOn07.Visible = false;
            BtnOn08.Visible = false;
            BtnOn09.Visible = false;
            BtnOn10.Visible = false;
            Main_Logo.Visible = false;
        }

        private void BtnLabelColorAll()
        {
            btnLabel01.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel02.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel03.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel04.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel05.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel06.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel07.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel08.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel09.ForeColor = Color.FromArgb(153, 153, 153);
            btnLabel10.ForeColor = Color.FromArgb(153, 153, 153);
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn01.Visible = true;
            BtnLabelColorAll();
            btnLabel01.ForeColor = Color.FromArgb(204, 51, 58);
            DataLoad_panel.BringToFront();
        }

        private void Btn02_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn02.Visible = true;
            BtnLabelColorAll();
            btnLabel02.ForeColor = Color.FromArgb(204, 51, 58);
            DataView_panel.BringToFront();
            if (isData == false)
            {
                Btn01_Click(sender, e);
                ErrorForm efrm = new ErrorForm();
                efrm.ShowDialog();
            }
        }
        

        private void Btn03_Click(object sender, EventArgs e)
        {

            BtnOnAllFalse();
            BtnOn03.Visible = true;
            BtnLabelColorAll();
            btnLabel03.ForeColor = Color.FromArgb(204, 51, 58);

            if (isData == false)
            {
                Btn01_Click(sender, e);
                NotSupport efrm = new NotSupport();
                efrm.ShowDialog();
            }
            else
            {
                ViewDetailMode frm = new ViewDetailMode();
                frm.ShowDialog();
            }
        }

        private void Btn04_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn04.Visible = true;
            BtnLabelColorAll();
            btnLabel04.ForeColor = Color.FromArgb(204, 51, 58);

            if (isData == false)
            {
                Btn01_Click(sender, e);
                NotSupport efrm = new NotSupport();
                efrm.ShowDialog();
            }
        }

        private void Btn05_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn05.Visible = true;
            BtnLabelColorAll();
            btnLabel05.ForeColor = Color.FromArgb(204, 51, 58);
            
            if (isData == false)
            {
                Btn01_Click(sender, e);
                ErrorForm efrm = new ErrorForm();
                efrm.ShowDialog();
            }
            else
            {
                Visual_Panel.BringToFront();
            }
        }

        private void Btn06_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn06.Visible = true;
            BtnLabelColorAll();
            btnLabel06.ForeColor = Color.FromArgb(204, 51, 58);

            if (isData == false)
            {
                Btn01_Click(sender, e);
                NotSupport efrm = new NotSupport();
                efrm.ShowDialog();
            }
        }

        private void btnLabel07_Click(object sender, EventArgs e)
        {
            Btn07_Click(sender, e);
        }

        private void btnLabel08_Click(object sender, EventArgs e)
        {
            Btn08_Click(sender, e);
        }

        private void btnLabel09_Click(object sender, EventArgs e)
        {
            Btn09_Click(sender, e);
        }

        private void btnLabel10_Click(object sender, EventArgs e)
        {
            Btn10_Click(sender, e);
        }

        private void Btn07_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn07.Visible = true;
            BtnLabelColorAll();
            btnLabel07.ForeColor = Color.FromArgb(204, 51, 58);
        }

        private void Btn08_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn08.Visible = true;
            BtnLabelColorAll();
            btnLabel08.ForeColor = Color.FromArgb(204, 51, 58);
        }

        private void Btn09_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn09.Visible = true;
            BtnLabelColorAll();
            btnLabel09.ForeColor = Color.FromArgb(204, 51, 58);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            BtnOnAllFalse();
            BtnOn10.Visible = true;
            BtnLabelColorAll();
            btnLabel10.ForeColor = Color.FromArgb(204, 51, 58);
            About_Panel.BringToFront();
        }

        private void FileLoadBtn_Click(object sender, EventArgs e)
        {
         
            LoadFileName.Text = "";
            String file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                LoadFileName.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                textBox1.Text = file_path;
                FilePathView.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                fileName= file_path.Split('\\')[file_path.Split('\\').Length - 1];
                this.file_path = file_path;
                Console.WriteLine(file_path);


            }
        }

        public static string fileName = "";
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textSearch.Text = dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[this.dataGridView1.CurrentCellAddress.X].FormattedValue.ToString();
        }

        private void DataLoad_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (FilePathView.Text =="" || FilePathView.Text == "File Name")
            {
                if (isData == false)
                {
                    Btn01_Click(sender, e);
                    ErrorForm efrm = new ErrorForm();
                    efrm.ShowDialog();
                }
            }
            else
            {
                this.dataSearchColumns.Items.Clear();
                this.dataSearchColumns.Items.Add("All");

                InsertCSV.file_path = this.file_path;
                dataInfo01.Text = fileName;
                dataInfo02.Text = "CSV";
                DataName_DataView.Text = fileName;
                InsertCSV frm = new InsertCSV(this);
                isData = true;
                dataInfo05.Text = "Done";

                this.dataGridView1.Font = new Font("Arial", 9, FontStyle.Regular);
                DataView_panel.Visible = true;
                // this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            // this.dataGridView1.Font = new Font("Tahoma", 2, FontStyle.Regular);
            /*
            this.dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Tahoma", 20, FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 2, FontStyle.Bold);
            this.dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 2, FontStyle.Bold);
            */
        }

        private void TextSizeBar_Scroll(object sender, ScrollEventArgs e)
        {
            textSize.Text = TextSizeBar.Value + " pt";
            this.dataGridView1.Font = new Font("Arial", TextSizeBar.Value, FontStyle.Regular);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SearchClass frm = new SearchClass(this);

        }

        private void ProgramNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
        }

        private void ProgramOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ProgramView_Click(object sender, EventArgs e)
        {
            Btn02_Click(sender, e);
            this.Show();
        }

        private void ProgramModify_Click(object sender, EventArgs e)
        {
            Btn03_Click(sender, e);
            this.Show();
        }

        private void ProgramVisual_Click(object sender, EventArgs e)
        {
            Btn05_Click(sender, e);
            this.Show();
        }

        private void ProgramCom_Click(object sender, EventArgs e)
        {
            Btn06_Click(sender, e);
            this.Show();
        }

        private void ProgramAbout_Click(object sender, EventArgs e)
        {
            Btn10_Click(sender, e);
            this.Show();
        }

        private void ProgramExit_Click(object sender, EventArgs e)
        {
            ProgramNotifyIcon.Visible = false;
            System.Environment.Exit(0);
        }

        private void ProgramPred_Click(object sender, EventArgs e)
        {
            Btn04_Click(sender, e);
            this.Show();
        }

        private void ProgramImport_Click(object sender, EventArgs e)
        {
            Btn01_Click(sender, e);
            this.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FilePathView_Click(object sender, EventArgs e)
        {

        }

        private void Opt01_Click(object sender, EventArgs e)
        {
            Opt02.Enabled = true;
            Opt01.Enabled = false;
            Opt02.ForeColor = Color.FromArgb(192, 0, 0);
            visionProtection = false;
            Opt01.ForeColor = Color.FromArgb(51, 51, 51);
            Opt01.BackColor = Color.FromArgb(102, 102, 102);
            Opt02.BackColor = Color.FromArgb(17, 17, 17);
            Opt03.Text = "Vision Protection Mode (On)";
            this.dataGridView1.BackgroundColor= Color.FromArgb(17, 17, 17);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(153, 153, 153);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(153, 153, 153);
        }

        private void Opt02_Click(object sender, EventArgs e)
        {
            Opt01.Enabled = true;
            Opt02.Enabled = false;
            Opt01.ForeColor = Color.FromArgb(192, 0, 0);
            visionProtection = false;
            Opt02.ForeColor = Color.FromArgb(51, 51, 51);
            Opt02.BackColor = Color.FromArgb(102, 102, 102);
            Opt01.BackColor = Color.FromArgb(17, 17, 17);
            Opt03.Text = "Vision Protection Mode (On)";
            this.dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
        }
        public static bool visionProtection = false;
        private void Opt03_Click(object sender, EventArgs e)
        {
            if (!Opt01.Enabled && !visionProtection)
            {
                this.dataGridView1.BackgroundColor = Color.FromArgb(17, 17, 17);
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
                this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 204, 102);
                this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
                this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 204, 102);
                visionProtection = true;
                Opt03.Text = "Vision Protection Mode (Off)";
            }
            else if (!Opt02.Enabled && !visionProtection)
            {
                this.dataGridView1.BackgroundColor = Color.FromArgb(255, 204, 153);
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 204, 153);
                this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 204, 153);
                this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

                visionProtection = true;
                Opt03.Text = "Vision Protection Mode (Off)";
            }
            else if (!Opt01.Enabled)
            {
                Opt01_Click(sender,e);
                visionProtection = false;
                Opt03.Text = "Vision Protection Mode (On)";
            }
            else if (!Opt02.Enabled)
            {
                Opt02_Click(sender, e);
                visionProtection = false;
                Opt03.Text = "Vision Protection Mode (On)";
            }

        }

        private void UpdateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void ViewModeBtn_Click(object sender, EventArgs e)
        {
            NotSupport frm = new NotSupport();
            frm.ShowDialog();
        }

        private void Visual_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
