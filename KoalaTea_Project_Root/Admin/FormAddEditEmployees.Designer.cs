namespace KoalaTea_Project_Root.Admin
{
    partial class FormAddEditEmployees
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
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.gboxHeader_Admin = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.dataGridViewTblUser = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new KoalaTea_Project_Root.DatabaseDataSet();
            this.tblUsersTableAdapter = new KoalaTea_Project_Root.DatabaseDataSetTableAdapters.tblUsersTableAdapter();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gboxHeader_Admin.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTblUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(168, 69);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(390, 31);
            this.txtBoxLastName.TabIndex = 7;
            this.txtBoxLastName.Click += new System.EventHandler(this.txtBoxLastName_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(167, 15);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(390, 31);
            this.txtBoxFirstName.TabIndex = 5;
            this.txtBoxFirstName.Click += new System.EventHandler(this.txtBoxFirstName_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(42, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(104, 24);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Last Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(462, 695);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 61);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(41, 132);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(110, 24);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(405, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 61);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(167, 131);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(390, 31);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.Click += new System.EventHandler(this.textBoxUserName_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(41, 181);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 24);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(167, 180);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(390, 31);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
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
            this.gboxHeader_Admin.Size = new System.Drawing.Size(1366, 104);
            this.gboxHeader_Admin.TabIndex = 11;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(431, 15);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(669, 55);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "ADD/ DELETE EMPLOYEES";
            // 
            // panelEmployee
            // 
            this.panelEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEmployee.AutoSize = true;
            this.panelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.panelEmployee.Controls.Add(this.labelFirstName);
            this.panelEmployee.Controls.Add(this.txtBoxFirstName);
            this.panelEmployee.Controls.Add(this.labelLastName);
            this.panelEmployee.Controls.Add(this.txtBoxLastName);
            this.panelEmployee.Controls.Add(this.labelUserName);
            this.panelEmployee.Controls.Add(this.btnAdd);
            this.panelEmployee.Controls.Add(this.textBoxUserName);
            this.panelEmployee.Controls.Add(this.labelPassword);
            this.panelEmployee.Controls.Add(this.textBoxPassword);
            this.panelEmployee.Location = new System.Drawing.Point(661, 263);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(639, 330);
            this.panelEmployee.TabIndex = 10;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(41, 17);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(101, 24);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "First Name";
            // 
            // dataGridViewTblUser
            // 
            this.dataGridViewTblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTblUser.AutoGenerateColumns = false;
            this.dataGridViewTblUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTblUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridViewTblUser.DataSource = this.tblUsersBindingSource;
            this.dataGridViewTblUser.Location = new System.Drawing.Point(21, 185);
            this.dataGridViewTblUser.Name = "dataGridViewTblUser";
            this.dataGridViewTblUser.Size = new System.Drawing.Size(593, 485);
            this.dataGridViewTblUser.TabIndex = 15;
            this.dataGridViewTblUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTblUser_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(21, 139);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(420, 26);
            this.txtBoxSearch.TabIndex = 17;
            this.txtBoxSearch.Click += new System.EventHandler(this.txtBoxSearch_Click);
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(484, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 48);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormAddEditEmployees
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewTblUser);
            this.Controls.Add(this.gboxHeader_Admin);
            this.Controls.Add(this.panelEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddEditEmployees";
            this.Text = "AddEmployees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormAddEditEmployees_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditEmployees_FormClosing);
            this.Load += new System.EventHandler(this.AddEditEmployees_Load);
            this.gboxHeader_Admin.ResumeLayout(false);
            this.gboxHeader_Admin.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTblUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox gboxHeader_Admin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.DataGridView dataGridViewTblUser;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DatabaseDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;

    }
}