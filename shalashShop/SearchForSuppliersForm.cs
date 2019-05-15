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
    public partial class SearchForSuppliersForm : Form
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        #region the form's original methods 
        public SearchForSuppliersForm()
        {
            InitializeComponent();
        }

        private void AllTheSuppliers_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("retrieveSuppliersInformation", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    int rowIndex = 0;
                    while (reader.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView2.Rows.Add(row);
                        dataGridView2.Rows[rowIndex].Cells[0].Value = reader["supplierID"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[1].Value = reader["supplierName"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[2].Value = reader["supplierPhone"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[3].Value = reader["supplierAddress"].ToString();

                        rowIndex++;
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
                        SqlCommand cmd2 = new SqlCommand("searchForSupplier ", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@supplierID", ID.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView2.Rows.Add(row);
                            dataGridView2.Rows[rowIndex].Cells[0].Value = reader["supplierID"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["supplierName"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["supplierPhone"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["supplierAddress"].ToString();
                            rowIndex++;
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        var row = new DataGridViewRow();
                        dataGridView2.Rows.Add(row);
                        SqlCommand cmd2 = new SqlCommand("searchForSupplier ", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@supplierName", name.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            dataGridView2.Rows[rowIndex].Cells[0].Value = reader["supplierID"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["supplierName"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["supplierPhone"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["supplierAddress"].ToString();
                            rowIndex++;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        dataGridView2.Rows.Clear();
                        var row = new DataGridViewRow();
                        dataGridView2.Rows.Add(row);
                        SqlCommand cmd2 = new SqlCommand("searchForSupplier ", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@supplierPhone", Phone.Text);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            dataGridView2.Rows[rowIndex].Cells[0].Value = reader["supplierID"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[1].Value = reader["supplierName"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[2].Value = reader["supplierPhone"].ToString();
                            dataGridView2.Rows[rowIndex].Cells[3].Value = reader["supplierAddress"].ToString();
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("updateSupplier", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@supplierID", Convert.ToInt16(dataGridView2.Rows[0].Cells[0].Value));
                    cmd2.Parameters.AddWithValue("@supplierName", dataGridView2.CurrentRow.Cells[1].Value);
                    cmd2.Parameters.AddWithValue("@supplierPhone", dataGridView2.CurrentRow.Cells[2].Value);
                    cmd2.Parameters.AddWithValue("@supplierAddress", dataGridView2.CurrentRow.Cells[3].Value);
                }
                MessageBox.Show("تم تحديث البيانات");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showSuppliersButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("retrieveSuppliersInformation", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    int rowIndex = 0;
                    while (reader.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView2.Rows.Add(row);
                        dataGridView2.Rows[rowIndex].Cells[0].Value = reader["supplierID"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[1].Value = reader["supplierName"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[2].Value = reader["supplierPhone"].ToString();
                        dataGridView2.Rows[rowIndex].Cells[3].Value = reader["supplierAddress"].ToString();

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
