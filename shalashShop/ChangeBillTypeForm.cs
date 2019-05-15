using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shalashShop
{
    public partial class ChangeBillTypeForm : Form
    {
        /// <summary>
        /// THE CONNECTION STRING 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        #region the form's original methods 
        public ChangeBillTypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    if (radioButton2.Checked == true)
                    {
                        salesBillForm sales = new salesBillForm();
                        sales.customerID.Visible = false;
                        sales.searchForCustomers.Visible = false;
                        sales.printButton.Visible = true;
                        sales.label11.Visible = false;
                        sales.saveAndPrintButton.Visible = false;
                        sales.TheRestBox.Visible = false;
                        sales.discount.ReadOnly = true;
                        sales.TheRestBox.Visible = false;
                        sales.billNo.Visible = false;
                        sales.billNo2.Visible = true;
                        sales.salesmanName.Enabled = false;
                        sales.billType.Enabled = false;
                        sales.customerName.Enabled = false;
                        sales.totalPriceBeforeDiscount.Enabled = false;
                        sales.totalPriceAfterDiscount.Enabled = false;
                        sales.label9.Visible = false;
                        sales.label10.Visible = false;
                        sales.cashBox.Visible = false;
                        sales.refreshButton.Visible = false;
                        sales.paidButton.Visible = true;
                        sales.dataGridView1.Enabled = false;
                        sales.saveAndPrintButton.Visible = false;
                        sales.dataGridView1.Rows.Clear();
                        SqlCommand cmd = new SqlCommand("searchForSalesBill2", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@billNo", billID.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        int rowIndex = 0;
                        if (reader.Read())
                        {
                            sales.billNo2.Text = reader["billNo"].ToString();
                            sales.billDate.Text = reader["billDate"].ToString();
                            sales.billType.Text = reader["billType"].ToString();
                            sales.customerName.Text = reader["customerName"].ToString();
                            sales.salesmanName.Text = reader["salesmanName"].ToString();
                            sales.totalPriceBeforeDiscount.Text = reader["billTotalPrice"].ToString();
                            sales.discount.Text = reader["discount"].ToString();
                            sales.totalPriceAfterDiscount.Text = reader["salesBillTotalAfterDiscount"].ToString();
                            var row = new DataGridViewRow();
                            sales.dataGridView1.Rows.Add(row);
                            sales.dataGridView1.Rows[rowIndex].Cells[0].Value = reader["itemNo"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNameArabic"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemPriceInTheBill"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemQuantityIntheBill"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                            rowIndex++;
                        }
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            sales.dataGridView1.Rows.Add(row);
                            sales.dataGridView1.Rows[rowIndex].Cells[0].Value = reader["itemNo"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNameArabic"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemPriceInTheBill"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemQuantityIntheBill"].ToString();
                            sales.dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                            rowIndex++;
                        }
                        sales.Show();

                    }
                    else
                        if (radioButton1.Checked == true)
                    {
                        purchasesBillForm purchase = new purchasesBillForm();
                        purchase.supplierID.Visible = false;
                        purchase.discount1.Visible = true;
                        purchase.discount1.ReadOnly = true;
                        purchase.cashBox.Visible = false;
                        purchase.TheRestBox.Visible = false;
                        purchase.label9.Visible = false;
                        purchase.label10.Visible = false;
                        purchase.searchForSuppliersButton.Visible = false;
                        purchase.originalPurchaseBillNo1.ReadOnly = true;
                        //purchase.label1.Visible = false;
                        purchase.billType.Enabled = false;
                        purchase.dateTimePicker1.Enabled = false;
                        purchase.billNo.Visible = false;
                        purchase.billNo2.Visible = true;
                        purchase.billNo2.ReadOnly = true;
                        purchase.saveAndPrintButton.Visible = false;
                        purchase.printButton.Visible = true;
                        purchase.saveAndPrintButton.Visible = false;
                       // purchase.label2.Visible = false;
                        purchase.refreshButton.Visible = false;
                        purchase.paidButton.Visible = true;
                        purchase.totalPriceAfterDiscount.Visible = true;
                        purchase.dataGridView1.Enabled = false;
                        purchase.dataGridView1.Rows.Clear();
                        SqlCommand cmd = new SqlCommand("searchForPurchaseBill2", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@billNo", billID.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        int rowIndex = 0;
                        if (reader.Read())
                        {
                            purchase.billNo2.Text = reader["billNo"].ToString();
                            purchase.dateTimePicker1.Value = Convert.ToDateTime(reader["billDate"]);
                            purchase.billType.Text = reader["billType"].ToString();
                            purchase.supplierName.Text = reader["supplierName"].ToString();
                            purchase.totalPriceBeforeDiscount.Text = reader["billTotalPrice"].ToString();
                            purchase.totalPriceAfterDiscount.Text = reader["billTotalPriceAfterDiscount"].ToString();
                            purchase.discount1.Text = reader["discount"].ToString();
                            purchase.originalPurchaseBillNo1.Text = reader["originalPurchaseBillNo"].ToString();
                            var row = new DataGridViewRow();
                            purchase.dataGridView1.Rows.Add(row);
                            purchase.dataGridView1.Rows[rowIndex].Cells[0].Value = reader["itemNo"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNameArabic"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemPriceInTheBill"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemQuantityIntheBill"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                            rowIndex++;

                        }
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            purchase.dataGridView1.Rows.Add(row);
                            purchase.dataGridView1.Rows[rowIndex].Cells[0].Value = reader["itemNo"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNameArabic"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemPriceInTheBill"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemQuantityIntheBill"].ToString();
                            purchase.dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                            rowIndex++;
                        }
                        purchase.Show();
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        #endregion
        private void ChangeBillTypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
