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
    public partial class salesReportForm : Form
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        /// <summary>
        /// a list to that contains the information that will print it in the report
        /// </summary>
        List<BillShortInformation> SalesBillShortInformationList;

        #region the form's original methods

        public salesReportForm()
        {
            InitializeComponent();
        }

        private void supplierID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("searchForCustomers", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@customerID", supplierID.Text);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        supplierName.Text = reader["customerName"].ToString();
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            itemNo.Hide();
            dateTimePicker1.Show();
            dateTimePicker2.Show();
            dataGridView2.Show();
            billID.Hide();
            supplierID.Hide();
            supplierName.Hide();
            BillTypeComboBox.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            supplierID.Text = "";
            supplierName.Text = "";
            itemNo.Hide();
            supplierName.Show();
            supplierID.Show();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            billID.Hide();
            dataGridView2.Show();
            BillTypeComboBox.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            itemNo.Text = "";
            itemNo.Show();
            billID.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            supplierID.Hide();
            supplierName.Hide();
            dataGridView2.Show();
            BillTypeComboBox.Hide();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            billID.Text = "";
            billID.Show();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            supplierID.Hide();
            supplierName.Hide();
            dataGridView2.Hide();
            itemNo.Hide();
            printButton.Hide();
            BillTypeComboBox.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            BillTypeComboBox.Show();
            dataGridView2.Rows.Clear();
            itemNo.Text = "";
            itemNo.Hide();
            billID.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            supplierID.Hide();
            supplierName.Hide();
            dataGridView2.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                    sales.discount.ReadOnly = true;
                    sales.TheRestBox.Visible = false;
                    sales.billNo.Visible = false;
                    sales.billNo2.Visible = true;
                    sales.refreshButton.Visible = false;
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
                    cmd.Parameters.AddWithValue("@billNo", dataGridView2.CurrentRow.Cells[1].Value);
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
                        //dataGridView1.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
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
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SalesBillShortInformationList = new List<BillShortInformation>();
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    if (radioButton1.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForSalesBill", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                        cmd2.Parameters.AddWithValue("@endDate", dateTimePicker2.Value);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView2.Rows.Add(row);
                            dataGridView2.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["billNo"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["billType"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["billDate"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[4].Value = reader["billTotalPrice"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[5].Value = reader["discount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["salesBillTotalAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["customerName"].ToString();

                            SalesBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;
                        }

                    }
                    else if (radioButton2.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForSalesBill", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@supplierName", supplierName.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView2.Rows.Add(row);
                            dataGridView2.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["billNo"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["billType"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["billDate"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[4].Value = reader["billTotalPrice"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[5].Value = reader["discount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["salesBillTotalAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["customerName"].ToString();
                            SalesBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        SqlCommand cmd = new SqlCommand("searchForSalesBill2", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemNo", itemNo.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView2.Rows.Add(row);
                            dataGridView2.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["billNo"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["billType"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["billDate"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[4].Value = reader["billTotalPrice"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[5].Value = reader["discount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["salesBillTotalAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["customerName"].ToString();
                            SalesBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;
                        }


                    }
                    else if (radioButton5.Checked == true)
                    {
                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForSalesBill", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@billType", BillTypeComboBox.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView2.Rows.Add(row);
                            dataGridView2.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["billNo"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["billType"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["billDate"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[4].Value = reader["billTotalPrice"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[5].Value = reader["discount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["salesBillTotalAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["customerName"].ToString();
                            SalesBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;
                        }
                    }
                    else if (radioButton4.Checked)
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
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (DevFrmPrint frm3 = new DevFrmPrint())
                {
                    frm3.PrintSalesReoprt(SalesBillShortInformationList);
                    frm3.ShowDialog();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        #endregion
    }
}
