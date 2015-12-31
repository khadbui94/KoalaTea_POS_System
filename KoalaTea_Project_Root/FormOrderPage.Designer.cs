namespace KoalaTea_Project_Root
{
    partial class FormOrderPage
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
            this.btnDrinks_FormOrderPage = new System.Windows.Forms.Button();
            this.btnDinner_FormOrderPage = new System.Windows.Forms.Button();
            this.btnLunch_FormOrderPage = new System.Windows.Forms.Button();
            this.btnBreakfast_FormOrderPage = new System.Windows.Forms.Button();
            this.btnFinalizePrint_FormOrderPage = new System.Windows.Forms.Button();
            this.btnBack_FormOrderPage = new System.Windows.Forms.Button();
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.btnAddOneMore_OrderPage = new System.Windows.Forms.Button();
            this.quantity_formOrderPage = new System.Windows.Forms.Button();
            this.remove_formOrderPage = new System.Windows.Forms.Button();
            this.btn_add_FormAddItem = new System.Windows.Forms.Button();
            this.subtotal_label = new System.Windows.Forms.Label();
            this.Order_label = new System.Windows.Forms.Label();
            this.subTotal_textBox = new System.Windows.Forms.TextBox();
            this.listBoxOrderItems = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbControlItems = new System.Windows.Forms.TabControl();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btnSelectToAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUnselctAll = new System.Windows.Forms.Button();
            this.orderBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrinks_FormOrderPage
            // 
            this.btnDrinks_FormOrderPage.Location = new System.Drawing.Point(370, 19);
            this.btnDrinks_FormOrderPage.Name = "btnDrinks_FormOrderPage";
            this.btnDrinks_FormOrderPage.Size = new System.Drawing.Size(88, 40);
            this.btnDrinks_FormOrderPage.TabIndex = 3;
            this.btnDrinks_FormOrderPage.Text = "Drinks";
            this.btnDrinks_FormOrderPage.UseVisualStyleBackColor = true;
            // 
            // btnDinner_FormOrderPage
            // 
            this.btnDinner_FormOrderPage.Location = new System.Drawing.Point(263, 19);
            this.btnDinner_FormOrderPage.Name = "btnDinner_FormOrderPage";
            this.btnDinner_FormOrderPage.Size = new System.Drawing.Size(88, 40);
            this.btnDinner_FormOrderPage.TabIndex = 2;
            this.btnDinner_FormOrderPage.Text = "Dinner";
            this.btnDinner_FormOrderPage.UseVisualStyleBackColor = true;
            // 
            // btnLunch_FormOrderPage
            // 
            this.btnLunch_FormOrderPage.Location = new System.Drawing.Point(150, 19);
            this.btnLunch_FormOrderPage.Name = "btnLunch_FormOrderPage";
            this.btnLunch_FormOrderPage.Size = new System.Drawing.Size(88, 40);
            this.btnLunch_FormOrderPage.TabIndex = 1;
            this.btnLunch_FormOrderPage.Text = "Lunch";
            this.btnLunch_FormOrderPage.UseVisualStyleBackColor = true;
            // 
            // btnBreakfast_FormOrderPage
            // 
            this.btnBreakfast_FormOrderPage.Location = new System.Drawing.Point(39, 19);
            this.btnBreakfast_FormOrderPage.Name = "btnBreakfast_FormOrderPage";
            this.btnBreakfast_FormOrderPage.Size = new System.Drawing.Size(88, 40);
            this.btnBreakfast_FormOrderPage.TabIndex = 0;
            this.btnBreakfast_FormOrderPage.Text = "Breakfast";
            this.btnBreakfast_FormOrderPage.UseVisualStyleBackColor = true;
            // 
            // btnFinalizePrint_FormOrderPage
            // 
            this.btnFinalizePrint_FormOrderPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizePrint_FormOrderPage.AutoSize = true;
            this.btnFinalizePrint_FormOrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btnFinalizePrint_FormOrderPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizePrint_FormOrderPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizePrint_FormOrderPage.Location = new System.Drawing.Point(1171, 681);
            this.btnFinalizePrint_FormOrderPage.Name = "btnFinalizePrint_FormOrderPage";
            this.btnFinalizePrint_FormOrderPage.Size = new System.Drawing.Size(183, 77);
            this.btnFinalizePrint_FormOrderPage.TabIndex = 9;
            this.btnFinalizePrint_FormOrderPage.Text = "Finalize";
            this.btnFinalizePrint_FormOrderPage.UseVisualStyleBackColor = false;
            this.btnFinalizePrint_FormOrderPage.Click += new System.EventHandler(this.btnFinalizePrint_FormOrderPage_Click_1);
            // 
            // btnBack_FormOrderPage
            // 
            this.btnBack_FormOrderPage.AutoSize = true;
            this.btnBack_FormOrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnBack_FormOrderPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_FormOrderPage.ForeColor = System.Drawing.Color.White;
            this.btnBack_FormOrderPage.Location = new System.Drawing.Point(6, 7);
            this.btnBack_FormOrderPage.Name = "btnBack_FormOrderPage";
            this.btnBack_FormOrderPage.Size = new System.Drawing.Size(142, 75);
            this.btnBack_FormOrderPage.TabIndex = 10;
            this.btnBack_FormOrderPage.Text = "BACK";
            this.btnBack_FormOrderPage.UseVisualStyleBackColor = false;
            this.btnBack_FormOrderPage.Click += new System.EventHandler(this.btnBack_FormOrderPage_Click);
            // 
            // orderBox
            // 
            this.orderBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderBox.AutoSize = true;
            this.orderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.orderBox.Controls.Add(this.btnAddOneMore_OrderPage);
            this.orderBox.Controls.Add(this.quantity_formOrderPage);
            this.orderBox.Controls.Add(this.remove_formOrderPage);
            this.orderBox.Controls.Add(this.btn_add_FormAddItem);
            this.orderBox.Controls.Add(this.subtotal_label);
            this.orderBox.Controls.Add(this.Order_label);
            this.orderBox.Controls.Add(this.subTotal_textBox);
            this.orderBox.Controls.Add(this.listBoxOrderItems);
            this.orderBox.Location = new System.Drawing.Point(6, 96);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(476, 662);
            this.orderBox.TabIndex = 12;
            this.orderBox.TabStop = false;
            // 
            // btnAddOneMore_OrderPage
            // 
            this.btnAddOneMore_OrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnAddOneMore_OrderPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOneMore_OrderPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOneMore_OrderPage.Location = new System.Drawing.Point(9, 571);
            this.btnAddOneMore_OrderPage.Name = "btnAddOneMore_OrderPage";
            this.btnAddOneMore_OrderPage.Size = new System.Drawing.Size(143, 72);
            this.btnAddOneMore_OrderPage.TabIndex = 14;
            this.btnAddOneMore_OrderPage.Text = "COPY ";
            this.btnAddOneMore_OrderPage.UseVisualStyleBackColor = false;
            this.btnAddOneMore_OrderPage.Click += new System.EventHandler(this.btnAddOneMore_OrderPage_Click);
            // 
            // quantity_formOrderPage
            // 
            this.quantity_formOrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.quantity_formOrderPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_formOrderPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantity_formOrderPage.Location = new System.Drawing.Point(327, 571);
            this.quantity_formOrderPage.Name = "quantity_formOrderPage";
            this.quantity_formOrderPage.Size = new System.Drawing.Size(143, 72);
            this.quantity_formOrderPage.TabIndex = 13;
            this.quantity_formOrderPage.Text = "EDIT QUANTITY";
            this.quantity_formOrderPage.UseVisualStyleBackColor = false;
            this.quantity_formOrderPage.Click += new System.EventHandler(this.quantity_formOrderPage_Click);
            // 
            // remove_formOrderPage
            // 
            this.remove_formOrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.remove_formOrderPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_formOrderPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remove_formOrderPage.Location = new System.Drawing.Point(168, 571);
            this.remove_formOrderPage.Name = "remove_formOrderPage";
            this.remove_formOrderPage.Size = new System.Drawing.Size(143, 72);
            this.remove_formOrderPage.TabIndex = 12;
            this.remove_formOrderPage.Text = "REMOVE ";
            this.remove_formOrderPage.UseVisualStyleBackColor = false;
            this.remove_formOrderPage.Click += new System.EventHandler(this.remove_formOrderPage_Click);
            // 
            // btn_add_FormAddItem
            // 
            this.btn_add_FormAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_FormAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(89)))));
            this.btn_add_FormAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_FormAddItem.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_add_FormAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn_add_FormAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_FormAddItem.Location = new System.Drawing.Point(1208, -2);
            this.btn_add_FormAddItem.Name = "btn_add_FormAddItem";
            this.btn_add_FormAddItem.Size = new System.Drawing.Size(177, 83);
            this.btn_add_FormAddItem.TabIndex = 95;
            this.btn_add_FormAddItem.Text = "ADD";
            this.btn_add_FormAddItem.UseVisualStyleBackColor = false;
            // 
            // subtotal_label
            // 
            this.subtotal_label.AutoSize = true;
            this.subtotal_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_label.Location = new System.Drawing.Point(9, 528);
            this.subtotal_label.Name = "subtotal_label";
            this.subtotal_label.Size = new System.Drawing.Size(143, 31);
            this.subtotal_label.TabIndex = 15;
            this.subtotal_label.Text = "SUBTOTAL";
            // 
            // Order_label
            // 
            this.Order_label.AutoSize = true;
            this.Order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order_label.Location = new System.Drawing.Point(175, 16);
            this.Order_label.Name = "Order_label";
            this.Order_label.Size = new System.Drawing.Size(145, 33);
            this.Order_label.TabIndex = 14;
            this.Order_label.Text = "ORDERS";
            // 
            // subTotal_textBox
            // 
            this.subTotal_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal_textBox.Location = new System.Drawing.Point(312, 528);
            this.subTotal_textBox.Name = "subTotal_textBox";
            this.subTotal_textBox.ReadOnly = true;
            this.subTotal_textBox.Size = new System.Drawing.Size(158, 35);
            this.subTotal_textBox.TabIndex = 3;
            this.subTotal_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subTotal_textBox.VisibleChanged += new System.EventHandler(this.displaySubtotal);
            // 
            // listBoxOrderItems
            // 
            this.listBoxOrderItems.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrderItems.FormattingEnabled = true;
            this.listBoxOrderItems.ItemHeight = 22;
            this.listBoxOrderItems.Location = new System.Drawing.Point(9, 52);
            this.listBoxOrderItems.Name = "listBoxOrderItems";
            this.listBoxOrderItems.ScrollAlwaysVisible = true;
            this.listBoxOrderItems.Size = new System.Drawing.Size(461, 466);
            this.listBoxOrderItems.TabIndex = 1;
            this.listBoxOrderItems.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.formatList);
            // 
            // tbControlItems
            // 
            this.tbControlItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbControlItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlItems.Location = new System.Drawing.Point(90, 79);
            this.tbControlItems.Name = "tbControlItems";
            this.tbControlItems.SelectedIndex = 0;
            this.tbControlItems.Size = new System.Drawing.Size(869, 563);
            this.tbControlItems.TabIndex = 96;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(429, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(117, 47);
            this.btn_search.TabIndex = 94;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(61, 18);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(337, 31);
            this.textBox_search.TabIndex = 93;
            this.textBox_search.Click += new System.EventHandler(this.textBox_search_Click);
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // btnSelectToAdd
            // 
            this.btnSelectToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectToAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnSelectToAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectToAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectToAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectToAdd.Location = new System.Drawing.Point(782, 3);
            this.btnSelectToAdd.Name = "btnSelectToAdd";
            this.btnSelectToAdd.Size = new System.Drawing.Size(174, 64);
            this.btnSelectToAdd.TabIndex = 97;
            this.btnSelectToAdd.Text = "ADD";
            this.btnSelectToAdd.UseVisualStyleBackColor = false;
            this.btnSelectToAdd.Click += new System.EventHandler(this.btnSelectToAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnUnselctAll);
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Controls.Add(this.btnSelectToAdd);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.tbControlItems);
            this.panel2.Location = new System.Drawing.Point(398, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 645);
            this.panel2.TabIndex = 98;
            // 
            // btnUnselctAll
            // 
            this.btnUnselctAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnselctAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnUnselctAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnselctAll.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnUnselctAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselctAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUnselctAll.Location = new System.Drawing.Point(585, 3);
            this.btnUnselctAll.Name = "btnUnselctAll";
            this.btnUnselctAll.Size = new System.Drawing.Size(174, 64);
            this.btnUnselctAll.TabIndex = 98;
            this.btnUnselctAll.Text = "UNSELECT ALL";
            this.btnUnselctAll.UseVisualStyleBackColor = false;
            this.btnUnselctAll.Click += new System.EventHandler(this.btnUnselctAll_Click);
            // 
            // FormOrderPage
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(76)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1370, 766);
            this.Controls.Add(this.btnFinalizePrint_FormOrderPage);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack_FormOrderPage);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrderPage";
            this.Text = "FormOrderPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormOrderPage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderPage_FormClosing);
            this.Load += new System.EventHandler(this.FormOrderPage_Load);
            this.orderBox.ResumeLayout(false);
            this.orderBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrinks_FormOrderPage;
        private System.Windows.Forms.Button btnDinner_FormOrderPage;
        private System.Windows.Forms.Button btnLunch_FormOrderPage;
        private System.Windows.Forms.Button btnBreakfast_FormOrderPage;
        private System.Windows.Forms.Button btnFinalizePrint_FormOrderPage;
        private System.Windows.Forms.Button btnBack_FormOrderPage;
        private System.Windows.Forms.GroupBox orderBox;
        private System.Windows.Forms.Button quantity_formOrderPage;
        private System.Windows.Forms.Button remove_formOrderPage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label subtotal_label;
        private System.Windows.Forms.Label Order_label;
        private System.Windows.Forms.TextBox subTotal_textBox;
        private System.Windows.Forms.ListBox listBoxOrderItems;
        private System.Windows.Forms.Button btnAddOneMore_OrderPage;
        private System.Windows.Forms.Button btn_add_FormAddItem;
        private System.Windows.Forms.TabControl tbControlItems;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btnSelectToAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUnselctAll;
    }
}