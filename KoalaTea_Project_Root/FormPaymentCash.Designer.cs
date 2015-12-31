namespace KoalaTea_Project_Root
{
    partial class FormPaymentCash
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
            this.addItem_Button_Cancel = new System.Windows.Forms.Button();
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subtotal_label = new System.Windows.Forms.Label();
            this.Order_label = new System.Windows.Forms.Label();
            this.subTotal_textBox = new System.Windows.Forms.TextBox();
            this.listBoxOrderItems = new System.Windows.Forms.ListBox();
            this.orderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItem_Button_Cancel
            // 
            this.addItem_Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItem_Button_Cancel.AutoSize = true;
            this.addItem_Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.addItem_Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItem_Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem_Button_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addItem_Button_Cancel.Location = new System.Drawing.Point(12, 12);
            this.addItem_Button_Cancel.Name = "addItem_Button_Cancel";
            this.addItem_Button_Cancel.Size = new System.Drawing.Size(146, 58);
            this.addItem_Button_Cancel.TabIndex = 27;
            this.addItem_Button_Cancel.Text = "Back";
            this.addItem_Button_Cancel.UseVisualStyleBackColor = false;
            // 
            // orderBox
            // 
            this.orderBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderBox.AutoSize = true;
            this.orderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.orderBox.Controls.Add(this.label1);
            this.orderBox.Controls.Add(this.textBox1);
            this.orderBox.Controls.Add(this.subtotal_label);
            this.orderBox.Controls.Add(this.Order_label);
            this.orderBox.Controls.Add(this.subTotal_textBox);
            this.orderBox.Controls.Add(this.listBoxOrderItems);
            this.orderBox.Location = new System.Drawing.Point(63, 84);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(566, 633);
            this.orderBox.TabIndex = 28;
            this.orderBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "SUBTOTAL";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(386, 520);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 35);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subtotal_label
            // 
            this.subtotal_label.AutoSize = true;
            this.subtotal_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_label.Location = new System.Drawing.Point(29, 576);
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
            this.Order_label.Location = new System.Drawing.Point(229, 20);
            this.Order_label.Name = "Order_label";
            this.Order_label.Size = new System.Drawing.Size(145, 33);
            this.Order_label.TabIndex = 14;
            this.Order_label.Text = "ORDERS";
            // 
            // subTotal_textBox
            // 
            this.subTotal_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal_textBox.Location = new System.Drawing.Point(386, 576);
            this.subTotal_textBox.Name = "subTotal_textBox";
            this.subTotal_textBox.Size = new System.Drawing.Size(158, 35);
            this.subTotal_textBox.TabIndex = 3;
            this.subTotal_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxOrderItems
            // 
            this.listBoxOrderItems.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrderItems.FormattingEnabled = true;
            this.listBoxOrderItems.ItemHeight = 22;
            this.listBoxOrderItems.Items.AddRange(new object[] {
            "Fried Dumpling",
            "Shumai",
            "Egg Custard",
            "Water",
            "Water",
            "Water",
            "Tea"});
            this.listBoxOrderItems.Location = new System.Drawing.Point(70, 91);
            this.listBoxOrderItems.Name = "listBoxOrderItems";
            this.listBoxOrderItems.Size = new System.Drawing.Size(448, 378);
            this.listBoxOrderItems.TabIndex = 1;
            // 
            // FormPaymentCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.addItem_Button_Cancel);
            this.Name = "FormPaymentCash";
            this.Text = "FormPaymentCash";
            this.Shown += new System.EventHandler(this.FormPaymentCash_Shown);
            this.orderBox.ResumeLayout(false);
            this.orderBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItem_Button_Cancel;
        private System.Windows.Forms.GroupBox orderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label subtotal_label;
        private System.Windows.Forms.Label Order_label;
        private System.Windows.Forms.TextBox subTotal_textBox;
        private System.Windows.Forms.ListBox listBoxOrderItems;
    }
}