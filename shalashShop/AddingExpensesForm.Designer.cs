namespace shalashShop
{
    partial class AddingExpensesForm
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
            this.savingButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expensesNo = new System.Windows.Forms.TextBox();
            this.expensesName = new System.Windows.Forms.TextBox();
            this.expensesPrice = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savingButton
            // 
            this.savingButton.Location = new System.Drawing.Point(343, 273);
            this.savingButton.Name = "savingButton";
            this.savingButton.Size = new System.Drawing.Size(115, 23);
            this.savingButton.TabIndex = 1;
            this.savingButton.Text = "اعتماد";
            this.savingButton.UseVisualStyleBackColor = true;
            this.savingButton.Click += new System.EventHandler(this.SavingButton_Click_1);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(189, 273);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(115, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "إفراغ الخانات";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "رقم السند";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "شرح المصروف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "السعر";
            // 
            // expensesNo
            // 
            this.expensesNo.Location = new System.Drawing.Point(358, 31);
            this.expensesNo.Name = "expensesNo";
            this.expensesNo.ReadOnly = true;
            this.expensesNo.Size = new System.Drawing.Size(100, 20);
            this.expensesNo.TabIndex = 10;
            // 
            // expensesName
            // 
            this.expensesName.Location = new System.Drawing.Point(51, 72);
            this.expensesName.Multiline = true;
            this.expensesName.Name = "expensesName";
            this.expensesName.Size = new System.Drawing.Size(407, 20);
            this.expensesName.TabIndex = 11;
            // 
            // expensesPrice
            // 
            this.expensesPrice.Location = new System.Drawing.Point(358, 121);
            this.expensesPrice.Name = "expensesPrice";
            this.expensesPrice.Size = new System.Drawing.Size(100, 20);
            this.expensesPrice.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(40, 273);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(118, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "إغلاق";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddingExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(585, 319);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.expensesPrice);
            this.Controls.Add(this.expensesName);
            this.Controls.Add(this.expensesNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.savingButton);
            this.Name = "AddingExpensesForm";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savingButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expensesNo;
        private System.Windows.Forms.TextBox expensesName;
        private System.Windows.Forms.TextBox expensesPrice;
        private System.Windows.Forms.Button closeButton;
    }
}