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
    public partial class PurchasesReportForm : XtraForm
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        List<BillShortInformation> PurchaseBillShortInformationList;

        #region the form's orginal methods
        public PurchasesReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseBillShortInformationList = new List<BillShortInformation>();
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    if (radioButton1.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForPurchaseBill", conn);
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
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["billTotalPriceAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["supplierName"].ToString();
                            PurchaseBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;
                        }

                    }
                    else if (radioButton2.Checked)
                    {

                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForPurchaseBill", conn);
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
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["billTotalPriceAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["supplierName"].ToString();
                            PurchaseBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;

                        }
                    }
                    else if (radioButton3.Checked)
                    {

                        dataGridView2.Rows.Clear();
                        SqlCommand cmd = new SqlCommand("searchForPurchaseBill2", conn);
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
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["billTotalPriceAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["supplierName"].ToString();
                            PurchaseBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;

                        }


                    }

                    else if (radioButton5.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForPurchaseBill", conn);
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
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["billTotalPriceAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["supplierName"].ToString();
                            PurchaseBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;

                        }
                    }
                    else if (radioButton4.Checked)
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
                        //purchase.label2.Visible = false;
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
                    else if (radioButton6.Checked)
                    {

                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForPurchaseBill", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@originalBillNo", textBox1.Text);
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
                            dataGridView2.Rows[rowIndex].Cells[6].Value = reader["billTotalPriceAfterDiscount"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[7].Value = reader["supplierName"].ToString();
                            PurchaseBillShortInformationList.Add(new BillShortInformation(dataGridView2.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[5].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView2.Rows[rowIndex].Cells[7].Value.ToString()));
                            rowIndex++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void supplierID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("searchForSupplier", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@supplierID", supplierID.Text);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        supplierName.Text = reader["supplierName"].ToString();
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
            textBox1.Hide();
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
            textBox1.Hide();
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
            button2.Hide();
            textBox1.Hide();
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
            textBox1.Hide();
            BillTypeComboBox.Hide();


        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            itemNo.Text = "";
            itemNo.Hide();
            billID.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            supplierID.Hide();
            supplierName.Hide();
            dataGridView2.Show();
            BillTypeComboBox.Show();
            textBox1.Hide();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            itemNo.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            dataGridView2.Show();
            billID.Hide();
            supplierID.Hide();
            supplierName.Hide();
            BillTypeComboBox.Hide();
            textBox1.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (DevFrmPrint frm3 = new DevFrmPrint())
            {
                frm3.PrintPurchaseReoprt(PurchaseBillShortInformationList);
                frm3.ShowDialog();
            }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    purchasesBillForm purchase = new purchasesBillForm();
                    purchase.supplierID.Visible = false;
                    purchase.discount1.Visible = true;
                    purchase.discount1.ReadOnly = true;
                    purchase.cashBox.Visible = false;
                    purchase.TheRestBox.Visible = false;
                    purchase.label9.Visible = false;
                    //purchase.label1.Visible = true;
                    purchase.label10.Visible = false;
                    purchase.searchForSuppliersButton.Visible = false;
                    purchase.originalPurchaseBillNo1.ReadOnly = true;
                    purchase.billType.Enabled = false;
                    purchase.dateTimePicker1.Enabled = false;
                    purchase.billNo.Visible = false;
                    purchase.billNo2.Visible = true;
                    purchase.billNo2.ReadOnly = true;
                    purchase.saveAndPrintButton.Visible = false;
                    purchase.printButton.Visible = true;
                    purchase.saveAndPrintButton.Visible = false;
                    purchase.refreshButton.Visible = false;
                    //purchase.label2.Visible = false;
                    purchase.totalPriceAfterDiscount.Visible = true;
                    purchase.dataGridView1.Enabled = false;
                    purchase.dataGridView1.Rows.Clear();

                    SqlCommand cmd = new SqlCommand("searchForPurchaseBill2", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@billNo", dataGridView2.CurrentRow.Cells[1].Value);
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
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

    }
    #endregion

    #region billShortInformation class
    public class BillShortInformation
    {
        public string BillNo { get; set; }
        public string BillType { get; set; }
        public string BillDate { get; set; }
        public string BillTotalPrice { get; set; }
        public string discount { get; set; }
        public string BillAfterDiscount { get; set; }
        public string CustomerOrSupplierName { get; set; }

        public BillShortInformation(string billNo, string billType, string billDate, string billTotalPrice, string discount, string billAfterDiscount, string customerOrSupplierName)
        {
            BillNo = billNo;
            BillType = billType;
            BillDate = billDate;
            BillTotalPrice = billTotalPrice;
            this.discount = discount;
            BillAfterDiscount = billAfterDiscount;
            CustomerOrSupplierName = customerOrSupplierName;
        }

    }
    #endregion

}



