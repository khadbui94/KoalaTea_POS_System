namespace KoalaTea_Project_Root
{
    partial class FormPayment
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
            this.btnBack = new System.Windows.Forms.Button();
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.txbSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTax = new System.Windows.Forms.TextBox();
            this.total_label = new System.Windows.Forms.Label();
            this.Order_label = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.gbCashPayment = new System.Windows.Forms.GroupBox();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCashGiven = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCardPayment = new System.Windows.Forms.GroupBox();
            this.txb_CardHolder = new System.Windows.Forms.TextBox();
            this.lbl_CardHolder_FormPament = new System.Windows.Forms.Label();
            this.txbCCV = new System.Windows.Forms.TextBox();
            this.lblCCV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCardNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCDebit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lable_Balance = new System.Windows.Forms.Label();
            this.txb_Balance = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxPromoCode = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.orderBox.SuspendLayout();
            this.gbCashPayment.SuspendLayout();
            this.gbCardPayment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(88)))), ((int)(((byte)(66)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 75);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderBox
            // 
            this.orderBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderBox.AutoSize = true;
            this.orderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.orderBox.Controls.Add(this.subTotalLabel);
            this.orderBox.Controls.Add(this.txbSubTotal);
            this.orderBox.Controls.Add(this.label1);
            this.orderBox.Controls.Add(this.txbTax);
            this.orderBox.Controls.Add(this.total_label);
            this.orderBox.Controls.Add(this.Order_label);
            this.orderBox.Controls.Add(this.txbTotal);
            this.orderBox.Controls.Add(this.listOrders);
            this.orderBox.Location = new System.Drawing.Point(12, 97);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(566, 594);
            this.orderBox.TabIndex = 29;
            this.orderBox.TabStop = false;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(50, 443);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(143, 31);
            this.subTotalLabel.TabIndex = 19;
            this.subTotalLabel.Text = "SUBTOTAL";
            // 
            // txbSubTotal
            // 
            this.txbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubTotal.Location = new System.Drawing.Point(340, 438);
            this.txbSubTotal.Name = "txbSubTotal";
            this.txbSubTotal.ReadOnly = true;
            this.txbSubTotal.Size = new System.Drawing.Size(158, 35);
            this.txbSubTotal.TabIndex = 18;
            this.txbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSubTotal.VisibleChanged += new System.EventHandler(this.txbSubTotal_VisibleChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "TAX";
            // 
            // txbTax
            // 
            this.txbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTax.Location = new System.Drawing.Point(340, 482);
            this.txbTax.Name = "txbTax";
            this.txbTax.ReadOnly = true;
            this.txbTax.Size = new System.Drawing.Size(158, 35);
            this.txbTax.TabIndex = 16;
            this.txbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTax.VisibleChanged += new System.EventHandler(this.txbTax_VisibleChanged);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(50, 531);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(94, 31);
            this.total_label.TabIndex = 15;
            this.total_label.Text = "TOTAL";
            // 
            // Order_label
            // 
            this.Order_label.AutoSize = true;
            this.Order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order_label.Location = new System.Drawing.Point(201, 10);
            this.Order_label.Name = "Order_label";
            this.Order_label.Size = new System.Drawing.Size(145, 33);
            this.Order_label.TabIndex = 14;
            this.Order_label.Text = "ORDERS";
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(340, 527);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(158, 35);
            this.txbTotal.TabIndex = 3;
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTotal.VisibleChanged += new System.EventHandler(this.txbTotal_VisibleChanged);
            // 
            // listOrders
            // 
            this.listOrders.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOrders.FormattingEnabled = true;
            this.listOrders.ItemHeight = 22;
            this.listOrders.Items.AddRange(new object[] {
            "Fried Dumpling",
            "Shumai",
            "Egg Custard",
            "Water",
            "Water",
            "Water",
            "Tea"});
            this.listOrders.Location = new System.Drawing.Point(50, 48);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(448, 378);
            this.listOrders.TabIndex = 1;
            this.listOrders.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxOrderItems_payment_Format);
            this.listOrders.VisibleChanged += new System.EventHandler(this.listBoxOrderItems_payment_VisibleChanged);
            // 
            // gbCashPayment
            // 
            this.gbCashPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCashPayment.AutoSize = true;
            this.gbCashPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(165)))));
            this.gbCashPayment.Controls.Add(this.btnPayCash);
            this.gbCashPayment.Controls.Add(this.label4);
            this.gbCashPayment.Controls.Add(this.txbChange);
            this.gbCashPayment.Controls.Add(this.label3);
            this.gbCashPayment.Controls.Add(this.txbCashGiven);
            this.gbCashPayment.Controls.Add(this.label2);
            this.gbCashPayment.Location = new System.Drawing.Point(695, 87);
            this.gbCashPayment.Name = "gbCashPayment";
            this.gbCashPayment.Size = new System.Drawing.Size(590, 240);
            this.gbCashPayment.TabIndex = 30;
            this.gbCashPayment.TabStop = false;
            // 
            // btnPayCash
            // 
            this.btnPayCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPayCash.AutoSize = true;
            this.btnPayCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnPayCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCash.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPayCash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPayCash.Location = new System.Drawing.Point(212, 161);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(179, 60);
            this.btnPayCash.TabIndex = 31;
            this.btnPayCash.Text = "Pay";
            this.btnPayCash.UseVisualStyleBackColor = false;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 33);
            this.label4.TabIndex = 32;
            this.label4.Text = "Payment by Cash";
            // 
            // txbChange
            // 
            this.txbChange.Enabled = false;
            this.txbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChange.Location = new System.Drawing.Point(210, 113);
            this.txbChange.Name = "txbChange";
            this.txbChange.Size = new System.Drawing.Size(300, 31);
            this.txbChange.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Change";
            // 
            // txbCashGiven
            // 
            this.txbCashGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCashGiven.Location = new System.Drawing.Point(210, 57);
            this.txbCashGiven.Name = "txbCashGiven";
            this.txbCashGiven.Size = new System.Drawing.Size(300, 31);
            this.txbCashGiven.TabIndex = 29;
            this.txbCashGiven.Click += new System.EventHandler(this.txbCashGiven_Click);
            this.txbCashGiven.TextChanged += new System.EventHandler(this.txbCashGiven_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cash Given";
            // 
            // gbCardPayment
            // 
            this.gbCardPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCardPayment.AutoSize = true;
            this.gbCardPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(165)))));
            this.gbCardPayment.Controls.Add(this.txb_CardHolder);
            this.gbCardPayment.Controls.Add(this.lbl_CardHolder_FormPament);
            this.gbCardPayment.Controls.Add(this.txbCCV);
            this.gbCardPayment.Controls.Add(this.lblCCV);
            this.gbCardPayment.Controls.Add(this.label6);
            this.gbCardPayment.Controls.Add(this.txbCardNumber);
            this.gbCardPayment.Controls.Add(this.label5);
            this.gbCardPayment.Controls.Add(this.btnCDebit);
            this.gbCardPayment.Location = new System.Drawing.Point(695, 335);
            this.gbCardPayment.Name = "gbCardPayment";
            this.gbCardPayment.Size = new System.Drawing.Size(590, 280);
            this.gbCardPayment.TabIndex = 32;
            this.gbCardPayment.TabStop = false;
            // 
            // txb_CardHolder
            // 
            this.txb_CardHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CardHolder.Location = new System.Drawing.Point(210, 61);
            this.txb_CardHolder.Name = "txb_CardHolder";
            this.txb_CardHolder.Size = new System.Drawing.Size(300, 31);
            this.txb_CardHolder.TabIndex = 37;
            this.txb_CardHolder.Click += new System.EventHandler(this.txb_CardHolder_Click);
            // 
            // lbl_CardHolder_FormPament
            // 
            this.lbl_CardHolder_FormPament.AutoSize = true;
            this.lbl_CardHolder_FormPament.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CardHolder_FormPament.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CardHolder_FormPament.ForeColor = System.Drawing.Color.White;
            this.lbl_CardHolder_FormPament.Location = new System.Drawing.Point(30, 61);
            this.lbl_CardHolder_FormPament.Name = "lbl_CardHolder_FormPament";
            this.lbl_CardHolder_FormPament.Size = new System.Drawing.Size(127, 25);
            this.lbl_CardHolder_FormPament.TabIndex = 36;
            this.lbl_CardHolder_FormPament.Text = "Card Holder";
            // 
            // txbCCV
            // 
            this.txbCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCCV.Location = new System.Drawing.Point(210, 151);
            this.txbCCV.Name = "txbCCV";
            this.txbCCV.Size = new System.Drawing.Size(143, 31);
            this.txbCCV.TabIndex = 35;
            this.txbCCV.Click += new System.EventHandler(this.txbCCV_Click);
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.BackColor = System.Drawing.Color.Transparent;
            this.lblCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCV.ForeColor = System.Drawing.Color.White;
            this.lblCCV.Location = new System.Drawing.Point(61, 154);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(56, 25);
            this.lblCCV.TabIndex = 34;
            this.lblCCV.Text = "CCV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(164, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 33);
            this.label6.TabIndex = 33;
            this.label6.Text = "Payment by Card";
            // 
            // txbCardNumber
            // 
            this.txbCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCardNumber.Location = new System.Drawing.Point(210, 107);
            this.txbCardNumber.Name = "txbCardNumber";
            this.txbCardNumber.Size = new System.Drawing.Size(300, 31);
            this.txbCardNumber.TabIndex = 29;
            this.txbCardNumber.Click += new System.EventHandler(this.txbCardNumber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Card Number";
            // 
            // btnCDebit
            // 
            this.btnCDebit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCDebit.AutoSize = true;
            this.btnCDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnCDebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDebit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCDebit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCDebit.Location = new System.Drawing.Point(174, 201);
            this.btnCDebit.Name = "btnCDebit";
            this.btnCDebit.Size = new System.Drawing.Size(236, 60);
            this.btnCDebit.TabIndex = 27;
            this.btnCDebit.Text = "Credit/Debit";
            this.btnCDebit.UseVisualStyleBackColor = false;
            this.btnCDebit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(165)))));
            this.groupBox1.Controls.Add(this.lable_Balance);
            this.groupBox1.Controls.Add(this.txb_Balance);
            this.groupBox1.Location = new System.Drawing.Point(695, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 63);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // lable_Balance
            // 
            this.lable_Balance.AutoSize = true;
            this.lable_Balance.BackColor = System.Drawing.Color.Transparent;
            this.lable_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_Balance.ForeColor = System.Drawing.Color.White;
            this.lable_Balance.Location = new System.Drawing.Point(37, 9);
            this.lable_Balance.Name = "lable_Balance";
            this.lable_Balance.Size = new System.Drawing.Size(243, 33);
            this.lable_Balance.TabIndex = 32;
            this.lable_Balance.Text = "Balance Remain";
            // 
            // txb_Balance
            // 
            this.txb_Balance.Enabled = false;
            this.txb_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Balance.Location = new System.Drawing.Point(286, 13);
            this.txb_Balance.Name = "txb_Balance";
            this.txb_Balance.Size = new System.Drawing.Size(234, 31);
            this.txb_Balance.TabIndex = 29;
            this.txb_Balance.VisibleChanged += new System.EventHandler(this.txtBalance_VisibleChange);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.txtBoxPromoCode);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(695, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 69);
            this.panel1.TabIndex = 34;
            // 
            // txtBoxPromoCode
            // 
            this.txtBoxPromoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPromoCode.Location = new System.Drawing.Point(210, 19);
            this.txtBoxPromoCode.Name = "txtBoxPromoCode";
            this.txtBoxPromoCode.Size = new System.Drawing.Size(192, 31);
            this.txtBoxPromoCode.TabIndex = 34;
            this.txtBoxPromoCode.Click += new System.EventHandler(this.txtBoxPromoCode_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(152)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(428, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 47);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "PROMO CODE";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCardPayment);
            this.Controls.Add(this.gbCashPayment);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormPayment_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPayment_FormClosing);
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.Shown += new System.EventHandler(this.FormPayment_Shown);
            this.orderBox.ResumeLayout(false);
            this.orderBox.PerformLayout();
            this.gbCashPayment.ResumeLayout(false);
            this.gbCashPayment.PerformLayout();
            this.gbCardPayment.ResumeLayout(false);
            this.gbCardPayment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox orderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTax;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label Order_label;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.GroupBox gbCashPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCashGiven;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbCardPayment;
        private System.Windows.Forms.TextBox txbCardNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCDebit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.TextBox txbSubTotal;
        private System.Windows.Forms.TextBox txbCCV;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lable_Balance;
        private System.Windows.Forms.TextBox txb_Balance;
        private System.Windows.Forms.TextBox txb_CardHolder;
        private System.Windows.Forms.Label lbl_CardHolder_FormPament;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPromoCode;
    }
}