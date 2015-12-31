namespace KoalaTea_Project_Root.Admin
{
    partial class FormAddEditPromoCode
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
            this.labelTop = new System.Windows.Forms.Label();
            this.gboxHeader_Admin = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.txtBoxPromoCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.tblPromotionDataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.gboxHeader_Admin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPromotionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(453, 16);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(654, 55);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "ADD/DELETE PROMOTION";
            // 
            // gboxHeader_Admin
            // 
            this.gboxHeader_Admin.AutoSize = true;
            this.gboxHeader_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.gboxHeader_Admin.CausesValidation = false;
            this.gboxHeader_Admin.Controls.Add(this.btnBack);
            this.gboxHeader_Admin.Controls.Add(this.labelTop);
            this.gboxHeader_Admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.gboxHeader_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxHeader_Admin.ForeColor = System.Drawing.Color.White;
            this.gboxHeader_Admin.Location = new System.Drawing.Point(0, 0);
            this.gboxHeader_Admin.Name = "gboxHeader_Admin";
            this.gboxHeader_Admin.Size = new System.Drawing.Size(1231, 104);
            this.gboxHeader_Admin.TabIndex = 13;
            this.gboxHeader_Admin.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.AutoEllipsis = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 61);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.txtBoxDiscount);
            this.panel2.Controls.Add(this.txtBoxPromoCode);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelHeader);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Location = new System.Drawing.Point(683, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 323);
            this.panel2.TabIndex = 20;
            this.panel2.Tag = "";
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDiscount.Location = new System.Drawing.Point(173, 148);
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.Size = new System.Drawing.Size(252, 29);
            this.txtBoxDiscount.TabIndex = 30;
            this.txtBoxDiscount.Click += new System.EventHandler(this.txtBoxDiscount_Click);
            // 
            // txtBoxPromoCode
            // 
            this.txtBoxPromoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPromoCode.Location = new System.Drawing.Point(173, 78);
            this.txtBoxPromoCode.Name = "txtBoxPromoCode";
            this.txtBoxPromoCode.Size = new System.Drawing.Size(252, 29);
            this.txtBoxPromoCode.TabIndex = 29;
            this.txtBoxPromoCode.Click += new System.EventHandler(this.txtBoxPromoCode_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(289, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 67);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(26, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Discount %";
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(42, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(353, 39);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "ADD PROMO CODE";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelDescription.Location = new System.Drawing.Point(26, 83);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(117, 24);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "Promo Code";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(1019, 218);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 48);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(442, 615);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 61);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Location = new System.Drawing.Point(12, 185);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(242, 28);
            this.cmbDiscount.TabIndex = 24;
            this.cmbDiscount.SelectionChangeCommitted += new System.EventHandler(this.cmbDiscount_SelectionChangeCommitted);
            this.cmbDiscount.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxFormat);
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDiscount.Location = new System.Drawing.Point(8, 141);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(254, 24);
            this.labelDiscount.TabIndex = 25;
            this.labelDiscount.Text = "Select a group of discount";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAll.AutoSize = true;
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewAll.Location = new System.Drawing.Point(453, 165);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(141, 48);
            this.btnViewAll.TabIndex = 26;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // tblPromotionDataGridView
            // 
            this.tblPromotionDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblPromotionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPromotionDataGridView.Location = new System.Drawing.Point(12, 227);
            this.tblPromotionDataGridView.Name = "tblPromotionDataGridView";
            this.tblPromotionDataGridView.Size = new System.Drawing.Size(582, 382);
            this.tblPromotionDataGridView.TabIndex = 27;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(683, 227);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(313, 29);
            this.txtBoxSearch.TabIndex = 28;
            this.txtBoxSearch.Click += new System.EventHandler(this.txtBoxSearch_Click);
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged_1);
            // 
            // FormAddEditPromoCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1231, 702);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.tblPromotionDataGridView);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gboxHeader_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddEditPromoCode";
            this.Text = "FormAddEditPromoCode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormAddEditPromoCode_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditPromoCode_FormClosing);
            this.Load += new System.EventHandler(this.FormAddEditPromoCode_Load);
            this.gboxHeader_Admin.ResumeLayout(false);
            this.gboxHeader_Admin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPromotionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.GroupBox gboxHeader_Admin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView tblPromotionDataGridView;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.TextBox txtBoxDiscount;
        private System.Windows.Forms.TextBox txtBoxPromoCode;
    }
}