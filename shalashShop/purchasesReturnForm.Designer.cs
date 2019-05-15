namespace shalashShop
{
    partial class purchasesReturnForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.saveAndPrintButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.billType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.billDate = new System.Windows.Forms.TextBox();
            this.billNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.billtotalPriceBeforeDiscount2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BillTotalPriceAfterDiscount2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(541, 395);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 30);
            this.closeButton.TabIndex = 74;
            this.closeButton.Text = "الغاء";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(704, 395);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 30);
            this.refreshButton.TabIndex = 73;
            this.refreshButton.Text = "تحديث";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // saveAndPrintButton
            // 
            this.saveAndPrintButton.Location = new System.Drawing.Point(872, 395);
            this.saveAndPrintButton.Name = "saveAndPrintButton";
            this.saveAndPrintButton.Size = new System.Drawing.Size(100, 30);
            this.saveAndPrintButton.TabIndex = 72;
            this.saveAndPrintButton.Text = "اعتماد وطباعة";
            this.saveAndPrintButton.UseVisualStyleBackColor = true;
            this.saveAndPrintButton.Click += new System.EventHandler(this.saveAndPrintButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(19, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 238);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ر م";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الصنف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الكمية";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "التكلفة";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الإجمالي";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // billTotalPrice
            // 
            this.billTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billTotalPrice.ForeColor = System.Drawing.Color.Cornsilk;
            this.billTotalPrice.Location = new System.Drawing.Point(19, 412);
            this.billTotalPrice.Name = "billTotalPrice";
            this.billTotalPrice.ReadOnly = true;
            this.billTotalPrice.Size = new System.Drawing.Size(136, 21);
            this.billTotalPrice.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "اجمالي الفاتورة قبل التعديل ";
            // 
            // billType
            // 
            this.billType.Location = new System.Drawing.Point(372, 74);
            this.billType.Name = "billType";
            this.billType.ReadOnly = true;
            this.billType.Size = new System.Drawing.Size(203, 21);
            this.billType.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "نوع الفاتورة ";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(756, 74);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(226, 30);
            this.searchButton.TabIndex = 83;
            this.searchButton.Text = "بحث";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(15, 71);
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            this.supplierName.Size = new System.Drawing.Size(206, 21);
            this.supplierName.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "اسم المورد";
            // 
            // billDate
            // 
            this.billDate.Location = new System.Drawing.Point(372, 23);
            this.billDate.Name = "billDate";
            this.billDate.ReadOnly = true;
            this.billDate.Size = new System.Drawing.Size(203, 21);
            this.billDate.TabIndex = 80;
            // 
            // billNo
            // 
            this.billNo.Location = new System.Drawing.Point(756, 34);
            this.billNo.Name = "billNo";
            this.billNo.Size = new System.Drawing.Size(137, 21);
            this.billNo.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "تاريخ الفاتورة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(920, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "رقم الفاتورة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "المبلغ الاجمالي بعد التعديل";
            // 
            // billtotalPriceBeforeDiscount2
            // 
            this.billtotalPriceBeforeDiscount2.Location = new System.Drawing.Point(9, 529);
            this.billtotalPriceBeforeDiscount2.Name = "billtotalPriceBeforeDiscount2";
            this.billtotalPriceBeforeDiscount2.ReadOnly = true;
            this.billtotalPriceBeforeDiscount2.Size = new System.Drawing.Size(137, 21);
            this.billtotalPriceBeforeDiscount2.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "الخصم";
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(15, 448);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(137, 21);
            this.discount.TabIndex = 65;
            this.discount.TextChanged += new System.EventHandler(this.discount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "صافي الاجمالي قبل التعديل";
            // 
            // BillTotalPriceAfterDiscount2
            // 
            this.BillTotalPriceAfterDiscount2.Location = new System.Drawing.Point(15, 486);
            this.BillTotalPriceAfterDiscount2.Name = "BillTotalPriceAfterDiscount2";
            this.BillTotalPriceAfterDiscount2.ReadOnly = true;
            this.BillTotalPriceAfterDiscount2.Size = new System.Drawing.Size(137, 21);
            this.BillTotalPriceAfterDiscount2.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "نقدي";
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(14, 567);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(138, 21);
            this.cash.TabIndex = 69;
            this.cash.TextChanged += new System.EventHandler(this.cash_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "المتبقي";
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(14, 602);
            this.rest.Name = "rest";
            this.rest.ReadOnly = true;
            this.rest.Size = new System.Drawing.Size(138, 21);
            this.rest.TabIndex = 71;
            // 
            // purchasesReturnForm
            // 
            this.ActiveGlowColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 640);
            this.Controls.Add(this.billTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.billDate);
            this.Controls.Add(this.billNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.saveAndPrintButton);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BillTotalPriceAfterDiscount2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.billtotalPriceBeforeDiscount2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "purchasesReturnForm";
            this.Text = "سند مردود مشتريات";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button saveAndPrintButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox billTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox billDate;
        private System.Windows.Forms.TextBox billNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox billtotalPriceBeforeDiscount2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BillTotalPriceAfterDiscount2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rest;
    }
}