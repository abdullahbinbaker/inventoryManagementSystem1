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
using DevExpress.XtraPrintingLinks;
using System.Drawing.Printing;
using DevExpress.XtraEditors;

namespace shalashShop
{
    public partial class salesBillForm : XtraForm
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        bool notlastColumn = true; //class level variable--- to check either last column is reached or not
        public static string BillNo, BillType, BillDate, CustomerName;
        List<itemInSalesBill> itemInTheBillList;
        decimal itemTotalPrice, BillTotalPrice, itemProfit;
        public static decimal Discount, SalesBillTotalAfterDiscount;
        long billNumber;

        #region the form's original methods
        public salesBillForm()
        {
            InitializeComponent();
        }

        private void salesBill_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Add();
            billDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("insertBillNo", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                        billNumber = Convert.ToInt64(reader["billNo"]);
                    billNumber++;
                    billNo.Text = billNumber.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal billTotalAfterDiscount = Convert.ToDecimal(totalPriceBeforeDiscount.Text) - Convert.ToDecimal(this.discount.Text);
                totalPriceAfterDiscount.Text = billTotalAfterDiscount.ToString();

            }
            catch (Exception ex)
            {
                totalPriceAfterDiscount.Text = "";
            }
        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("searchForCustomers", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@customerID", customerID.Text);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        customerName.Text = reader["customerName"].ToString();
                        customerName.ReadOnly = true;
                    }
                    else
                        customerName.Text = "";
                }
            }
            catch (Exception ex)
            {
                customerName.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAndPrintButton_Click(object sender, EventArgs e)
        {
            itemInTheBillList = new List<itemInSalesBill>();
            decimal BillProfitBeforeDiscount = 0;
            decimal BillProfitAfterDiscount = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                itemInTheBillList.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value)));
                BillProfitBeforeDiscount += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
            }
            BillProfitAfterDiscount = (BillProfitBeforeDiscount - Convert.ToDecimal(discount.Text));
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("addSalesBill", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@billType", billType.Text);
                    cmd2.Parameters.AddWithValue("@billDate", dateTimePicker1.Value.ToShortDateString());
                    cmd2.Parameters.AddWithValue("@billTotalPrice", Convert.ToDecimal(totalPriceBeforeDiscount.Text));
                    cmd2.Parameters.AddWithValue("@customerName", customerName.Text);
                    cmd2.Parameters.AddWithValue("@salesmanName", salesmanName.Text);
                    cmd2.Parameters.AddWithValue("@salesBillAfterDiscount", totalPriceAfterDiscount.Text);
                    cmd2.Parameters.AddWithValue("@discount", discount.Text);
                    cmd2.Parameters.AddWithValue("@billProfitBeforeDiscount", BillProfitBeforeDiscount);
                    cmd2.Parameters.AddWithValue("@billProfitAfterDiscount", BillProfitAfterDiscount);
                    cmd2.ExecuteNonQuery();
                    for (int i = 0; i < itemInTheBillList.Count; i++)
                    {
                        SqlCommand cmd3 = new SqlCommand("insertIntoConTableItemAndBill", conn);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@billNo", itemInTheBillList[i].billNo);
                        cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillList[i].itemNo);
                        cmd3.Parameters.AddWithValue("@itemQantityInTheBill", itemInTheBillList[i].itemQuantityInTheBill);
                        cmd3.Parameters.AddWithValue("@itemPriceInTheBill", itemInTheBillList[i].itemPriceInTheBill);
                        cmd3.Parameters.AddWithValue("@itemTotalPriceInTheBill", itemInTheBillList[i].itemTotalPriceInTheBill);
                        cmd3.Parameters.AddWithValue("@itemProfitInTheBill", itemInTheBillList[i].itemProfitInTheBill);
                        cmd3.ExecuteNonQuery();

                    }

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            SalesBillTotalAfterDiscount = Convert.ToDecimal(totalPriceAfterDiscount.Text);
            try
            {

                using (salesBillPrintFrame frame2 = new salesBillPrintFrame(itemInTheBillList as List<itemInSalesBill>, billNo.Text, billType.Text, dateTimePicker1.Text, customerName.Text, totalPriceBeforeDiscount.Text, discount.Text, totalPriceAfterDiscount.Text))
                {
                    frame2.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refreshSalesBillForm();
        }

        private void paidButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("changeBillType", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@billNo", billNo2.Text);
                    cmd2.ExecuteNonQuery();
                    billType.Text = "نقدي";
                    itemInTheBillList = new List<itemInSalesBill>();

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        itemInTheBillList.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    }
                    BillNo = billNo2.Text;
                    BillDate = billDate.Text;
                    BillType = billType.Text;
                    if (totalPriceBeforeDiscount.Text != "")
                        BillTotalPrice = Convert.ToDecimal(totalPriceBeforeDiscount.Text);
                    if (customerName.Text != "")
                        CustomerName = customerName.Text;
                    if (discount.Text != "")
                        Discount = Convert.ToDecimal(discount.Text);
                    if (totalPriceAfterDiscount.Text != "")
                        SalesBillTotalAfterDiscount = Convert.ToDecimal(totalPriceAfterDiscount.Text);



                    using (DevFrmPrint frm2 = new DevFrmPrint())
                    {
                        frm2.PrintInvoice(itemInTheBillList);

                        frm2.ShowDialog();
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            itemInTheBillList = new List<itemInSalesBill>();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                itemInTheBillList.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            BillNo = billNo2.Text;
            BillDate = billDate.Text;
            BillType = billType.Text;
            if (totalPriceBeforeDiscount.Text != "")
                BillTotalPrice = Convert.ToDecimal(totalPriceBeforeDiscount.Text);
            if (customerName.Text != "")
                CustomerName = customerName.Text;
            if (discount.Text != "")
                Discount = Convert.ToDecimal(discount.Text);
            if (totalPriceAfterDiscount.Text != "")
                SalesBillTotalAfterDiscount = Convert.ToDecimal(totalPriceAfterDiscount.Text);

            try
            {
                using (DevFrmPrint frm2 = new DevFrmPrint())
                {
                    frm2.PrintInvoice(itemInTheBillList);
                    frm2.ShowDialog();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void searchForCustomers_Click_1(object sender, EventArgs e)
        {
            new SearchForCustomersForm().Show();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            int keyPosition = 0;
            try
            {
                if (e.KeyCode == Keys.Enter && dataGridView1.CurrentCell != dataGridView1.CurrentRow.Cells[5]) //if not last column move to nex
                {
                    if (dataGridView1.CurrentCell == dataGridView1.CurrentRow.Cells[0])
                    {
                        using (SqlConnection conn = new SqlConnection(conn1))
                        {
                            conn.Open();
                            SqlCommand cmd2 = new SqlCommand("retrieveItemInformation", conn);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@itemNo", dataGridView1.CurrentRow.Cells[0].Value);
                            SqlDataReader reader = cmd2.ExecuteReader();
                            if (reader.Read())
                            {
                                dataGridView1.CurrentRow.Cells[1].Value = reader["itemNameArabic"].ToString();
                                dataGridView1.CurrentRow.Cells[2].Value = reader["currentInventory"];
                                dataGridView1.CurrentRow.Cells[3].Value = reader["price1"].ToString();
                                dataGridView1.CurrentRow.Cells[6].Value = reader["currentCost"].ToString();
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("الصنف غير موجود هل تريد اضافته ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (result == DialogResult.Yes)
                                {
                                    itemInformation information = new itemInformation();
                                    information.Show();
                                    information.itemNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                                    dataGridView1.CurrentRow.Cells[0].Value = "";
                                }
                                else
                                {
                                    dataGridView1.CurrentRow.Cells[0].Value = "";
                                    keyPosition = 1;
                                }
                            }

                        }

                    }
                    if (keyPosition == 0)
                        SendKeys.Send("{right}");
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    itemTotalPrice = Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                    dataGridView1.CurrentRow.Cells[5].Value = itemTotalPrice.ToString();

                    //calculating the item profit
                    itemProfit = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value) - (Convert.ToDecimal(dataGridView1.CurrentRow.Cells[6].Value) * Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value));
                    dataGridView1.CurrentRow.Cells[7].Value = itemProfit;
                    //=================
                    BillTotalPrice += itemTotalPrice;
                    totalPriceBeforeDiscount.Text = BillTotalPrice.ToString();
                    discount.Text = "0.0";
                    totalPriceAfterDiscount.Text = BillTotalPrice.ToString();
                    SendKeys.Send("{home}");//go to first column
                    notlastColumn = true;
                    var row = new DataGridViewRow();
                    dataGridView1.Rows.Add(row);
                }


            }
            catch (Exception ex)
            {

            }
        }

        private void customerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cashBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal theRest = Convert.ToDecimal(cashBox.Text) - Convert.ToDecimal(totalPriceAfterDiscount.Text);
                TheRestBox.Text = theRest.ToString();
            }
            catch (Exception ex)
            {
                TheRestBox.Text = "";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshSalesBillForm();
        }
        #endregion

        #region helping methods
        public void refreshSalesBillForm()
        {
            customerID.Text = "";
            salesmanName.Text = "";
            billNo.Text = "";
            billType.Text = "";
            billDate.Text = "";
            totalPriceAfterDiscount.Text = "";
            customerName.Text = "";
            totalPriceBeforeDiscount.Text = "";
            discount.Text = "";
            cashBox.Text = "";
            TheRestBox.Text = "";
            dataGridView1.Rows.Clear();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Add();
            billDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("insertBillNo", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                    billNumber = Convert.ToInt64(reader["billNo"]);
                billNumber++;
                billNo.Text = billNumber.ToString();
            }

        }
        #endregion
    }

}
