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
    public partial class purchasesReturnForm : XtraForm
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        List<itemInSalesBill> itemInTheBillListBeforePurchaseReturn;
        List<itemInSalesBill> itemInTheBillListAfterPurchaseReturn;
        List<itemInSalesBill> itemInTheBillListAfterPurchaseReturn2;
        public static string BillNo, BillDate, BillType, SupplierName;
        decimal itemTotalPrice, BillTotalPrice2;

        #region the form's original methods 
        public purchasesReturnForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    dataGridView1.Rows.Clear();
                    SqlCommand cmd = new SqlCommand("searchForPurchaseBill2", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@billNo", billNo.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int rowIndex = 0;
                    if (reader.Read())
                    {
                        billDate.Text = reader["billDate"].ToString();
                        billType.Text = reader["billType"].ToString();
                        billTotalPrice.Text = reader["billTotalPrice"].ToString();
                        supplierName.Text = reader["supplierName"].ToString();
                        discount.Text = reader["discount"].ToString();
                        BillTotalPriceAfterDiscount2.Text = reader["billTotalPriceAfterDiscount"].ToString();

                        var row = new DataGridViewRow();
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNo"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemNameArabic"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemQuantityIntheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[4].Value = reader["itemPriceInTheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                        rowIndex++;
                    }
                    while (reader.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNo"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemNameArabic"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemQuantityIntheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[4].Value = reader["itemPriceInTheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                        rowIndex++;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            itemInTheBillListBeforePurchaseReturn = new List<itemInSalesBill>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                itemInTheBillListBeforePurchaseReturn.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }
            BillNo = billNo.Text;
            BillDate = billDate.Text;
            BillType = billType.Text;
            SupplierName = supplierName.Text;

            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[3]; try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    dataGridView1.Rows.Clear();
                    SqlCommand cmd = new SqlCommand("searchForPurchaseBill2", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@billNo", billNo.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int rowIndex = 0;
                    if (reader.Read())
                    {
                        billDate.Text = reader["billDate"].ToString();
                        billType.Text = reader["billType"].ToString();
                        billTotalPrice.Text = reader["billTotalPrice"].ToString();
                        supplierName.Text = reader["supplierName"].ToString();
                        discount.Text = reader["discount"].ToString();
                        BillTotalPriceAfterDiscount2.Text = reader["billTotalPriceAfterDiscount"].ToString();

                        var row = new DataGridViewRow();
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNo"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemNameArabic"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemQuantityIntheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[4].Value = reader["itemPriceInTheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                        rowIndex++;
                    }
                    while (reader.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNo"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemNameArabic"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader["itemQuantityIntheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[4].Value = reader["itemPriceInTheBill"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[5].Value = reader["itemTotalPriceInTheBill"].ToString();
                        rowIndex++;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            itemInTheBillListBeforePurchaseReturn = new List<itemInSalesBill>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                itemInTheBillListBeforePurchaseReturn.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }
            BillNo = billNo.Text;
            BillDate = billDate.Text;
            BillType = billType.Text;
            SupplierName = supplierName.Text;

            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[3];
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void saveAndPrintButton_Click(object sender, EventArgs e)
        {
            billTotalPrice.Text = "";
            discount.Text = "";
            BillTotalPriceAfterDiscount2.Text = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    for (int i = 0; i < itemInTheBillListBeforePurchaseReturn.Count; i++)
                    {
                        SqlCommand cmd3 = new SqlCommand("UpdateSellAndInventoryInPurchaseBillBeforePurchaseReturn", conn);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillListBeforePurchaseReturn[i].itemNo);
                        cmd3.Parameters.AddWithValue("@itemQantityInThePurchaseBill", itemInTheBillListBeforePurchaseReturn[i].itemQuantityInTheBill);

                        cmd3.ExecuteNonQuery();

                    }
                    itemInTheBillListAfterPurchaseReturn = new List<itemInSalesBill>();
                    itemInTheBillListAfterPurchaseReturn2 = new List<itemInSalesBill>();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        itemInTheBillListAfterPurchaseReturn.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    }

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        BillTotalPrice2 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    }

                    billtotalPriceBeforeDiscount2.Text = BillTotalPrice2.ToString();
                    for (int i = 0; i < itemInTheBillListAfterPurchaseReturn.Count; i++)
                    {
                        if (itemInTheBillListAfterPurchaseReturn[i].itemQuantityInTheBill > 0)
                        {
                            SqlCommand cmd3 = new SqlCommand("updateConTableItemAndPurchaseBill", conn);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@billTotalPrice", BillTotalPrice2);
                            cmd3.Parameters.AddWithValue("@billNo", billNo.Text);
                            cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillListAfterPurchaseReturn[i].itemNo);
                            cmd3.Parameters.AddWithValue("@itemQantityInTheBill", itemInTheBillListAfterPurchaseReturn[i].itemQuantityInTheBill);
                            cmd3.Parameters.AddWithValue("@itemPriceInTheBill", itemInTheBillListAfterPurchaseReturn[i].itemPriceInTheBill);
                            cmd3.Parameters.AddWithValue("@itemTotalPriceInTheBill", itemInTheBillListAfterPurchaseReturn[i].itemTotalPriceInTheBill);
                            cmd3.Parameters.AddWithValue("@discount", 0.0);
                            cmd3.Parameters.AddWithValue("@billpriceAfterDiscount", 0.0);
                            cmd3.ExecuteNonQuery();
                            itemInTheBillListAfterPurchaseReturn2.Add(new itemInSalesBill(itemInTheBillListAfterPurchaseReturn[i].billNo, itemInTheBillListAfterPurchaseReturn[i].itemNo, itemInTheBillListAfterPurchaseReturn[i].itemQuantityInTheBill, itemInTheBillListAfterPurchaseReturn[i].itemTotalPriceInTheBill, itemInTheBillListAfterPurchaseReturn[i].itemTotalPriceInTheBill, itemInTheBillListAfterPurchaseReturn[i].itemNameInArabic));
                        }
                        else
                        {
                            SqlCommand cmd3 = new SqlCommand("deleteFromConTableItemAndPurchaseBill", conn);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@billNo", billNo.Text);
                            cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillListAfterPurchaseReturn[i].itemNo);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (DevFrmPrint frm3 = new DevFrmPrint())
                {
                    frm3.PrintPurchaseReturn(itemInTheBillListAfterPurchaseReturn2);
                    frm3.ShowDialog();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            refresh();
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal billTotalAfterDiscount = Convert.ToDecimal(billtotalPriceBeforeDiscount2.Text) - Convert.ToDecimal(this.discount.Text);
                BillTotalPriceAfterDiscount2.Text = billTotalAfterDiscount.ToString();
            }
            catch (Exception ex)
            {
                BillTotalPriceAfterDiscount2.Text = "";
            }
        }

        private void cash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal theRest = Convert.ToDecimal(cash.Text) - Convert.ToDecimal(BillTotalPriceAfterDiscount2.Text);
                rest.Text = theRest.ToString();
            }
            catch (Exception ex)
            {
                rest.Text = "";
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    itemTotalPrice = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value) * Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
                    dataGridView1.CurrentRow.Cells[5].Value = itemTotalPrice.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion 

        #region helping methods
        public void refresh()
        {
            billNo.Text = "";
            billDate.Text = "";
            billType.Text = "";
            billTotalPrice.Text = "";
            supplierName.Text = "";
            dataGridView1.Rows.Clear();

        }
        #endregion
    }
}
