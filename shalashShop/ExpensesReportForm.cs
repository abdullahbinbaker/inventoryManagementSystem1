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
    public partial class ExpensesReportForm : Form
    {
        #region the form's original methods 
        /// <summary>
        ///the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public ExpensesReportForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            idPanel.Show();
            datePanel.Hide();
            expensesTotal.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            idPanel.Hide();
            datePanel.Show();
            expensesTotal.Text = "";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    updateAndSearchForExpensesForm updateFrame = new updateAndSearchForExpensesForm();
                    SqlCommand cmd2 = new SqlCommand("searchExpensesById", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@expensesId", dataGridView1.CurrentRow.Cells[0].Value);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        updateFrame.expensesNo.Text = reader["expensesId"].ToString();
                        updateFrame.expensesName.Text = reader["expensesName"].ToString();
                        updateFrame.expensesPrice.Text = reader["price"].ToString();
                        updateFrame.dateTimePicker1.Value = Convert.ToDateTime(reader["date"]);
                    }
                    updateFrame.Show();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            double eTotal = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    if (radioButton2.Checked)
                    {
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchExpensesByDate", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@startDate", dateTimePicker1.Value.ToShortDateString());
                        cmd2.Parameters.AddWithValue("@endDate", dateTimePicker2.Value.ToShortDateString());
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView1.Rows.Add(row);
                            dataGridView1.Rows[rowIndex].Cells[0].Value = reader["expensesId"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[1].Value = reader["expensesName"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[2].Value = reader["price"].ToString();
                            eTotal += Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[2].Value);
                            dataGridView1.Rows[rowIndex].Cells[3].Value = reader["date"].ToString();
                            rowIndex++;
                        }
                    }
                    if (radioButton1.Checked)
                    {
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("searchExpensesById", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@expensesId", Convert.ToInt64(expensesId.Text));
                        SqlDataReader reader = cmd2.ExecuteReader();
                        int rowIndex = 0;
                        while (reader.Read())
                        {
                            var row = new DataGridViewRow();
                            dataGridView1.Rows.Add(row);
                            dataGridView1.Rows[rowIndex].Cells[0].Value = reader["expensesId"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[1].Value = reader["expensesName"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[2].Value = reader["price"].ToString();
                            eTotal += Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[2].Value);
                            dataGridView1.Rows[rowIndex].Cells[3].Value = reader["date"].ToString();
                            rowIndex++;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            expensesTotal.Text = eTotal.ToString();
        }
        #endregion
    }
}
