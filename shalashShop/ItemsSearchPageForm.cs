using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shalashShop
{
    public partial class ItemsSearchPageForm : Form
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        #region the form's original methods 
        public ItemsSearchPageForm()
        {

            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemInformation itemForm = new itemInformation();
            itemForm.Show();
            itemForm.itemNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    if (radioButton1.Checked)
                    {
                        itemNameEnglish.Text = "";
                        itemNo.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchItemByNameOrNo", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@itemNameArabic", itemNameArabic.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView1.Rows.Add(row);
                            dataGridView1.Rows[rowIndex].Cells[0].Value = reader["itemNo"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNameArabic"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemNameEnglish"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[3].Value = reader["price1"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["location"].ToString();

                            rowIndex++;
                        }
                    }
                    if (radioButton2.Checked)
                    {
                        itemNameArabic.Text = "";
                        itemNo.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchItemByNameOrNo", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@itemNameEnglish", itemNameEnglish.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView1.Rows.Add(row);
                            dataGridView1.Rows[rowIndex].Cells[0].Value = reader["itemNo"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNameArabic"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemNameEnglish"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[3].Value = reader["price1"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["location"].ToString();

                            rowIndex++;
                        }
                    }
                    if (radioButton3.Checked)
                    {
                        itemNameArabic.Text = "";
                        itemNameEnglish.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchItemByNameOrNo", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@itemNo", itemNo.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView1.Rows.Add(row);
                            dataGridView1.Rows[rowIndex].Cells[0].Value = reader["itemNo"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[1].Value = reader["itemNameArabic"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[2].Value = reader["itemNameEnglish"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[3].Value = reader["price1"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["location"].ToString();

                            rowIndex++;
                        }
                    }

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
