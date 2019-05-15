namespace shalashShop
{
    partial class purchasesBillForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPriceAfterDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cashBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TheRestBox = new System.Windows.Forms.TextBox();
            this.paidButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.billNo2 = new System.Windows.Forms.TextBox();
            this.billNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchForSuppliersButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.saveAndPrintButton = new System.Windows.Forms.Button();
            this.totalPriceBeforeDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.supplierID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.originalPurchaseBillNo1 = new System.Windows.Forms.TextBox();
            this.discount1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "الخصم";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "صافي الاجمالي";
            // 
            // totalPriceAfterDiscount
            // 
            this.totalPriceAfterDiscount.Location = new System.Drawing.Point(30, 422);
            this.totalPriceAfterDiscount.Name = "totalPriceAfterDiscount";
            this.totalPriceAfterDiscount.ReadOnly = true;
            this.totalPriceAfterDiscount.Size = new System.Drawing.Size(137, 21);
            this.totalPriceAfterDiscount.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "نقدي";
            // 
            // cashBox
            // 
            this.cashBox.Location = new System.Drawing.Point(29, 466);
            this.cashBox.Name = "cashBox";
            this.cashBox.Size = new System.Drawing.Size(138, 21);
            this.cashBox.TabIndex = 32;
            this.cashBox.TextChanged += new System.EventHandler(this.cashBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "المتبقي";
            // 
            // TheRestBox
            // 
            this.TheRestBox.Location = new System.Drawing.Point(29, 501);
            this.TheRestBox.Name = "TheRestBox";
            this.TheRestBox.ReadOnly = true;
            this.TheRestBox.Size = new System.Drawing.Size(138, 21);
            this.TheRestBox.TabIndex = 34;
            // 
            // paidButton
            // 
            this.paidButton.Location = new System.Drawing.Point(588, 372);
            this.paidButton.Name = "paidButton";
            this.paidButton.Size = new System.Drawing.Size(100, 30);
            this.paidButton.TabIndex = 73;
            this.paidButton.Text = "تسديد";
            this.paidButton.UseVisualStyleBackColor = true;
            this.paidButton.Visible = false;
            this.paidButton.Click += new System.EventHandler(this.paidButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(753, 372);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 30);
            this.printButton.TabIndex = 72;
            this.printButton.Text = "طباعة ";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Visible = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click_1);
            // 
            // billNo2
            // 
            this.billNo2.Enabled = false;
            this.billNo2.Location = new System.Drawing.Point(70, 33);
            this.billNo2.Name = "billNo2";
            this.billNo2.ReadOnly = true;
            this.billNo2.Size = new System.Drawing.Size(137, 21);
            this.billNo2.TabIndex = 71;
            this.billNo2.Visible = false;
            // 
            // billNo
            // 
            this.billNo.Location = new System.Drawing.Point(89, 29);
            this.billNo.Name = "billNo";
            this.billNo.ReadOnly = true;
            this.billNo.Size = new System.Drawing.Size(137, 21);
            this.billNo.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "رقم الفاتورة";
            // 
            // searchForSuppliersButton
            // 
            this.searchForSuppliersButton.Location = new System.Drawing.Point(656, 23);
            this.searchForSuppliersButton.Name = "searchForSuppliersButton";
            this.searchForSuppliersButton.Size = new System.Drawing.Size(100, 30);
            this.searchForSuppliersButton.TabIndex = 68;
            this.searchForSuppliersButton.Text = "عرض الموردين";
            this.searchForSuppliersButton.UseVisualStyleBackColor = true;
            this.searchForSuppliersButton.Click += new System.EventHandler(this.searchForSuppliersButton_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(423, 373);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 30);
            this.closeButton.TabIndex = 67;
            this.closeButton.Text = "الغاء";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(559, 373);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 30);
            this.refreshButton.TabIndex = 66;
            this.refreshButton.Text = "تحديث";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // saveAndPrintButton
            // 
            this.saveAndPrintButton.Location = new System.Drawing.Point(726, 372);
            this.saveAndPrintButton.Name = "saveAndPrintButton";
            this.saveAndPrintButton.Size = new System.Drawing.Size(100, 30);
            this.saveAndPrintButton.TabIndex = 65;
            this.saveAndPrintButton.Text = "اعتماد وطباعة ";
            this.saveAndPrintButton.UseVisualStyleBackColor = true;
            this.saveAndPrintButton.Click += new System.EventHandler(this.saveAndPrintButton_Click);
            // 
            // totalPriceBeforeDiscount
            // 
            this.totalPriceBeforeDiscount.Location = new System.Drawing.Point(30, 340);
            this.totalPriceBeforeDiscount.Name = "totalPriceBeforeDiscount";
            this.totalPriceBeforeDiscount.ReadOnly = true;
            this.totalPriceBeforeDiscount.Size = new System.Drawing.Size(137, 21);
            this.totalPriceBeforeDiscount.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "المبلغ الاجمالي";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(30, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 204);
            this.dataGridView1.TabIndex = 55;
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
            this.Column5.HeaderText = "التكلفة";
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
            // billType
            // 
            this.billType.FormattingEnabled = true;
            this.billType.Items.AddRange(new object[] {
            "نقدي ",
            "اجل"});
            this.billType.Location = new System.Drawing.Point(342, 71);
            this.billType.Name = "billType";
            this.billType.Size = new System.Drawing.Size(137, 21);
            this.billType.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(676, 65);
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            this.supplierName.Size = new System.Drawing.Size(203, 21);
            this.supplierName.TabIndex = 52;
            // 
            // supplierID
            // 
            this.supplierID.Location = new System.Drawing.Point(779, 23);
            this.supplierID.Multiline = true;
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(100, 20);
            this.supplierID.TabIndex = 51;
            this.supplierID.TextChanged += new System.EventHandler(this.supplierID_TextChanged);
            this.supplierID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplierID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "تاريخ الفاتورة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "نوع الفاتورة";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(913, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "اسم المورد";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(913, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "رقم المورد";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(489, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "رقم الفاتورة المشتراه";
            // 
            // originalPurchaseBillNo1
            // 
            this.originalPurchaseBillNo1.Location = new System.Drawing.Point(342, 27);
            this.originalPurchaseBillNo1.Name = "originalPurchaseBillNo1";
            this.originalPurchaseBillNo1.Size = new System.Drawing.Size(137, 21);
            this.originalPurchaseBillNo1.TabIndex = 74;
            // 
            // discount1
            // 
            this.discount1.Location = new System.Drawing.Point(29, 382);
            this.discount1.Name = "discount1";
            this.discount1.Size = new System.Drawing.Size(137, 21);
            this.discount1.TabIndex = 75;
            this.discount1.TextChanged += new System.EventHandler(this.discount_TextChanged);
            // 
            // purchasesBillForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 542);
            this.Controls.Add(this.discount1);
            this.Controls.Add(this.originalPurchaseBillNo1);
            this.Controls.Add(this.paidButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.billNo2);
            this.Controls.Add(this.billNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchForSuppliersButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.saveAndPrintButton);
            this.Controls.Add(this.totalPriceBeforeDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.billType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.supplierID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TheRestBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cashBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalPriceAfterDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "purchasesBillForm";
            this.Text = "فاتورة مشتريات";
            this.Load += new System.EventHandler(this.purchasesBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox totalPriceAfterDiscount;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox cashBox;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TheRestBox;
        public System.Windows.Forms.Button paidButton;
        public System.Windows.Forms.Button printButton;
        public System.Windows.Forms.TextBox billNo2;
        public System.Windows.Forms.TextBox billNo;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button searchForSuppliersButton;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button refreshButton;
        public System.Windows.Forms.Button saveAndPrintButton;
        public System.Windows.Forms.TextBox totalPriceBeforeDiscount;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        public System.Windows.Forms.ComboBox billType;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox supplierName;
        public System.Windows.Forms.TextBox supplierID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox originalPurchaseBillNo1;
        public System.Windows.Forms.TextBox discount1;
    }
}