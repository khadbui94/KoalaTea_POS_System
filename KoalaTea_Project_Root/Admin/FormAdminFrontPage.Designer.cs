namespace KoalaTea_Project_Root.Admin
{
    partial class FormAdminFrontPage
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
            this.btnAddItem_Admin = new System.Windows.Forms.Button();
            this.gboxContent_Admin = new System.Windows.Forms.GroupBox();
            this.btnAddEditPromo = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnEditDeleteItems = new System.Windows.Forms.Button();
            this.btnLogout_Admin = new System.Windows.Forms.Button();
            this.btnAddEmployee_Admin = new System.Windows.Forms.Button();
            this.gboxHeader_Admin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxContent_Admin.SuspendLayout();
            this.gboxHeader_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem_Admin
            // 
            this.btnAddItem_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnAddItem_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddItem_Admin.Location = new System.Drawing.Point(57, 50);
            this.btnAddItem_Admin.Name = "btnAddItem_Admin";
            this.btnAddItem_Admin.Size = new System.Drawing.Size(280, 192);
            this.btnAddItem_Admin.TabIndex = 0;
            this.btnAddItem_Admin.Text = "ADD MENU ITEMS";
            this.btnAddItem_Admin.UseVisualStyleBackColor = false;
            this.btnAddItem_Admin.Click += new System.EventHandler(this.btnEditItem_Admin_Click);
            // 
            // gboxContent_Admin
            // 
            this.gboxContent_Admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxContent_Admin.AutoSize = true;
            this.gboxContent_Admin.BackColor = System.Drawing.Color.Transparent;
            this.gboxContent_Admin.Controls.Add(this.btnAddEditPromo);
            this.gboxContent_Admin.Controls.Add(this.btnChart);
            this.gboxContent_Admin.Controls.Add(this.btnEditDeleteItems);
            this.gboxContent_Admin.Controls.Add(this.btnLogout_Admin);
            this.gboxContent_Admin.Controls.Add(this.btnAddEmployee_Admin);
            this.gboxContent_Admin.Controls.Add(this.btnAddItem_Admin);
            this.gboxContent_Admin.Location = new System.Drawing.Point(184, 124);
            this.gboxContent_Admin.Name = "gboxContent_Admin";
            this.gboxContent_Admin.Size = new System.Drawing.Size(1041, 548);
            this.gboxContent_Admin.TabIndex = 1;
            this.gboxContent_Admin.TabStop = false;
            // 
            // btnAddEditPromo
            // 
            this.btnAddEditPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnAddEditPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEditPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditPromo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEditPromo.Location = new System.Drawing.Point(380, 286);
            this.btnAddEditPromo.Name = "btnAddEditPromo";
            this.btnAddEditPromo.Size = new System.Drawing.Size(280, 192);
            this.btnAddEditPromo.TabIndex = 6;
            this.btnAddEditPromo.Text = "ADD/DELETE PROMO CODE";
            this.btnAddEditPromo.UseVisualStyleBackColor = false;
            this.btnAddEditPromo.Click += new System.EventHandler(this.btnAddEditPromo_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChart.Location = new System.Drawing.Point(57, 286);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(280, 192);
            this.btnChart.TabIndex = 5;
            this.btnChart.Text = "DISPLAY CHART";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnEditDeleteItems
            // 
            this.btnEditDeleteItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnEditDeleteItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDeleteItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDeleteItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditDeleteItems.Location = new System.Drawing.Point(380, 50);
            this.btnEditDeleteItems.Name = "btnEditDeleteItems";
            this.btnEditDeleteItems.Size = new System.Drawing.Size(280, 192);
            this.btnEditDeleteItems.TabIndex = 4;
            this.btnEditDeleteItems.Text = "EDIT/DELETE ITEMS";
            this.btnEditDeleteItems.UseVisualStyleBackColor = false;
            this.btnEditDeleteItems.Click += new System.EventHandler(this.btnEditDeleteItems_Click);
            // 
            // btnLogout_Admin
            // 
            this.btnLogout_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnLogout_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout_Admin.Location = new System.Drawing.Point(698, 286);
            this.btnLogout_Admin.Name = "btnLogout_Admin";
            this.btnLogout_Admin.Size = new System.Drawing.Size(280, 192);
            this.btnLogout_Admin.TabIndex = 3;
            this.btnLogout_Admin.Text = "Log Out";
            this.btnLogout_Admin.UseVisualStyleBackColor = false;
            this.btnLogout_Admin.Click += new System.EventHandler(this.btnLogout_Admin_Click);
            // 
            // btnAddEmployee_Admin
            // 
            this.btnAddEmployee_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnAddEmployee_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmployee_Admin.Location = new System.Drawing.Point(698, 50);
            this.btnAddEmployee_Admin.Name = "btnAddEmployee_Admin";
            this.btnAddEmployee_Admin.Size = new System.Drawing.Size(280, 192);
            this.btnAddEmployee_Admin.TabIndex = 1;
            this.btnAddEmployee_Admin.Text = "ADD/EDIT EMPLOYEE";
            this.btnAddEmployee_Admin.UseVisualStyleBackColor = false;
            this.btnAddEmployee_Admin.Click += new System.EventHandler(this.btnEditUser_Admin_Click);
            // 
            // gboxHeader_Admin
            // 
            this.gboxHeader_Admin.AutoSize = true;
            this.gboxHeader_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.gboxHeader_Admin.CausesValidation = false;
            this.gboxHeader_Admin.Controls.Add(this.label1);
            this.gboxHeader_Admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.gboxHeader_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxHeader_Admin.ForeColor = System.Drawing.Color.White;
            this.gboxHeader_Admin.Location = new System.Drawing.Point(0, 0);
            this.gboxHeader_Admin.Name = "gboxHeader_Admin";
            this.gboxHeader_Admin.Size = new System.Drawing.Size(1366, 86);
            this.gboxHeader_Admin.TabIndex = 2;
            this.gboxHeader_Admin.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration Menu";
            // 
            // FormAdminFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.gboxHeader_Admin);
            this.Controls.Add(this.gboxContent_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminFrontPage";
            this.Text = "FromAdminFrontPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormAdminFrontPage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminFrontPage_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminFrontPage_Load);
            this.gboxContent_Admin.ResumeLayout(false);
            this.gboxHeader_Admin.ResumeLayout(false);
            this.gboxHeader_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem_Admin;
        private System.Windows.Forms.GroupBox gboxContent_Admin;
        private System.Windows.Forms.Button btnAddEmployee_Admin;
        private System.Windows.Forms.GroupBox gboxHeader_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout_Admin;
        private System.Windows.Forms.Button btnEditDeleteItems;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnAddEditPromo;
    }
}