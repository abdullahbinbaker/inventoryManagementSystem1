namespace shalashShop
{
    partial class sellingReturnsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billNo = new System.Windows.Forms.TextBox();
            this.salesmanName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.billDate = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.billType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.billTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BillTotalPriceAfterDiscount2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.billtotalPriceBeforeDiscount2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 215);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ر م";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم الصنف";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الصنف";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الكمية";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "السعر";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الإجمالي";
            this.Column7.Name = "Column7";
            // 
            // billNo
            // 
            this.billNo.Location = new System.Drawing.Point(765, 29);
            this.billNo.Name = "billNo";
            this.billNo.Size = new System.Drawing.Size(137, 21);
            this.billNo.TabIndex = 32;
            // 
            // salesmanName
            // 
            this.salesmanName.Location = new System.Drawing.Point(37, 32);
            this.salesmanName.Name = "salesmanName";
            this.salesmanName.ReadOnly = true;
            this.salesmanName.Size = new System.Drawing.Size(206, 21);
            this.salesmanName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "تاريخ الفاتورة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "اسم البائع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "رقم الفاتورة";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 48;
            this.button3.Text = "الغاء";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 47;
            this.button2.Text = "تحديث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 46;
            this.button1.Text = "اعتماد وطباعة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // billDate
            // 
            this.billDate.Location = new System.Drawing.Point(381, 37);
            this.billDate.Name = "billDate";
            this.billDate.ReadOnly = true;
            this.billDate.Size = new System.Drawing.Size(173, 21);
            this.billDate.TabIndex = 49;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(35, 80);
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Size = new System.Drawing.Size(206, 21);
            this.customerName.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "اسم العميل";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(762, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 30);
            this.button4.TabIndex = 52;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // billType
            // 
            this.billType.Location = new System.Drawing.Point(381, 78);
            this.billType.Name = "billType";
            this.billType.ReadOnly = true;
            this.billType.Size = new System.Drawing.Size(173, 21);
            this.billType.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "نوع الفاتورة ";
            // 
            // billTotal
            // 
            this.billTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billTotal.ForeColor = System.Drawing.Color.Cornsilk;
            this.billTotal.Location = new System.Drawing.Point(19, 386);
            this.billTotal.Name = "billTotal";
            this.billTotal.ReadOnly = true;
            this.billTotal.Size = new System.Drawing.Size(136, 21);
            this.billTotal.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "اجمالي الفاتورة قبل التعديل ";
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(18, 549);
            this.rest.Name = "rest";
            this.rest.ReadOnly = true;
            this.rest.Size = new System.Drawing.Size(138, 21);
            this.rest.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "المتبقي";
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(18, 514);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(138, 21);
            this.cash.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 514);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "نقدي";
            // 
            // BillTotalPriceAfterDiscount2
            // 
            this.BillTotalPriceAfterDiscount2.Location = new System.Drawing.Point(19, 484);
            this.BillTotalPriceAfterDiscount2.Name = "BillTotalPriceAfterDiscount2";
            this.BillTotalPriceAfterDiscount2.ReadOnly = true;
            this.BillTotalPriceAfterDiscount2.Size = new System.Drawing.Size(137, 21);
            this.BillTotalPriceAfterDiscount2.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(242, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "صافي الاجمالي";
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(19, 459);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(137, 21);
            this.discount.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "الخصم";
            // 
            // billtotalPriceBeforeDiscount2
            // 
            this.billtotalPriceBeforeDiscount2.Location = new System.Drawing.Point(18, 432);
            this.billtotalPriceBeforeDiscount2.Name = "billtotalPriceBeforeDiscount2";
            this.billtotalPriceBeforeDiscount2.ReadOnly = true;
            this.billtotalPriceBeforeDiscount2.Size = new System.Drawing.Size(137, 21);
            this.billtotalPriceBeforeDiscount2.TabIndex = 89;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(246, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "المبلغ الاجمالي";
            // 
            // sellingReturnsForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 591);
            this.Controls.Add(this.billTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BillTotalPriceAfterDiscount2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.billtotalPriceBeforeDiscount2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.billType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.billDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.billNo);
            this.Controls.Add(this.salesmanName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "sellingReturnsForm";
            this.Text = "سند مردود بيع";
            this.Load += new System.EventHandler(this.sellingReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox billNo;
        private System.Windows.Forms.TextBox salesmanName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox billDate;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox billType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox billTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BillTotalPriceAfterDiscount2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox billtotalPriceBeforeDiscount2;
        private System.Windows.Forms.Label label15;
    }
}