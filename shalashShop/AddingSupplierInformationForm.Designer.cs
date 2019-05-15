namespace shalashShop
{
    partial class AddingSuppliersInfoForm
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.addingButton = new System.Windows.Forms.Button();
            this.supplierAddress = new System.Windows.Forms.TextBox();
            this.supplierPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.supplierID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(249, 252);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(108, 23);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "تحديث الصفحة";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addingButton
            // 
            this.addingButton.Location = new System.Drawing.Point(418, 252);
            this.addingButton.Name = "addingButton";
            this.addingButton.Size = new System.Drawing.Size(107, 23);
            this.addingButton.TabIndex = 18;
            this.addingButton.Text = "اضافة";
            this.addingButton.UseVisualStyleBackColor = true;
            this.addingButton.Click += new System.EventHandler(this.AddingButton_Click);
            // 
            // supplierAddress
            // 
            this.supplierAddress.Location = new System.Drawing.Point(74, 186);
            this.supplierAddress.Name = "supplierAddress";
            this.supplierAddress.Size = new System.Drawing.Size(451, 20);
            this.supplierAddress.TabIndex = 17;
            // 
            // supplierPhone
            // 
            this.supplierPhone.Location = new System.Drawing.Point(377, 128);
            this.supplierPhone.Name = "supplierPhone";
            this.supplierPhone.Size = new System.Drawing.Size(148, 20);
            this.supplierPhone.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "الهاتف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "اسم المورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقم المورد";
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(74, 85);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(451, 20);
            this.supplierName.TabIndex = 11;
            // 
            // supplierID
            // 
            this.supplierID.Location = new System.Drawing.Point(377, 40);
            this.supplierID.Name = "supplierID";
            this.supplierID.ReadOnly = true;
            this.supplierID.Size = new System.Drawing.Size(148, 20);
            this.supplierID.TabIndex = 10;
            // 
            // AddingSuppliersInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(623, 343);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addingButton);
            this.Controls.Add(this.supplierAddress);
            this.Controls.Add(this.supplierPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.supplierID);
            this.Name = "AddingSuppliersInfoForm";
            this.Text = "customers";
            this.Load += new System.EventHandler(this.customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addingButton;
        private System.Windows.Forms.TextBox supplierAddress;
        private System.Windows.Forms.TextBox supplierPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.TextBox supplierID;
    }
}