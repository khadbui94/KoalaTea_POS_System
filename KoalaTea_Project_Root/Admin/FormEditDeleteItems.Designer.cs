namespace KoalaTea_Project_Root.Admin
{
    partial class FormEditItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseDataSet = new KoalaTea_Project_Root.DatabaseDataSet();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductTableAdapter = new KoalaTea_Project_Root.DatabaseDataSetTableAdapters.tblProductTableAdapter();
            this.tableAdapterManager = new KoalaTea_Project_Root.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.btnBack = new System.Windows.Forms.Button();
            this.gboxHeader_Admin = new System.Windows.Forms.GroupBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTblProducts = new System.Windows.Forms.DataGridView();
            this.labelCetorySelect = new System.Windows.Forms.Label();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            this.gboxHeader_Admin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTblProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.databaseDataSet;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCategoryTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = this.tblProductTableAdapter;
            this.tableAdapterManager.tblPromotionTableAdapter = null;
            this.tableAdapterManager.tblTablesTableAdapter = null;
            this.tableAdapterManager.tblTransactionItemTableAdapter = null;
            this.tableAdapterManager.tblTransactionTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KoalaTea_Project_Root.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.gboxHeader_Admin.Size = new System.Drawing.Size(1148, 104);
            this.gboxHeader_Admin.TabIndex = 12;
            this.gboxHeader_Admin.TabStop = false;
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(412, 16);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(509, 55);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "EDIT/DELETE ITEMS";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(412, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 61);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(613, 120);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(325, 29);
            this.txtBoxSearch.TabIndex = 15;
            this.txtBoxSearch.Click += new System.EventHandler(this.txtBoxSearch_Click);
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.VisibleChanged += new System.EventHandler(this.txtBoxSearch_VisibleChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(944, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 48);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridViewTblProducts);
            this.panel1.Controls.Add(this.labelCetorySelect);
            this.panel1.Controls.Add(this.cmbFilterCategory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtBoxSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(25, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 650);
            this.panel1.TabIndex = 18;
            // 
            // dataGridViewTblProducts
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTblProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTblProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTblProducts.Location = new System.Drawing.Point(16, 120);
            this.dataGridViewTblProducts.Name = "dataGridViewTblProducts";
            this.dataGridViewTblProducts.Size = new System.Drawing.Size(539, 375);
            this.dataGridViewTblProducts.TabIndex = 20;
            // 
            // labelCetorySelect
            // 
            this.labelCetorySelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCetorySelect.AutoSize = true;
            this.labelCetorySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCetorySelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCetorySelect.Location = new System.Drawing.Point(12, 10);
            this.labelCetorySelect.Name = "labelCetorySelect";
            this.labelCetorySelect.Size = new System.Drawing.Size(285, 24);
            this.labelCetorySelect.TabIndex = 19;
            this.labelCetorySelect.Text = "Select a Category of Products";
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFilterCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFilterCategory.DisplayMember = "CategoryID";
            this.cmbFilterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Location = new System.Drawing.Point(16, 54);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(364, 28);
            this.cmbFilterCategory.TabIndex = 18;
            this.cmbFilterCategory.ValueMember = "CategoryID";
            this.cmbFilterCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbFilterCategory_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBoxPrice);
            this.panel2.Controls.Add(this.labelHeader);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.txtBoxDescription);
            this.panel2.Location = new System.Drawing.Point(613, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 323);
            this.panel2.TabIndex = 17;
            this.panel2.Tag = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(256, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 61);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE CHANGE(S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(26, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrice.Location = new System.Drawing.Point(173, 148);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(252, 29);
            this.txtBoxPrice.TabIndex = 21;
            this.txtBoxPrice.Click += new System.EventHandler(this.txtBoxPrice_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(42, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(395, 39);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "EDIT SELECTED ITEM";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelDescription.Location = new System.Drawing.Point(26, 83);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(104, 24);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "Description";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescription.Location = new System.Drawing.Point(173, 83);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(252, 29);
            this.txtBoxDescription.TabIndex = 18;
            this.txtBoxDescription.Click += new System.EventHandler(this.txtBoxDescription_Click);
            // 
            // FormEditItems
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gboxHeader_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditItems";
            this.Text = "Edit/delete Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormEditItems_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditItems_FormClosing);
            this.Load += new System.EventHandler(this.EditDeleteItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            this.gboxHeader_Admin.ResumeLayout(false);
            this.gboxHeader_Admin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTblProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private DatabaseDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gboxHeader_Admin;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelCetorySelect;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.DataGridView dataGridViewTblProducts;

    }
}