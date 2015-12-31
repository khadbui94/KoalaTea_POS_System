namespace KoalaTea_Project_Root
{
    partial class FormLoginMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin_LoginMenu = new System.Windows.Forms.Button();
            this.gboxLogin_LoginMenu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName_LoginMenu = new System.Windows.Forms.Label();
            this.inputPassword_LoginMenu = new System.Windows.Forms.TextBox();
            this.inputUserName_LoginMenu = new System.Windows.Forms.TextBox();
            this.lblLogin_LoginMenu = new System.Windows.Forms.Label();
            this.btnExit_LoginMenu = new System.Windows.Forms.Button();
            this.gboxHeader_LoginMenu = new System.Windows.Forms.GroupBox();
            this.lblClock_Login = new System.Windows.Forms.Label();
            this.timerClock_Login = new System.Windows.Forms.Timer(this.components);
            this.lblDate_Login = new System.Windows.Forms.Label();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.timerLockOut = new System.Windows.Forms.Timer(this.components);
            this.gboxLogin_LoginMenu.SuspendLayout();
            this.gboxHeader_LoginMenu.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin_LoginMenu
            // 
            this.btnLogin_LoginMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin_LoginMenu.AutoSize = true;
            this.btnLogin_LoginMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnLogin_LoginMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_LoginMenu.ForeColor = System.Drawing.Color.White;
            this.btnLogin_LoginMenu.Location = new System.Drawing.Point(500, 329);
            this.btnLogin_LoginMenu.Name = "btnLogin_LoginMenu";
            this.btnLogin_LoginMenu.Size = new System.Drawing.Size(186, 78);
            this.btnLogin_LoginMenu.TabIndex = 0;
            this.btnLogin_LoginMenu.Text = "Login";
            this.btnLogin_LoginMenu.UseVisualStyleBackColor = false;
            this.btnLogin_LoginMenu.Click += new System.EventHandler(this.btnLogin_LoginMenu_Click);
            // 
            // gboxLogin_LoginMenu
            // 
            this.gboxLogin_LoginMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxLogin_LoginMenu.AutoSize = true;
            this.gboxLogin_LoginMenu.BackColor = System.Drawing.Color.Transparent;
            this.gboxLogin_LoginMenu.Controls.Add(this.label2);
            this.gboxLogin_LoginMenu.Controls.Add(this.lblUserName_LoginMenu);
            this.gboxLogin_LoginMenu.Controls.Add(this.inputPassword_LoginMenu);
            this.gboxLogin_LoginMenu.Controls.Add(this.inputUserName_LoginMenu);
            this.gboxLogin_LoginMenu.Controls.Add(this.btnLogin_LoginMenu);
            this.gboxLogin_LoginMenu.Location = new System.Drawing.Point(344, 235);
            this.gboxLogin_LoginMenu.Name = "gboxLogin_LoginMenu";
            this.gboxLogin_LoginMenu.Size = new System.Drawing.Size(703, 426);
            this.gboxLogin_LoginMenu.TabIndex = 1;
            this.gboxLogin_LoginMenu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(153, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // lblUserName_LoginMenu
            // 
            this.lblUserName_LoginMenu.AutoSize = true;
            this.lblUserName_LoginMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName_LoginMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName_LoginMenu.Location = new System.Drawing.Point(153, 38);
            this.lblUserName_LoginMenu.Name = "lblUserName_LoginMenu";
            this.lblUserName_LoginMenu.Size = new System.Drawing.Size(190, 42);
            this.lblUserName_LoginMenu.TabIndex = 3;
            this.lblUserName_LoginMenu.Text = "Username";
            // 
            // inputPassword_LoginMenu
            // 
            this.inputPassword_LoginMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword_LoginMenu.Location = new System.Drawing.Point(160, 221);
            this.inputPassword_LoginMenu.Name = "inputPassword_LoginMenu";
            this.inputPassword_LoginMenu.Size = new System.Drawing.Size(367, 49);
            this.inputPassword_LoginMenu.TabIndex = 2;
            this.inputPassword_LoginMenu.Click += new System.EventHandler(this.inputPassword_LoginMenu_Click);
            this.inputPassword_LoginMenu.Enter += new System.EventHandler(this.inputPassword_LoginMenu_Enter);
            // 
            // inputUserName_LoginMenu
            // 
            this.inputUserName_LoginMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUserName_LoginMenu.Location = new System.Drawing.Point(160, 93);
            this.inputUserName_LoginMenu.Name = "inputUserName_LoginMenu";
            this.inputUserName_LoginMenu.Size = new System.Drawing.Size(363, 49);
            this.inputUserName_LoginMenu.TabIndex = 1;
            this.inputUserName_LoginMenu.Click += new System.EventHandler(this.inputUserName_LoginMenu_Click);
            this.inputUserName_LoginMenu.Enter += new System.EventHandler(this.inputUserName_LoginMenu_Enter);
            // 
            // lblLogin_LoginMenu
            // 
            this.lblLogin_LoginMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin_LoginMenu.AutoSize = true;
            this.lblLogin_LoginMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin_LoginMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_LoginMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin_LoginMenu.Location = new System.Drawing.Point(545, 24);
            this.lblLogin_LoginMenu.Name = "lblLogin_LoginMenu";
            this.lblLogin_LoginMenu.Size = new System.Drawing.Size(267, 55);
            this.lblLogin_LoginMenu.TabIndex = 2;
            this.lblLogin_LoginMenu.Text = "User Login";
            // 
            // btnExit_LoginMenu
            // 
            this.btnExit_LoginMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit_LoginMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnExit_LoginMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_LoginMenu.ForeColor = System.Drawing.Color.White;
            this.btnExit_LoginMenu.Location = new System.Drawing.Point(1208, 686);
            this.btnExit_LoginMenu.Name = "btnExit_LoginMenu";
            this.btnExit_LoginMenu.Size = new System.Drawing.Size(146, 70);
            this.btnExit_LoginMenu.TabIndex = 3;
            this.btnExit_LoginMenu.Text = "Exit System";
            this.btnExit_LoginMenu.UseVisualStyleBackColor = false;
            this.btnExit_LoginMenu.Click += new System.EventHandler(this.btnExit_LoginMenu_Click);
            // 
            // gboxHeader_LoginMenu
            // 
            this.gboxHeader_LoginMenu.AutoSize = true;
            this.gboxHeader_LoginMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.gboxHeader_LoginMenu.Controls.Add(this.lblLogin_LoginMenu);
            this.gboxHeader_LoginMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxHeader_LoginMenu.Location = new System.Drawing.Point(0, 0);
            this.gboxHeader_LoginMenu.Name = "gboxHeader_LoginMenu";
            this.gboxHeader_LoginMenu.Size = new System.Drawing.Size(1366, 95);
            this.gboxHeader_LoginMenu.TabIndex = 4;
            this.gboxHeader_LoginMenu.TabStop = false;
            // 
            // lblClock_Login
            // 
            this.lblClock_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClock_Login.AutoSize = true;
            this.lblClock_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblClock_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock_Login.ForeColor = System.Drawing.Color.White;
            this.lblClock_Login.Location = new System.Drawing.Point(3, 60);
            this.lblClock_Login.Name = "lblClock_Login";
            this.lblClock_Login.Size = new System.Drawing.Size(216, 31);
            this.lblClock_Login.TabIndex = 5;
            this.lblClock_Login.Text = "Loading Time...";
            // 
            // timerClock_Login
            // 
            this.timerClock_Login.Enabled = true;
            this.timerClock_Login.Interval = 1000;
            this.timerClock_Login.Tick += new System.EventHandler(this.timerClock_Login_Tick);
            // 
            // lblDate_Login
            // 
            this.lblDate_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate_Login.AutoSize = true;
            this.lblDate_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblDate_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_Login.ForeColor = System.Drawing.Color.White;
            this.lblDate_Login.Location = new System.Drawing.Point(3, 21);
            this.lblDate_Login.Name = "lblDate_Login";
            this.lblDate_Login.Size = new System.Drawing.Size(214, 31);
            this.lblDate_Login.TabIndex = 6;
            this.lblDate_Login.Text = "Loading Date...";
            // 
            // panelDateTime
            // 
            this.panelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.panelDateTime.Controls.Add(this.lblClock_Login);
            this.panelDateTime.Controls.Add(this.lblDate_Login);
            this.panelDateTime.Location = new System.Drawing.Point(12, 665);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(406, 91);
            this.panelDateTime.TabIndex = 7;
            // 
            // timerLockOut
            // 
            this.timerLockOut.Interval = 18000;
            this.timerLockOut.Tick += new System.EventHandler(this.timerLockOut_Tick);
            // 
            // FormLoginMenu
            // 
            this.AcceptButton = this.btnLogin_LoginMenu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(76)))), ((int)(((byte)(43)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.gboxHeader_LoginMenu);
            this.Controls.Add(this.btnExit_LoginMenu);
            this.Controls.Add(this.gboxLogin_LoginMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoginMenu";
            this.Text = "Login Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLoginMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormLoginMenu_Load);
            this.gboxLogin_LoginMenu.ResumeLayout(false);
            this.gboxLogin_LoginMenu.PerformLayout();
            this.gboxHeader_LoginMenu.ResumeLayout(false);
            this.gboxHeader_LoginMenu.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.panelDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin_LoginMenu;
        private System.Windows.Forms.GroupBox gboxLogin_LoginMenu;
        private System.Windows.Forms.TextBox inputPassword_LoginMenu;
        private System.Windows.Forms.TextBox inputUserName_LoginMenu;
        private System.Windows.Forms.Label lblUserName_LoginMenu;
        private System.Windows.Forms.Label lblLogin_LoginMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit_LoginMenu;
        private System.Windows.Forms.GroupBox gboxHeader_LoginMenu;
        private System.Windows.Forms.Label lblClock_Login;
        private System.Windows.Forms.Timer timerClock_Login;
        private System.Windows.Forms.Label lblDate_Login;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Timer timerLockOut;
    }
}

