namespace KoalaTea_Project_Root
{
    partial class FormFrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrontPage));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnDineIn_frontPage = new System.Windows.Forms.Button();
            this.main_Button_TakeOut = new System.Windows.Forms.Button();
            this.btnCheckIn_frontPage = new System.Windows.Forms.Button();
            this.btnLogOut_frontPage = new System.Windows.Forms.Button();
            this.btnEdit_frontPage = new System.Windows.Forms.Button();
            this.btnReserved_frontPage = new System.Windows.Forms.Button();
            this.gboxHeader_FrontPage = new System.Windows.Forms.GroupBox();
            this.panelFrontPage = new System.Windows.Forms.Panel();
            this.btnTakeOut_FormFrontPage = new System.Windows.Forms.Button();
            this.gboxHeader_FrontPage.SuspendLayout();
            this.panelFrontPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            resources.ApplyResources(this.lblMainMenu, "lblMainMenu");
            this.lblMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMainMenu.Name = "lblMainMenu";
            // 
            // btnDineIn_frontPage
            // 
            resources.ApplyResources(this.btnDineIn_frontPage, "btnDineIn_frontPage");
            this.btnDineIn_frontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnDineIn_frontPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDineIn_frontPage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDineIn_frontPage.Name = "btnDineIn_frontPage";
            this.btnDineIn_frontPage.UseVisualStyleBackColor = false;
            this.btnDineIn_frontPage.Click += new System.EventHandler(this.main_Button_DineIn_Click);
            // 
            // main_Button_TakeOut
            // 
            resources.ApplyResources(this.main_Button_TakeOut, "main_Button_TakeOut");
            this.main_Button_TakeOut.Name = "main_Button_TakeOut";
            // 
            // btnCheckIn_frontPage
            // 
            resources.ApplyResources(this.btnCheckIn_frontPage, "btnCheckIn_frontPage");
            this.btnCheckIn_frontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnCheckIn_frontPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn_frontPage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCheckIn_frontPage.Name = "btnCheckIn_frontPage";
            this.btnCheckIn_frontPage.UseVisualStyleBackColor = false;
            this.btnCheckIn_frontPage.Click += new System.EventHandler(this.main_Button_CheckIn_Click);
            // 
            // btnLogOut_frontPage
            // 
            resources.ApplyResources(this.btnLogOut_frontPage, "btnLogOut_frontPage");
            this.btnLogOut_frontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnLogOut_frontPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut_frontPage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogOut_frontPage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogOut_frontPage.Name = "btnLogOut_frontPage";
            this.btnLogOut_frontPage.UseVisualStyleBackColor = false;
            this.btnLogOut_frontPage.Click += new System.EventHandler(this.main_Button_Exit_Click);
            // 
            // btnEdit_frontPage
            // 
            resources.ApplyResources(this.btnEdit_frontPage, "btnEdit_frontPage");
            this.btnEdit_frontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnEdit_frontPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit_frontPage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit_frontPage.Name = "btnEdit_frontPage";
            this.btnEdit_frontPage.UseVisualStyleBackColor = false;
            this.btnEdit_frontPage.Click += new System.EventHandler(this.btnEdit_frontPage_Click);
            // 
            // btnReserved_frontPage
            // 
            resources.ApplyResources(this.btnReserved_frontPage, "btnReserved_frontPage");
            this.btnReserved_frontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnReserved_frontPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserved_frontPage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReserved_frontPage.Name = "btnReserved_frontPage";
            this.btnReserved_frontPage.UseVisualStyleBackColor = false;
            this.btnReserved_frontPage.Click += new System.EventHandler(this.main_Button_Reserved_Click);
            // 
            // gboxHeader_FrontPage
            // 
            resources.ApplyResources(this.gboxHeader_FrontPage, "gboxHeader_FrontPage");
            this.gboxHeader_FrontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.gboxHeader_FrontPage.Controls.Add(this.lblMainMenu);
            this.gboxHeader_FrontPage.Name = "gboxHeader_FrontPage";
            this.gboxHeader_FrontPage.TabStop = false;
            // 
            // panelFrontPage
            // 
            resources.ApplyResources(this.panelFrontPage, "panelFrontPage");
            this.panelFrontPage.BackColor = System.Drawing.Color.Transparent;
            this.panelFrontPage.Controls.Add(this.btnDineIn_frontPage);
            this.panelFrontPage.Controls.Add(this.btnTakeOut_FormFrontPage);
            this.panelFrontPage.Controls.Add(this.btnEdit_frontPage);
            this.panelFrontPage.Controls.Add(this.btnCheckIn_frontPage);
            this.panelFrontPage.Controls.Add(this.btnReserved_frontPage);
            this.panelFrontPage.Controls.Add(this.btnLogOut_frontPage);
            this.panelFrontPage.Name = "panelFrontPage";
            // 
            // btnTakeOut_FormFrontPage
            // 
            resources.ApplyResources(this.btnTakeOut_FormFrontPage, "btnTakeOut_FormFrontPage");
            this.btnTakeOut_FormFrontPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnTakeOut_FormFrontPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeOut_FormFrontPage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTakeOut_FormFrontPage.Name = "btnTakeOut_FormFrontPage";
            this.btnTakeOut_FormFrontPage.UseVisualStyleBackColor = false;
            this.btnTakeOut_FormFrontPage.Click += new System.EventHandler(this.btnTakeOut_FormFrontPage_Click);
            // 
            // FormFrontPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(76)))), ((int)(((byte)(43)))));
            this.CancelButton = this.btnLogOut_frontPage;
            this.Controls.Add(this.panelFrontPage);
            this.Controls.Add(this.gboxHeader_FrontPage);
            this.Controls.Add(this.main_Button_TakeOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFrontPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormFrontPage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFrontPage_FormClosing);
            this.Load += new System.EventHandler(this.FormFrontPage_Load);
            this.gboxHeader_FrontPage.ResumeLayout(false);
            this.gboxHeader_FrontPage.PerformLayout();
            this.panelFrontPage.ResumeLayout(false);
            this.panelFrontPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnDineIn_frontPage;
        private System.Windows.Forms.Button main_Button_TakeOut;
        private System.Windows.Forms.Button btnCheckIn_frontPage;
        private System.Windows.Forms.Button btnLogOut_frontPage;
        private System.Windows.Forms.Button btnEdit_frontPage;
        private System.Windows.Forms.Button btnReserved_frontPage;
        private System.Windows.Forms.GroupBox gboxHeader_FrontPage;
        private System.Windows.Forms.Button btnTakeOut_FormFrontPage;
        private System.Windows.Forms.Panel panelFrontPage;
    }
}