namespace KoalaTea_Project_Root
{
    partial class FormError
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
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.autoCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.panelErrorMessage = new System.Windows.Forms.Panel();
            this.panelErrorMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessage.Location = new System.Drawing.Point(173, 76);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(199, 24);
            this.lblErrorMessage.TabIndex = 0;
            this.lblErrorMessage.Text = "Error Message Here";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOne
            // 
            this.btnOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(396, 181);
            this.btnOne.Margin = new System.Windows.Forms.Padding(6);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(146, 70);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "Ok";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnTwo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(15, 181);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(6);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(146, 70);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "X";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // autoCloseTimer
            // 
            this.autoCloseTimer.Interval = 5000;
            this.autoCloseTimer.Tick += new System.EventHandler(this.autoCloseTimer_Tick);
            // 
            // panelErrorMessage
            // 
            this.panelErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.panelErrorMessage.Controls.Add(this.lblErrorMessage);
            this.panelErrorMessage.Location = new System.Drawing.Point(12, 12);
            this.panelErrorMessage.Name = "panelErrorMessage";
            this.panelErrorMessage.Size = new System.Drawing.Size(533, 146);
            this.panelErrorMessage.TabIndex = 3;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnTwo;
            this.ClientSize = new System.Drawing.Size(557, 266);
            this.Controls.Add(this.panelErrorMessage);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormError";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title Here";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FormError_Activated);
            this.Load += new System.EventHandler(this.FormError_Load);
            this.panelErrorMessage.ResumeLayout(false);
            this.panelErrorMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Timer autoCloseTimer;
        private System.Windows.Forms.Panel panelErrorMessage;
    }
}