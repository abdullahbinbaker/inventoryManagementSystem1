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
using DevExpress.XtraEditors;


namespace shalashShop
{
    public partial class CalculatingTheProfitsForm : Form
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        /// <summary>
        /// totalPriceBeforeDiscount: contains the total sales before discount
        /// //totalPriceAfterDiscount: contains the total sales after discount
        /// //totalProfitBeforeDiscount: contains the total profits before discount
        /// //totalProfitAfterDiscount: contains the total profits after discount
        /// //expenses: contains the expenses
        /// // netProfits:contains the profit of the sales int this period
        /// </summary>
        decimal totalPriceBeforeDiscount, totalPriceAfterDiscount, totalProfitBeforeDiscount, totalProfitAfterDiscount, expenses, netProfits;

        #region the form's original methods

        private void searchButton_Click(object sender, EventArgs e)
        {

            totalProfitBeforeDiscount = 0;
            totalProfitAfterDiscount = 0;
            totalPriceBeforeDiscount = 0;
            totalPriceAfterDiscount = 0;
            expenses = 0;
            netProfits = 0;

            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                dataGridView1.Rows.Clear();
                SqlCommand cmd2 = new SqlCommand("ProfitReport", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@firstDate", dateTimePicker1.Value);
                cmd2.Parameters.AddWithValue("@secondDate", dateTimePicker2.Value);
                SqlDataReader reader = cmd2.ExecuteReader();
                int rowIndex = 0;
                while (reader.Read())
                {
                    var row = new DataGridViewRow();
                    dataGridView1.Rows.Add(row);
                    dataGridView1.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = reader["billNo"].ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = reader["billDate"].ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = reader["billTotalPrice"].ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = reader["billProfitBeforeDiscount"].ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = reader["discount"].ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = reader["salesBillTotalAfterDiscount"].ToString();
                    dataGridView1.Rows[rowIndex].Cells[7].Value = reader["billProfitAfterDiscount"].ToString();
                    rowIndex++;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value != "")
                        totalPriceBeforeDiscount += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    if (dataGridView1.Rows[i].Cells[6].Value != "")
                        totalPriceAfterDiscount += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                    if (dataGridView1.Rows[i].Cells[4].Value != "")
                        totalProfitBeforeDiscount += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    if (dataGridView1.Rows[i].Cells[7].Value != "")
                        totalProfitAfterDiscount += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                }
                reader.Close();
                conn.Close();
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();

                    SqlCommand cmd3 = new SqlCommand("calculateExpenses", conn);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@startDate", Convert.ToDateTime(dateTimePicker1.Value));
                    cmd3.Parameters.AddWithValue("@endDate", Convert.ToDateTime(dateTimePicker2.Value));
                    expenses = Convert.ToDecimal(cmd3.ExecuteScalar());
                }
            }
            catch (Exception exe)
            {
                expenses = 0;
            }
            netProfits = totalProfitAfterDiscount - expenses;
            pricebefore.Text = totalPriceBeforeDiscount.ToString();
            priceAfter.Text = totalPriceAfterDiscount.ToString();
            profitBefore.Text = totalProfitBeforeDiscount.ToString();
            profitAfter.Text = totalProfitAfterDiscount.ToString();
            Expenses.Text = expenses.ToString();
            NetProfits.Text = netProfits.ToString();
        }

        public CalculatingTheProfitsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                salesBillForm sales = new salesBillForm();
                sales.customerID.Visible = false;
                sales.searchForCustomers.Visible = false;
                sales.printButton.Visible = true;
                sales.label11.Visible = false;
                sales.saveAndPrintButton.Visible = false;
                sales.TheRestBox.Visible = false;
                // sales.label7.Visible = false;
                //sales.discount.Visible = false;
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
                sales.dataGridView1.Enabled = false;
                sales.saveAndPrintButton.Visible = false;

                sales.dataGridView1.Rows.Clear();
                SqlCommand cmd = new SqlCommand("searchForSalesBill2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@billNo", dataGridView1.CurrentRow.Cells[1].Value);
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
        }
        private void Profits_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }
        #endregion
    }
}
