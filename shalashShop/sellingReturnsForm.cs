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
    public partial class sellingReturnsForm : XtraForm
    {
        public sellingReturnsForm()
        {
            InitializeComponent();
        }
     string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
     List<itemInSalesBill> itemInTheBillListBeforeSalesReturn;
     List<itemInSalesBill> itemInTheBillListAfterSalesReturn;
     List<itemInSalesBill> itemInTheBillListAfterSalesReturn2;
     public static string BillNo, BillDate, BillType, CustomerName;
     decimal itemTotalPrice, BillTotalPrice2;
      
        private void button1_Click(object sender, EventArgs e)
        {
            billTotal.Text = "";
            discount.Text = "";
            BillTotalPriceAfterDiscount2.Text = "";
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                for (int i = 0; i < itemInTheBillListBeforeSalesReturn.Count; i++)
                {
                    SqlCommand cmd3 = new SqlCommand("UpdateSellAndInventoryInBillBeforeSellReturn", conn);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillListBeforeSalesReturn[i].itemNo);
                    cmd3.Parameters.AddWithValue("@itemQantityInTheBill", itemInTheBillListBeforeSalesReturn[i].itemQuantityInTheBill);

                    cmd3.ExecuteNonQuery();

                }
                itemInTheBillListAfterSalesReturn = new List<itemInSalesBill>();
                itemInTheBillListAfterSalesReturn2 = new List<itemInSalesBill>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    itemInTheBillListAfterSalesReturn.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value),dataGridView1.Rows[i].Cells[2].Value.ToString()));
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    BillTotalPrice2 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                }
                 billtotalPriceBeforeDiscount2.Text = BillTotalPrice2.ToString();
                for (int i = 0; i < itemInTheBillListAfterSalesReturn.Count; i++)
                {
                    if (itemInTheBillListAfterSalesReturn[i].itemQuantityInTheBill > 0)
                    {
                        SqlCommand cmd3 = new SqlCommand("updateConTableItemAndBill", conn);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@billTotalPrice", BillTotalPrice2);
                        cmd3.Parameters.AddWithValue("@billNo", billNo.Text);
                        cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillListAfterSalesReturn[i].itemNo);
                        cmd3.Parameters.AddWithValue("@itemQantityInTheBill", itemInTheBillListAfterSalesReturn[i].itemQuantityInTheBill);
                        cmd3.Parameters.AddWithValue("@itemPriceInTheBill", itemInTheBillListAfterSalesReturn[i].itemPriceInTheBill);
                        cmd3.Parameters.AddWithValue("@itemTotalPriceInTheBill", itemInTheBillListAfterSalesReturn[i].itemTotalPriceInTheBill);
                        cmd3.Parameters.AddWithValue("@discount", 0.0);
                        cmd3.Parameters.AddWithValue("@billpriceAfterDiscount", 0.0);
                        cmd3.ExecuteNonQuery();
                        itemInTheBillListAfterSalesReturn2.Add(new itemInSalesBill(itemInTheBillListAfterSalesReturn[i].billNo, itemInTheBillListAfterSalesReturn[i].itemNo, itemInTheBillListAfterSalesReturn[i].itemQuantityInTheBill, itemInTheBillListAfterSalesReturn[i].itemTotalPriceInTheBill, itemInTheBillListAfterSalesReturn[i].itemTotalPriceInTheBill, itemInTheBillListAfterSalesReturn[i].itemNameInArabic));
                    }
                    else
                    {
                        SqlCommand cmd3 = new SqlCommand("deleteFromConTableItemAndBill", conn);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@billNo", billNo.Text);
                        cmd3.Parameters.AddWithValue("@itemNo", itemInTheBillListAfterSalesReturn[i].itemNo);
                        cmd3.ExecuteNonQuery();
                    }

                }
            }
            using (DevFrmPrint frm4 = new DevFrmPrint())
            {
                frm4.PrintSalesReturn(itemInTheBillListAfterSalesReturn2);
                frm4.ShowDialog();
            }
            refresh();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            try { 

            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                dataGridView1.Rows.Clear();
                SqlCommand cmd = new SqlCommand("searchForSalesBill2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@billNo", billNo.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                int rowIndex = 0;
                if (reader.Read())
                {
                    billDate.Text = reader["billDate"].ToString();
                    billType.Text = reader["billType"].ToString();
                    billTotal.Text = reader["billTotalPrice"].ToString();
                    customerName.Text = reader["customerName"].ToString();
                    salesmanName.Text = reader["salesmanName"].ToString();
                    discount.Text = reader["discount"].ToString();
                    BillTotalPriceAfterDiscount2.Text = reader["salesBillTotalAfterDiscount"].ToString();

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
            itemInTheBillListBeforeSalesReturn = new List<itemInSalesBill>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                itemInTheBillListBeforeSalesReturn.Add(new itemInSalesBill(Convert.ToInt32(billNo.Text), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value), dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }
            BillNo = billNo.Text;
            BillDate = billDate.Text;
            BillType = billType.Text;
            CustomerName = customerName.Text;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[3];
        }catch(Exception ex)
            {
                DialogResult result = MessageBox.Show("رقم الفاتورة غير صحيح الرجاء ادخال رقم صحيح ");
                refresh();
            }
        }


        public void refresh()
        {
            billNo.Text = "";
            billDate.Text = "";
            billType.Text = "";
            //billTotalPrice.Text = "";
            customerName.Text = "";
            salesmanName.Text = "";
            billTotal.Text = "";
            billtotalPriceBeforeDiscount2.Text = "";
            discount.Text = "";
            BillTotalPriceAfterDiscount2.Text = "";
            cash.Text = "";
            rest.Text = "";
            dataGridView1.Rows.Clear();
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.Rows.Add();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sellingReturns_Load(object sender, EventArgs e)
        {

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

            }
        }

        //decimal itemTotalPrice ;
        //private void dataGridView1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        if (dataGridView1.CurrentCell.ColumnIndex == 4)
        //        {
        //            itemTotalPrice = Convert.ToInt16(dataGridView1.Rows[0].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[0].Cells[4].Value);
        //            dataGridView1.CurrentRow.Cells[5].Value = itemTotalPrice.ToString();
                    
        //        }
        //    }
        //}

        //bool notlastColumn = true; //class level variable--- to check either last column is reached or not
        //private void dataGridView1_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.ColumnCount - 1 == e.ColumnIndex) //if last column
        //    {
        //        KeyEventArgs forKeyDown = new KeyEventArgs(Keys.Enter);
        //       // notlastColumn = false;
        //        dataGridView1_KeyDown(dataGridView1, forKeyDown);

        //    }
        //    else
        //    {
        //        SendKeys.Send("{up}");
        //        SendKeys.Send("{right}");
        //    }
        //}

        //private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter &&  dataGridView1.CurrentCell !=dataGridView1.CurrentRow.Cells[5]) //if not last column move to nex
        //    {
        //        SendKeys.Send("{up}");
        //        SendKeys.Send("{right}");
        //    }
        //    else if (e.KeyCode == Keys.Enter)
        //    {
        //        SendKeys.Send("{home}");//go to first column
        //        notlastColumn = true;
        //        //var row = new DataGridViewRow();
        //        //dataGridView1.Rows.Add(row);
        //    }
        //}

       

    //    private void dataGridView1_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
    //    {
    //        if (e.ColumnIndex == 5)
    //{
    //    int value = (int)dataGridView1.CurrentRow.Cells["Column4"].Value * (int)dataGridView1.CurrentRow.Cells["Column5"].Value;
    //    dataGridView1.CurrentRow.Cells["Column7"].Value = value;
    //}
    //    }

    
       

      
    }
}
