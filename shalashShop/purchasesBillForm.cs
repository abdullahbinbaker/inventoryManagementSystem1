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
    public partial class purchasesBillForm : XtraForm
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        bool notlastColumn = true; //class level variable--- to check either last column is reached or not
        decimal itemTotalPrice, BillTotalPrice;
        List<itemInPurchaseBill> itemInTheBillList;
        public static string PurchaseBillNo, PurchaseBillType, PurchaseBillDate, PurchasesupplierName;
        public static int OriginalPurchaseBillNo;
        public static decimal Discount, PurchaseBillTotalAfterDiscount;
        long billNumber;

        #region the form's original methods 
        public purchasesBillForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    else
                        supplierName.Text = "";
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
                decimal billTotalAfterDiscount = Convert.ToDecimal(totalPriceBeforeDiscount.Text) - Convert.ToDecimal(this.discount1.Text);
                totalPriceAfterDiscount.Text = billTotalAfterDiscount.ToString();
            }
            catch (Exception ex)
            {
                totalPriceAfterDiscount.Text = "";
            }
        }


        private void purchasesBill_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Add();
            dateTimePicker1.Value = DateTime.Today;
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("insertPurchaseBillNo", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                        billNumber = Convert.ToInt64(reader["billNo"]);
                    billNumber++;
                    billNo.Text = billNumber.ToString();
                }
            }
            catch (Exception exee)
            {
                MessageBox.Show(exee.Message);
            }
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

                                dataGridView1.CurrentRow.Cells[3].Value = reader["lastCost"].ToString();
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
                    BillTotalPrice += itemTotalPrice;
                    totalPriceBeforeDiscount.Text = BillTotalPrice.ToString();
                    discount1.Text = "0.0";
                    totalPriceAfterDiscount.Text = BillTotalPrice.ToString();
                    SendKeys.Send("{home}");//go to first column
                    notlastColumn = true;
                    var row = new DataGridViewRow();
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            refreshPurchasesBillForm();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAndPrintButton_Click(object sender, EventArgs e)
        {
            itemInTheBillList = new List<itemInPurchaseBill>();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                itemInTheBillList.Add(new itemInPurchaseBill(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("addPurchaseBill", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@billType", billType.Text);
                    cmd2.Parameters.AddWithValue("@billDate", dateTimePicker1.Value.ToShortDateString());
                    cmd2.Parameters.AddWithValue("@billTotalPrice", Convert.ToDecimal(totalPriceBeforeDiscount.Text));
                    cmd2.Parameters.AddWithValue("@supplierName", supplierName.Text);
                    cmd2.Parameters.AddWithValue("@originalPurchaseBillNo", Convert.ToInt32(originalPurchaseBillNo1.Text));
                    cmd2.Parameters.AddWithValue("@billTotalPriceAfterDiscount", Convert.ToDecimal(totalPriceAfterDiscount.Text));
                    cmd2.Parameters.AddWithValue("@discount", Convert.ToDecimal(discount1.Text));
                    cmd2.ExecuteNonQuery();
                    for (int i = 0; i < itemInTheBillList.Count; i++)
                    {
                        SqlCommand cmd3 = new SqlCommand("insertIntoConTableItemAndPurchaseBill", conn);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@billNo", billNo.Text);
                        cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillList[i].itemNo);
                        cmd3.Parameters.AddWithValue("@itemQantityInTheBill", itemInTheBillList[i].itemQuantityInTheBill);
                        cmd3.Parameters.AddWithValue("@itemPriceInTheBill", itemInTheBillList[i].itemPriceInTheBill);
                        cmd3.Parameters.AddWithValue("@itemTotalPriceInTheBill", itemInTheBillList[i].itemTotalPriceInTheBill);
                        cmd3.ExecuteNonQuery();
                    }
                }
                using (PurchaseBillPrintFrame frame1 = new PurchaseBillPrintFrame(itemInTheBillList as List<itemInPurchaseBill>, billNo.Text, billType.Text, dateTimePicker1.Text, supplierName.Text, totalPriceBeforeDiscount.Text, discount1.Text, totalPriceAfterDiscount.Text))
                {
                    frame1.ShowDialog();
                }
            }
            catch (Exception exe1)
            {
                MessageBox.Show(exe1.Message);
            }
            refreshPurchasesBillForm();
        }

        private void searchForSuppliersButton_Click_1(object sender, EventArgs e)
        {
            new SearchForSuppliersForm().Show();
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
                    else
                        supplierName.Text = "";
                }
            }
            catch (Exception ex)
            {

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

        private void printButton_Click_1(object sender, EventArgs e)
        {
            itemInTheBillList = new List<itemInPurchaseBill>();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                itemInTheBillList.Add(new itemInPurchaseBill(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            PurchaseBillNo = billNo2.Text;
            PurchaseBillDate = dateTimePicker1.Value.ToString();
            PurchaseBillType = billType.Text;
            PurchasesupplierName = supplierName.Text;
            OriginalPurchaseBillNo = Convert.ToInt32(originalPurchaseBillNo1.Text);
            Discount = Convert.ToDecimal(discount1.Text);
            PurchaseBillTotalAfterDiscount = Convert.ToDecimal(totalPriceAfterDiscount.Text);
            try
            {
                using (DevFrmPrint frm2 = new DevFrmPrint())
                {
                    frm2.PrintPurchaseBill(itemInTheBillList);
                    frm2.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paidButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("changePurchaseBillType", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@billNo", billNo2.Text);
                    cmd2.ExecuteNonQuery();
                    billType.Text = "نقدي";
                    itemInTheBillList = new List<itemInPurchaseBill>();

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        itemInTheBillList.Add(new itemInPurchaseBill(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    }
                    PurchaseBillNo = billNo2.Text;
                    PurchaseBillDate = dateTimePicker1.Value.ToString();
                    PurchaseBillType = billType.Text;
                    PurchasesupplierName = supplierName.Text;
                    OriginalPurchaseBillNo = Convert.ToInt32(originalPurchaseBillNo1.Text);
                    Discount = Convert.ToDecimal(discount1.Text);
                    PurchaseBillTotalAfterDiscount = Convert.ToDecimal(totalPriceAfterDiscount.Text);

                    using (DevFrmPrint frm2 = new DevFrmPrint())
                    {
                        frm2.PrintPurchaseBill(itemInTheBillList);
                        frm2.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supplierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region helping methods
        public void refreshPurchasesBillForm()
        {
            supplierID.Text = "";
            supplierName.Text = "";
            originalPurchaseBillNo1.Text = "";
            billType.Text = "";
            totalPriceBeforeDiscount.Text = "";
            discount1.Text = "";
            totalPriceAfterDiscount.Text = "";
            cashBox.Text = "";
            TheRestBox.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Add();
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("insertPurchaseBillNo", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                    billNumber = Convert.ToInt64(reader["billNo"]);
                billNumber++;
                billNo.Text = billNumber.ToString();
            }
            #endregion
        }
    }


    #region itemInPurchaseBill class
    public class itemInPurchaseBill
    {

        public int itemQuantityInTheBill { get; set; }
        public decimal itemPriceInTheBill { get; set; }
        public decimal itemTotalPriceInTheBill { get; set; }
        public string itemNo { get; set; }
        public string itemNameInArabic { get; set; }

        public itemInPurchaseBill(string itemNo, int quantity, decimal itemPriceInTheBill, decimal itemTotalPriceInTheBill, string itemNameInArabic)
        {
            this.itemNo = itemNo;
            this.itemPriceInTheBill = itemPriceInTheBill;
            itemQuantityInTheBill = quantity;
            this.itemTotalPriceInTheBill = itemTotalPriceInTheBill;
            this.itemNameInArabic = itemNameInArabic;
        }

    }
    #endregion

}
