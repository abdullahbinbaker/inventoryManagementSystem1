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
using System.Configuration;

namespace shalashShop
{
    public partial class itemInformation : Form
    {
        #region the form's original methods 
        /// <summary>
        /// connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        /// <summary>
        /// the item Number
        /// </summary>
        public static String itemNo2;

        public itemInformation()
        {
            InitializeComponent();
        }
        private void searchButton_Click_1(object sender, EventArgs e)
        {
            retrieveItemInformation();

        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            addItemsInformation();
            refreshForm1();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshForm1();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UpdateItemInformation", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@itemNo", itemNo.Text);
                cmd2.Parameters.AddWithValue("@itemNameArabic", itemNameArabic.Text);
                cmd2.Parameters.AddWithValue("@itemNameEnglish", itemNameEnglish.Text);
                cmd2.Parameters.AddWithValue("@price1", price1.Text);
                cmd2.Parameters.AddWithValue("@price2", price2.Text);
                cmd2.Parameters.AddWithValue("@price3", price3.Text);
                cmd2.Parameters.AddWithValue("@location", location.Text);
                cmd2.ExecuteNonQuery();
                refreshForm1();
            }
        }

        private void addBadeel_Click(object sender, EventArgs e)
        {
            new BadeelForm().Show();
            itemNo2 = itemNo.Text;
        }

        private void itemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchButton_Click_1((object)sender, (EventArgs)e);
            }
        }

        #endregion

        #region helping methods 
        public void refreshForm1()
        {
            itemNo.Text = "";
            itemNameArabic.Text = "";
            itemNameEnglish.Text = "";
            price1.Text = "";
            price2.Text = "";
            price3.Text = "";
            currentCost.Text = "";
            lastCost.Text = "";
            firstCost.Text = "";
            inventory.Text = "";
            sales.Text = "";
            purchases.Text = "";
            location.Text = "";
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();
        }
        public void addItemsInformation()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("retrieveItemInformation", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@itemNo", itemNo.Text);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        DialogResult result = MessageBox.Show("الصنف موجود مسبقا ولا يمكن اضافته ");
                        return;
                    }

                    else
                    {
                        reader.Close();
                        SqlCommand cmd2 = new SqlCommand("addItemInformation", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@itemNo", itemNo.Text);
                        cmd2.Parameters.AddWithValue("@itemNameArabic", itemNameArabic.Text);
                        cmd2.Parameters.AddWithValue("@itemNameEnglish", itemNameEnglish.Text);
                        if (price1.Text != "")
                            cmd2.Parameters.AddWithValue("@price1", Convert.ToDecimal(price1.Text));
                        else
                            cmd2.Parameters.AddWithValue("@price1", Convert.ToDecimal("0.0"));

                        if (price2.Text != "")
                            cmd2.Parameters.AddWithValue("@price2", Convert.ToDecimal(price2.Text));
                        else
                            cmd2.Parameters.AddWithValue("@price2", Convert.ToDecimal("0.0"));

                        if (price3.Text != "")
                            cmd2.Parameters.AddWithValue("@price3", Convert.ToDecimal(price3.Text));
                        else
                            cmd2.Parameters.AddWithValue("@price3", Convert.ToDecimal("0.0"));
                        if (firstCost.Text == "")
                            cmd2.Parameters.AddWithValue("@firstCost", Convert.ToDecimal("0.0"));

                        if (currentCost.Text == "")
                            cmd2.Parameters.AddWithValue("@currentCost", Convert.ToDecimal("0.0"));

                        if (lastCost.Text == "")
                            cmd2.Parameters.AddWithValue("@lastCost", Convert.ToDecimal("0.0"));

                        if (inventory.Text == "")
                            cmd2.Parameters.AddWithValue("@inventory", Convert.ToInt16("0"));

                        if (sales.Text == "")
                            cmd2.Parameters.AddWithValue("@sales", Convert.ToInt16("0"));

                        if (purchases.Text == "")
                            cmd2.Parameters.AddWithValue("@purchases", Convert.ToInt32("0"));

                        cmd2.Parameters.AddWithValue("@location", location.Text);
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        public void retrieveItemInformation()
        {
            string itemNumber = itemNo.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("retrieveItemInformation", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@itemNo", itemNumber);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        refreshForm1();
                        itemNo.Text = reader["itemNo"].ToString();
                        itemNameArabic.Text = reader["itemNameArabic"].ToString();
                        itemNameEnglish.Text = reader["itemNameEnglish"].ToString();
                        price1.Text = reader["price1"].ToString();
                        price2.Text = reader["price2"].ToString();
                        price3.Text = reader["price3"].ToString();
                        firstCost.Text = reader["firstCost"].ToString();
                        currentCost.Text = reader["currentCost"].ToString();
                        lastCost.Text = reader["lastCost"].ToString();
                        inventory.Text = reader["currentInventory"].ToString();
                        sales.Text = reader["sales"].ToString();
                        purchases.Text = reader["purchases"].ToString();
                        location.Text = reader["location"].ToString();
                        reader.Close();
                        //=========================


                        dataGridView1.Rows.Clear();
                        SqlCommand cmd = new SqlCommand("loadBadeel", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemNo", itemNumber);
                        SqlDataReader reader1 = cmd.ExecuteReader();
                        int rowIndex = 0;

                        while (reader1.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView1.Rows.Add(row);
                            dataGridView1.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
                            dataGridView1.Rows[rowIndex].Cells[1].Value = reader1["itemNo"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[2].Value = reader1["itemNameArabic"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[3].Value = reader1["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader1["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader1["price1"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader1["location"].ToString();
                            rowIndex++;
                        }
                        reader1.Close();
                        conn.Close();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("الصنف غير موجود");
                        refreshForm1();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }


}

