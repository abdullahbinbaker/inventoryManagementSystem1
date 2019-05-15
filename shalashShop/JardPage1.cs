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
    public partial class JardPage1 : Form
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        #region the form's original methods 
        public JardPage1()
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
                    SqlCommand cmd = new SqlCommand("loadBadeel", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@itemNo", itemNo.Text);
                    SqlDataReader reader1 = cmd.ExecuteReader();
                    int rowIndex = 0;

                    while (reader1.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Rows[rowIndex].Cells[0].Value = reader1["itemNo"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader1["itemNameArabic"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader1["currentInventory"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader1["jardInventory"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[4].Value = reader1["location"].ToString();
                        rowIndex++;
                    }
                    reader1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {

                        SqlCommand cmd3 = new SqlCommand("jardUpdateJardInvetoryAndLocation", conn);
                        cmd3.CommandType = CommandType.StoredProcedure;

                        cmd3.Parameters.AddWithValue("@itemNumber", dataGridView1.Rows[i].Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@jardInventroy", dataGridView1.Rows[i].Cells[3].Value);
                        cmd3.Parameters.AddWithValue("@Location", dataGridView1.Rows[i].Cells[4].Value);
                        cmd3.ExecuteNonQuery();
                    }
                    conn.Close();
                    dataGridView1.Rows.Clear();
                }
            }
            catch (Exception exe)
            {
                dataGridView1.Rows.Clear();
                DialogResult result = MessageBox.Show("ادخال خاطئ");

            }
        }

        private void goToOtherPage_Click(object sender, EventArgs e)
        {
            new JardPage2().Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

