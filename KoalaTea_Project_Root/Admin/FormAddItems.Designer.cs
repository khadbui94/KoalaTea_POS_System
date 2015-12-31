namespace KoalaTea_Project_Root.Admin
{
    partial class FormAddItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAddProduct = new System.Windows.Forms.GroupBox();
            this.bntUploadSelectedProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSelectedProduct = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUploadProductImage = new System.Windows.Forms.Button();
            this.pbProductImage_EditItems = new System.Windows.Forms.PictureBox();
            this.cmbSelectCategoryAddProduct_EditItems = new System.Windows.Forms.ComboBox();
            this.lblUploadProductImage = new System.Windows.Forms.Label();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.txtProductPrice_EditItems = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductName_EditItems = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.gbAddCategory_EditItems = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnUIploadCategoryImage = new System.Windows.Forms.Button();
            this.pbCategoryImage_EditItems = new System.Windows.Forms.PictureBox();
            this.lblUploadCategoryImage_EditItems = new System.Windows.Forms.Label();
            this.txtCategoryName_EditItems = new System.Windows.Forms.TextBox();
            this.lblCategoryDescription_EditIte = new System.Windows.Forms.Label();
            this.btnViewAllProducts = new System.Windows.Forms.Button();
            this.cmbFilterCategory_EditItems = new System.Windows.Forms.ComboBox();
            this.dataGridViewTblProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gpViewAllProducts = new System.Windows.Forms.GroupBox();
            this.btnBack_EditItems = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.labelTitle = new System.Windows.Forms.Label();
            this.gbAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage_EditItems)).BeginInit();
            this.gbAddCategory_EditItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoryImage_EditItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTblProducts)).BeginInit();
            this.gpViewAllProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddProduct
            // 
            this.gbAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAddProduct.AutoSize = true;
            this.gbAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.gbAddProduct.Controls.Add(this.bntUploadSelectedProd);
            this.gbAddProduct.Controls.Add(this.label2);
            this.gbAddProduct.Controls.Add(this.pbSelectedProduct);
            this.gbAddProduct.Controls.Add(this.btnAddProduct);
            this.gbAddProduct.Controls.Add(this.btnUploadProductImage);
            this.gbAddProduct.Controls.Add(this.pbProductImage_EditItems);
            this.gbAddProduct.Controls.Add(this.cmbSelectCategoryAddProduct_EditItems);
            this.gbAddProduct.Controls.Add(this.lblUploadProductImage);
            this.gbAddProduct.Controls.Add(this.lblSelectCategory);
            this.gbAddProduct.Controls.Add(this.txtProductPrice_EditItems);
            this.gbAddProduct.Controls.Add(this.lblProductPrice);
            this.gbAddProduct.Controls.Add(this.txtProductName_EditItems);
            this.gbAddProduct.Controls.Add(this.lblProductDescription);
            this.gbAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAddProduct.Location = new System.Drawing.Point(158, 350);
            this.gbAddProduct.Name = "gbAddProduct";
            this.gbAddProduct.Size = new System.Drawing.Size(450, 414);
            this.gbAddProduct.TabIndex = 1;
            this.gbAddProduct.TabStop = false;
            this.gbAddProduct.Text = "Add New Products";
            // 
            // bntUploadSelectedProd
            // 
            this.bntUploadSelectedProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntUploadSelectedProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.bntUploadSelectedProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntUploadSelectedProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUploadSelectedProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntUploadSelectedProd.Location = new System.Drawing.Point(285, 298);
            this.bntUploadSelectedProd.Name = "bntUploadSelectedProd";
            this.bntUploadSelectedProd.Size = new System.Drawing.Size(84, 37);
            this.bntUploadSelectedProd.TabIndex = 23;
            this.bntUploadSelectedProd.Text = "Upload";
            this.bntUploadSelectedProd.UseVisualStyleBackColor = false;
            this.bntUploadSelectedProd.Click += new System.EventHandler(this.bntUploadSelectedProd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Upload selected product image";
            // 
            // pbSelectedProduct
            // 
            this.pbSelectedProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSelectedProduct.BackColor = System.Drawing.SystemColors.Control;
            this.pbSelectedProduct.Location = new System.Drawing.Point(253, 165);
            this.pbSelectedProduct.Name = "pbSelectedProduct";
            this.pbSelectedProduct.Size = new System.Drawing.Size(135, 127);
            this.pbSelectedProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedProduct.TabIndex = 19;
            this.pbSelectedProduct.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(140, 331);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(139, 55);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_EditItems_Click);
            // 
            // btnUploadProductImage
            // 
            this.btnUploadProductImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUploadProductImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnUploadProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadProductImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUploadProductImage.Location = new System.Drawing.Point(50, 298);
            this.btnUploadProductImage.Name = "btnUploadProductImage";
            this.btnUploadProductImage.Size = new System.Drawing.Size(84, 37);
            this.btnUploadProductImage.TabIndex = 17;
            this.btnUploadProductImage.Text = "Upload";
            this.btnUploadProductImage.UseVisualStyleBackColor = false;
            this.btnUploadProductImage.Click += new System.EventHandler(this.btnUploadProductImage_EditItems_Click);
            // 
            // pbProductImage_EditItems
            // 
            this.pbProductImage_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProductImage_EditItems.BackColor = System.Drawing.SystemColors.Control;
            this.pbProductImage_EditItems.Location = new System.Drawing.Point(25, 165);
            this.pbProductImage_EditItems.Name = "pbProductImage_EditItems";
            this.pbProductImage_EditItems.Size = new System.Drawing.Size(135, 127);
            this.pbProductImage_EditItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage_EditItems.TabIndex = 16;
            this.pbProductImage_EditItems.TabStop = false;
            // 
            // cmbSelectCategoryAddProduct_EditItems
            // 
            this.cmbSelectCategoryAddProduct_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelectCategoryAddProduct_EditItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSelectCategoryAddProduct_EditItems.DisplayMember = "CategoryID";
            this.cmbSelectCategoryAddProduct_EditItems.FormattingEnabled = true;
            this.cmbSelectCategoryAddProduct_EditItems.Location = new System.Drawing.Point(204, 106);
            this.cmbSelectCategoryAddProduct_EditItems.Name = "cmbSelectCategoryAddProduct_EditItems";
            this.cmbSelectCategoryAddProduct_EditItems.Size = new System.Drawing.Size(184, 32);
            this.cmbSelectCategoryAddProduct_EditItems.TabIndex = 15;
            this.cmbSelectCategoryAddProduct_EditItems.ValueMember = "CategoryID";
            // 
            // lblUploadProductImage
            // 
            this.lblUploadProductImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUploadProductImage.AutoSize = true;
            this.lblUploadProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadProductImage.Location = new System.Drawing.Point(31, 142);
            this.lblUploadProductImage.Name = "lblUploadProductImage";
            this.lblUploadProductImage.Size = new System.Drawing.Size(129, 20);
            this.lblUploadProductImage.TabIndex = 14;
            this.lblUploadProductImage.Text = "Upload an image";
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.Location = new System.Drawing.Point(31, 106);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(122, 20);
            this.lblSelectCategory.TabIndex = 13;
            this.lblSelectCategory.Text = "Select Category";
            // 
            // txtProductPrice_EditItems
            // 
            this.txtProductPrice_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductPrice_EditItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice_EditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice_EditItems.Location = new System.Drawing.Point(204, 64);
            this.txtProductPrice_EditItems.Name = "txtProductPrice_EditItems";
            this.txtProductPrice_EditItems.Size = new System.Drawing.Size(184, 31);
            this.txtProductPrice_EditItems.TabIndex = 12;
            this.txtProductPrice_EditItems.Click += new System.EventHandler(this.txtProductPrice_EditItems_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(31, 68);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(103, 20);
            this.lblProductPrice.TabIndex = 11;
            this.lblProductPrice.Text = "Product Price";
            // 
            // txtProductName_EditItems
            // 
            this.txtProductName_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName_EditItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName_EditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName_EditItems.Location = new System.Drawing.Point(204, 32);
            this.txtProductName_EditItems.Name = "txtProductName_EditItems";
            this.txtProductName_EditItems.Size = new System.Drawing.Size(184, 31);
            this.txtProductName_EditItems.TabIndex = 10;
            this.txtProductName_EditItems.Click += new System.EventHandler(this.txtProductName_EditItems_Click);
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(31, 35);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(148, 20);
            this.lblProductDescription.TabIndex = 1;
            this.lblProductDescription.Text = "Product Description";
            // 
            // gbAddCategory_EditItems
            // 
            this.gbAddCategory_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAddCategory_EditItems.AutoSize = true;
            this.gbAddCategory_EditItems.BackColor = System.Drawing.Color.Transparent;
            this.gbAddCategory_EditItems.Controls.Add(this.btnAddCategory);
            this.gbAddCategory_EditItems.Controls.Add(this.btnUIploadCategoryImage);
            this.gbAddCategory_EditItems.Controls.Add(this.pbCategoryImage_EditItems);
            this.gbAddCategory_EditItems.Controls.Add(this.lblUploadCategoryImage_EditItems);
            this.gbAddCategory_EditItems.Controls.Add(this.txtCategoryName_EditItems);
            this.gbAddCategory_EditItems.Controls.Add(this.lblCategoryDescription_EditIte);
            this.gbAddCategory_EditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddCategory_EditItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAddCategory_EditItems.Location = new System.Drawing.Point(156, 60);
            this.gbAddCategory_EditItems.Name = "gbAddCategory_EditItems";
            this.gbAddCategory_EditItems.Size = new System.Drawing.Size(450, 288);
            this.gbAddCategory_EditItems.TabIndex = 3;
            this.gbAddCategory_EditItems.TabStop = false;
            this.gbAddCategory_EditItems.Text = "Add New Category of Products";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCategory.Location = new System.Drawing.Point(35, 204);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(148, 56);
            this.btnAddCategory.TabIndex = 12;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_EditItems_Click);
            // 
            // btnUIploadCategoryImage
            // 
            this.btnUIploadCategoryImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUIploadCategoryImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnUIploadCategoryImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUIploadCategoryImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUIploadCategoryImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUIploadCategoryImage.Location = new System.Drawing.Point(47, 107);
            this.btnUIploadCategoryImage.Name = "btnUIploadCategoryImage";
            this.btnUIploadCategoryImage.Size = new System.Drawing.Size(103, 49);
            this.btnUIploadCategoryImage.TabIndex = 11;
            this.btnUIploadCategoryImage.Text = "Upload";
            this.btnUIploadCategoryImage.UseVisualStyleBackColor = false;
            this.btnUIploadCategoryImage.Click += new System.EventHandler(this.btnUIploadCategoryImage_EditItems_Click);
            // 
            // pbCategoryImage_EditItems
            // 
            this.pbCategoryImage_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCategoryImage_EditItems.BackColor = System.Drawing.Color.MintCream;
            this.pbCategoryImage_EditItems.Location = new System.Drawing.Point(204, 78);
            this.pbCategoryImage_EditItems.Name = "pbCategoryImage_EditItems";
            this.pbCategoryImage_EditItems.Size = new System.Drawing.Size(184, 182);
            this.pbCategoryImage_EditItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCategoryImage_EditItems.TabIndex = 10;
            this.pbCategoryImage_EditItems.TabStop = false;
            // 
            // lblUploadCategoryImage_EditItems
            // 
            this.lblUploadCategoryImage_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUploadCategoryImage_EditItems.AutoSize = true;
            this.lblUploadCategoryImage_EditItems.Location = new System.Drawing.Point(31, 77);
            this.lblUploadCategoryImage_EditItems.Name = "lblUploadCategoryImage_EditItems";
            this.lblUploadCategoryImage_EditItems.Size = new System.Drawing.Size(168, 24);
            this.lblUploadCategoryImage_EditItems.TabIndex = 9;
            this.lblUploadCategoryImage_EditItems.Text = "Upload an image";
            // 
            // txtCategoryName_EditItems
            // 
            this.txtCategoryName_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoryName_EditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName_EditItems.Location = new System.Drawing.Point(204, 36);
            this.txtCategoryName_EditItems.Name = "txtCategoryName_EditItems";
            this.txtCategoryName_EditItems.Size = new System.Drawing.Size(184, 31);
            this.txtCategoryName_EditItems.TabIndex = 3;
            this.txtCategoryName_EditItems.Click += new System.EventHandler(this.txtCategoryName_EditItems_Click);
            // 
            // lblCategoryDescription_EditIte
            // 
            this.lblCategoryDescription_EditIte.Location = new System.Drawing.Point(31, 39);
            this.lblCategoryDescription_EditIte.Name = "lblCategoryDescription_EditIte";
            this.lblCategoryDescription_EditIte.Size = new System.Drawing.Size(167, 23);
            this.lblCategoryDescription_EditIte.TabIndex = 13;
            this.lblCategoryDescription_EditIte.Text = "Category Description";
            // 
            // btnViewAllProducts
            // 
            this.btnViewAllProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnViewAllProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewAllProducts.Location = new System.Drawing.Point(497, 21);
            this.btnViewAllProducts.Name = "btnViewAllProducts";
            this.btnViewAllProducts.Size = new System.Drawing.Size(154, 54);
            this.btnViewAllProducts.TabIndex = 12;
            this.btnViewAllProducts.Text = "View All Products";
            this.btnViewAllProducts.UseVisualStyleBackColor = false;
            this.btnViewAllProducts.Click += new System.EventHandler(this.btnViewAllProducts_EditItems_Click);
            // 
            // cmbFilterCategory_EditItems
            // 
            this.cmbFilterCategory_EditItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFilterCategory_EditItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFilterCategory_EditItems.DisplayMember = "CategoryID";
            this.cmbFilterCategory_EditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCategory_EditItems.FormattingEnabled = true;
            this.cmbFilterCategory_EditItems.Location = new System.Drawing.Point(61, 55);
            this.cmbFilterCategory_EditItems.Name = "cmbFilterCategory_EditItems";
            this.cmbFilterCategory_EditItems.Size = new System.Drawing.Size(364, 32);
            this.cmbFilterCategory_EditItems.TabIndex = 11;
            this.cmbFilterCategory_EditItems.ValueMember = "CategoryID";
            this.cmbFilterCategory_EditItems.SelectionChangeCommitted += new System.EventHandler(this.cmbFilterCategory_EditItems_SelectionChangeCommitted);
            // 
            // dataGridViewTblProducts
            // 
            this.dataGridViewTblProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTblProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTblProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTblProducts.GridColor = System.Drawing.Color.White;
            this.dataGridViewTblProducts.Location = new System.Drawing.Point(61, 114);
            this.dataGridViewTblProducts.Name = "dataGridViewTblProducts";
            this.dataGridViewTblProducts.ReadOnly = true;
            this.dataGridViewTblProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTblProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTblProducts.Size = new System.Drawing.Size(590, 580);
            this.dataGridViewTblProducts.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select a Category of Products";
            // 
            // gpViewAllProducts
            // 
            this.gpViewAllProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpViewAllProducts.AutoSize = true;
            this.gpViewAllProducts.BackColor = System.Drawing.Color.Transparent;
            this.gpViewAllProducts.Controls.Add(this.label1);
            this.gpViewAllProducts.Controls.Add(this.dataGridViewTblProducts);
            this.gpViewAllProducts.Controls.Add(this.cmbFilterCategory_EditItems);
            this.gpViewAllProducts.Controls.Add(this.btnViewAllProducts);
            this.gpViewAllProducts.Location = new System.Drawing.Point(631, 62);
            this.gpViewAllProducts.Name = "gpViewAllProducts";
            this.gpViewAllProducts.Size = new System.Drawing.Size(724, 762);
            this.gpViewAllProducts.TabIndex = 14;
            this.gpViewAllProducts.TabStop = false;
            // 
            // btnBack_EditItems
            // 
            this.btnBack_EditItems.AutoEllipsis = true;
            this.btnBack_EditItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnBack_EditItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack_EditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_EditItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack_EditItems.Location = new System.Drawing.Point(12, 9);
            this.btnBack_EditItems.Name = "btnBack_EditItems";
            this.btnBack_EditItems.Size = new System.Drawing.Size(143, 61);
            this.btnBack_EditItems.TabIndex = 13;
            this.btnBack_EditItems.Text = "Back";
            this.btnBack_EditItems.UseVisualStyleBackColor = false;
            this.btnBack_EditItems.Click += new System.EventHandler(this.btnBack_EditItems_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(458, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(329, 42);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "ADD PRODUCTS";
            // 
            // FormAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnBack_EditItems);
            this.Controls.Add(this.gpViewAllProducts);
            this.Controls.Add(this.gbAddCategory_EditItems);
            this.Controls.Add(this.gbAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddItems";
            this.Text = "FormEditItems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormAddItems_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddItems_FormClosing);
            this.Load += new System.EventHandler(this.loadBackGround);
            this.gbAddProduct.ResumeLayout(false);
            this.gbAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage_EditItems)).EndInit();
            this.gbAddCategory_EditItems.ResumeLayout(false);
            this.gbAddCategory_EditItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoryImage_EditItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTblProducts)).EndInit();
            this.gpViewAllProducts.ResumeLayout(false);
            this.gpViewAllProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUploadProductImage;
        private System.Windows.Forms.PictureBox pbProductImage_EditItems;
        private System.Windows.Forms.ComboBox cmbSelectCategoryAddProduct_EditItems;
        private System.Windows.Forms.Label lblUploadProductImage;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.TextBox txtProductPrice_EditItems;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductName_EditItems;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.GroupBox gbAddCategory_EditItems;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnUIploadCategoryImage;
        private System.Windows.Forms.PictureBox pbCategoryImage_EditItems;
        private System.Windows.Forms.Label lblUploadCategoryImage_EditItems;
        private System.Windows.Forms.TextBox txtCategoryName_EditItems;
        private System.Windows.Forms.Label lblCategoryDescription_EditIte;
        private System.Windows.Forms.Button btnViewAllProducts;
        private System.Windows.Forms.ComboBox cmbFilterCategory_EditItems;
        private System.Windows.Forms.DataGridView dataGridViewTblProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpViewAllProducts;
        private System.Windows.Forms.Button btnBack_EditItems;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pbSelectedProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button bntUploadSelectedProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitle;

    }
}