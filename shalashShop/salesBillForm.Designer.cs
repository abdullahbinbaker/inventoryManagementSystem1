namespace shalashShop
{
    partial class salesBillForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.billNo = new System.Windows.Forms.TextBox();
            this.billType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceBeforeDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalPriceAfterDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cashBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TheRestBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveAndPrintButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.billDate = new System.Windows.Forms.TextBox();
            this.salesmanName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.searchForCustomers = new System.Windows.Forms.Button();
            this.customerID = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.billNo2 = new System.Windows.Forms.TextBox();
            this.paidButton = new System.Windows.Forms.Button();
            this.itemInSalesBillBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemInSalesBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInSalesBillBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInSalesBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(900, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم البائع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(900, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "نوع الفاتورة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاريخ الفاتورة";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(398, 115);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(477, 21);
            this.customerName.TabIndex = 6;
            // 
            // billNo
            // 
            this.billNo.Location = new System.Drawing.Point(45, 25);
            this.billNo.Name = "billNo";
            this.billNo.ReadOnly = true;
            this.billNo.Size = new System.Drawing.Size(137, 21);
            this.billNo.TabIndex = 7;
            // 
            // billType
            // 
            this.billType.FormattingEnabled = true;
            this.billType.Items.AddRange(new object[] {
            "نقدي ",
            "اجل"});
            this.billType.Location = new System.Drawing.Point(389, 20);
            this.billType.Name = "billType";
            this.billType.Size = new System.Drawing.Size(137, 21);
            this.billType.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(48, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 204);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "رقم الصنف";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "اسم الصنف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "الكمية";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "السعر ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "الخصم";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الإجمالي";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "التكلفة";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الربح";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // totalPriceBeforeDiscount
            // 
            this.totalPriceBeforeDiscount.Location = new System.Drawing.Point(45, 413);
            this.totalPriceBeforeDiscount.Name = "totalPriceBeforeDiscount";
            this.totalPriceBeforeDiscount.ReadOnly = true;
            this.totalPriceBeforeDiscount.Size = new System.Drawing.Size(137, 21);
            this.totalPriceBeforeDiscount.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "المبلغ الاجمالي";
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(45, 455);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(137, 21);
            this.discount.TabIndex = 14;
            this.discount.TextChanged += new System.EventHandler(this.discount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "الخصم";
            // 
            // totalPriceAfterDiscount
            // 
            this.totalPriceAfterDiscount.Location = new System.Drawing.Point(45, 493);
            this.totalPriceAfterDiscount.Name = "totalPriceAfterDiscount";
            this.totalPriceAfterDiscount.ReadOnly = true;
            this.totalPriceAfterDiscount.Size = new System.Drawing.Size(137, 21);
            this.totalPriceAfterDiscount.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "صافي الاجمالي";
            // 
            // cashBox
            // 
            this.cashBox.Location = new System.Drawing.Point(45, 540);
            this.cashBox.Name = "cashBox";
            this.cashBox.Size = new System.Drawing.Size(138, 21);
            this.cashBox.TabIndex = 18;
            this.cashBox.TextChanged += new System.EventHandler(this.cashBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "نقدي";
            // 
            // TheRestBox
            // 
            this.TheRestBox.Location = new System.Drawing.Point(45, 575);
            this.TheRestBox.Name = "TheRestBox";
            this.TheRestBox.ReadOnly = true;
            this.TheRestBox.Size = new System.Drawing.Size(138, 21);
            this.TheRestBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "المتبقي";
            // 
            // saveAndPrintButton
            // 
            this.saveAndPrintButton.Location = new System.Drawing.Point(738, 425);
            this.saveAndPrintButton.Name = "saveAndPrintButton";
            this.saveAndPrintButton.Size = new System.Drawing.Size(100, 30);
            this.saveAndPrintButton.TabIndex = 21;
            this.saveAndPrintButton.Text = "اعتماد وطباعة";
            this.saveAndPrintButton.UseVisualStyleBackColor = true;
            this.saveAndPrintButton.Click += new System.EventHandler(this.saveAndPrintButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(578, 425);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 30);
            this.refreshButton.TabIndex = 22;
            this.refreshButton.Text = "تحديث";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(368, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // billDate
            // 
            this.billDate.Enabled = false;
            this.billDate.Location = new System.Drawing.Point(45, 74);
            this.billDate.Name = "billDate";
            this.billDate.ReadOnly = true;
            this.billDate.Size = new System.Drawing.Size(137, 21);
            this.billDate.TabIndex = 24;
            // 
            // salesmanName
            // 
            this.salesmanName.FormattingEnabled = true;
            this.salesmanName.Items.AddRange(new object[] {
            "abdullah salem"});
            this.salesmanName.Location = new System.Drawing.Point(738, 26);
            this.salesmanName.Name = "salesmanName";
            this.salesmanName.Size = new System.Drawing.Size(137, 21);
            this.salesmanName.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(684, 520);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(896, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "رقم العميل";
            // 
            // searchForCustomers
            // 
            this.searchForCustomers.Location = new System.Drawing.Point(609, 68);
            this.searchForCustomers.Name = "searchForCustomers";
            this.searchForCustomers.Size = new System.Drawing.Size(100, 30);
            this.searchForCustomers.TabIndex = 29;
            this.searchForCustomers.Text = "عرض العملاء";
            this.searchForCustomers.UseVisualStyleBackColor = true;
            this.searchForCustomers.Click += new System.EventHandler(this.searchForCustomers_Click_1);
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(775, 74);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(100, 21);
            this.customerID.TabIndex = 30;
            this.customerID.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            this.customerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerID_KeyPress);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(763, 425);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 30);
            this.printButton.TabIndex = 31;
            this.printButton.Text = "طباعة";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Visible = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click_1);
            // 
            // billNo2
            // 
            this.billNo2.Location = new System.Drawing.Point(34, 26);
            this.billNo2.Name = "billNo2";
            this.billNo2.ReadOnly = true;
            this.billNo2.Size = new System.Drawing.Size(137, 21);
            this.billNo2.TabIndex = 32;
            this.billNo2.Visible = false;
            // 
            // paidButton
            // 
            this.paidButton.Location = new System.Drawing.Point(531, 425);
            this.paidButton.Name = "paidButton";
            this.paidButton.Size = new System.Drawing.Size(114, 30);
            this.paidButton.TabIndex = 33;
            this.paidButton.Text = "سداد الفاتورة";
            this.paidButton.UseVisualStyleBackColor = true;
            this.paidButton.Visible = false;
            this.paidButton.Click += new System.EventHandler(this.paidButton_Click_1);
            // 
            // itemInSalesBillBindingSource1
            // 
            this.itemInSalesBillBindingSource1.DataSource = typeof(shalashShop.itemInSalesBill);
            // 
            // itemInSalesBillBindingSource
            // 
            this.itemInSalesBillBindingSource.DataSource = typeof(shalashShop.itemInSalesBill);
            // 
            // salesBillForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 622);
            this.Controls.Add(this.paidButton);
            this.Controls.Add(this.billNo2);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.searchForCustomers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.salesmanName);
            this.Controls.Add(this.billDate);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.saveAndPrintButton);
            this.Controls.Add(this.TheRestBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cashBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalPriceAfterDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalPriceBeforeDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.billType);
            this.Controls.Add(this.billNo);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "salesBillForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.salesBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInSalesBillBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInSalesBillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox billNo;
        public System.Windows.Forms.TextBox customerName;
        public System.Windows.Forms.ComboBox billType;
        public System.Windows.Forms.TextBox billDate;
        public System.Windows.Forms.Button printButton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button saveAndPrintButton;
        public System.Windows.Forms.ComboBox salesmanName;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button searchForCustomers;
        public System.Windows.Forms.TextBox customerID;
        public System.Windows.Forms.TextBox discount;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox cashBox;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TheRestBox;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox totalPriceBeforeDiscount;
        public System.Windows.Forms.TextBox totalPriceAfterDiscount;
        public System.Windows.Forms.TextBox billNo2;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.Button paidButton;
        public System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.BindingSource itemInSalesBillBindingSource;
        private System.Windows.Forms.BindingSource itemInSalesBillBindingSource1;
    }
}