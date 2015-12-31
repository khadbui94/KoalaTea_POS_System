namespace KoalaTea_Project_Root.Admin
{
    partial class FormDisplayStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayStat));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack_Stat = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxHeader_Admin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gboxHeader_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack_Stat
            // 
            this.btnBack_Stat.AutoEllipsis = true;
            this.btnBack_Stat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnBack_Stat.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBack_Stat, "btnBack_Stat");
            this.btnBack_Stat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack_Stat.Name = "btnBack_Stat";
            this.btnBack_Stat.UseVisualStyleBackColor = false;
            this.btnBack_Stat.Click += new System.EventHandler(this.btnBack_Stat_Click);
            // 
            // chart1
            // 
            chartArea2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.BackImageTransparentColor = System.Drawing.SystemColors.ButtonFace;
            chartArea2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.chart1, "chart1");
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Product";
            this.chart1.Series.Add(series2);
            // 
            // gboxHeader_Admin
            // 
            resources.ApplyResources(this.gboxHeader_Admin, "gboxHeader_Admin");
            this.gboxHeader_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.gboxHeader_Admin.CausesValidation = false;
            this.gboxHeader_Admin.Controls.Add(this.btnBack_Stat);
            this.gboxHeader_Admin.Controls.Add(this.label1);
            this.gboxHeader_Admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.gboxHeader_Admin.ForeColor = System.Drawing.Color.White;
            this.gboxHeader_Admin.Name = "gboxHeader_Admin";
            this.gboxHeader_Admin.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormDisplayStat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gboxHeader_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDisplayStat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormDisplayStat_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDisplayStat_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gboxHeader_Admin.ResumeLayout(false);
            this.gboxHeader_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack_Stat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox gboxHeader_Admin;
        private System.Windows.Forms.Label label1;
    }
}