namespace shalashShop
{
    partial class InsertDataFromExcelSheetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sheetNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Format of Excel Folder Directory must be like this ( C:\\\\Users\\\\foledrName.xlsx )" +
    "";
            // 
            // directory
            // 
            this.directory.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.directory.Location = new System.Drawing.Point(375, 20);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(455, 20);
            this.directory.TabIndex = 8;
            this.directory.Text = "Enter the excel file directory";
            // 
            // loadButton
            // 
            this.loadButton.Enabled = false;
            this.loadButton.Location = new System.Drawing.Point(59, 62);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(274, 23);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load Data To Database";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 401);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Read From Excel Sheet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sheetNameTextBox
            // 
            this.sheetNameTextBox.ForeColor = System.Drawing.Color.Turquoise;
            this.sheetNameTextBox.Location = new System.Drawing.Point(836, 21);
            this.sheetNameTextBox.Name = "sheetNameTextBox";
            this.sheetNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.sheetNameTextBox.TabIndex = 10;
            this.sheetNameTextBox.Text = "enter sheet name";
            // 
            // InsertDataFromExcelSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1075, 521);
            this.Controls.Add(this.sheetNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "InsertDataFromExcelSheetForm";
            this.Text = "InsertDataFromExcelSheet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sheetNameTextBox;
    }
}