namespace DataAnalysis
{
    partial class VisualizationMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizationMode));
            this.chartViewer = new ChartDirector.WinChartViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.Graph_Panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.Graph_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartViewer
            // 
            this.chartViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.chartViewer.InitialImage = null;
            this.chartViewer.Location = new System.Drawing.Point(-1, -16);
            this.chartViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartViewer.Name = "chartViewer";
            this.chartViewer.Size = new System.Drawing.Size(1188, 757);
            this.chartViewer.TabIndex = 9;
            this.chartViewer.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Graph_Panel);
            this.panel1.Location = new System.Drawing.Point(259, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 714);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 44);
            this.panel2.TabIndex = 16;
            // 
            // btn02
            // 
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.ForeColor = System.Drawing.Color.White;
            this.btn02.Location = new System.Drawing.Point(1042, 531);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(133, 23);
            this.btn02.TabIndex = 1;
            this.btn02.TabStop = false;
            this.btn02.Text = "White Mode";
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.ForeColor = System.Drawing.Color.White;
            this.btn01.Location = new System.Drawing.Point(903, 531);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(133, 23);
            this.btn01.TabIndex = 0;
            this.btn01.TabStop = false;
            this.btn01.Text = "Dark Mode";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // Graph_Panel
            // 
            this.Graph_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Graph_Panel.Controls.Add(this.chartViewer);
            this.Graph_Panel.Controls.Add(this.btn01);
            this.Graph_Panel.Controls.Add(this.btn02);
            this.Graph_Panel.Location = new System.Drawing.Point(13, 15);
            this.Graph_Panel.Name = "Graph_Panel";
            this.Graph_Panel.Size = new System.Drawing.Size(1188, 634);
            this.Graph_Panel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(23, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 714);
            this.panel3.TabIndex = 15;
            // 
            // VisualizationMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 0);
            this.Name = "VisualizationMode";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Visualization Mode";
            this.Load += new System.EventHandler(this.VisualizationMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Graph_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ChartDirector.WinChartViewer chartViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Graph_Panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
    }
}