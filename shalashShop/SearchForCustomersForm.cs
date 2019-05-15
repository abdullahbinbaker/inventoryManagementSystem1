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
    public partial class SearchForCustomersForm : Form
    {
        /// <summary>
        /// the connection string
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        #region the form's original methods
        public SearchForCustomersForm()
        {
            InitializeComponent();
        }

        private void AllTheCustomers_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("retrieveCustomersInformation", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd2.ExecuteReader();
                int rowIndex = 0;
                while (reader.Read())
                {
                    var row = new DataGridViewRow();
                    dataGridView2.Rows.Add(row);
                    dataGridView2.Rows[rowIndex].Cells[0].Value = reader["customerID"].ToString();
                    dataGridView2.Rows[rowIndex].Cells[1].Value = reader["customerName"].ToString();
                    dataGridView2.Rows[rowIndex].Cells[2].Value = reader["customerPhone"].ToString();
                    dataGridView2.Rows[rowIndex].Cells[3].Value = reader["customerAddress"].ToString();

                    rowIndex++;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ID.Show();
            name.Hide();
            Phone.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            name.Show();
            ID.Hide();
            Phone.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Phone.Show();
            name.Hide();
            ID.Hide();
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
                        dataGridView2.Rows.Clear();
                        var row = new DataGridViewRow();
                        dataGridView2.Rows.Add(row);
                        SqlCommand cmd2 = new SqlCommand("searchForCustomers ", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@customerID", ID.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            dataGridView2.Rows[rowIndex].Cells[0].Value = reader["customerID"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["customerName"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["customerPhone"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["customerAddress"].ToString();
                            rowIndex++;
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchForCustomers ", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@customerName", name.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView2.Rows.Add(row);
                            dataGridView2.Rows[rowIndex].Cells[0].Value = reader["customerID"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["customerName"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["customerPhone"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["customerAddress"].ToString();
                            rowIndex++;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        var row = new DataGridViewRow();
                        dataGridView2.Rows.Add(row);
                        SqlCommand cmd2 = new SqlCommand("searchForCustomers ", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@customerPhone", Phone.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            dataGridView2.Rows[rowIndex].Cells[0].Value = reader["customerID"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["customerName"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["customerPhone"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["customerAddress"].ToString();
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("updateCustomer", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@customerID", Convert.ToInt16(dataGridView2.Rows[0].Cells[0].Value));
                    cmd2.Parameters.AddWithValue("@customerName", dataGridView2.CurrentRow.Cells[1].Value);
                    cmd2.Parameters.AddWithValue("@customerPhone", dataGridView2.CurrentRow.Cells[2].Value);
                    cmd2.Parameters.AddWithValue("@customerAddress", dataGridView2.CurrentRow.Cells[3].Value);
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("تم تحديث البيانات");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void showCustomersButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("retrieveCustomersInformation", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    int rowIndex = 0;
                    while (reader.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView2.Rows.Add(row);
                        dataGridView2.Rows[rowIndex].Cells[0].Value = reader["customerID"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[1].Value = reader["customerName"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[2].Value = reader["customerPhone"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[3].Value = reader["customerAddress"].ToString();
                        rowIndex++;
                    }
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
