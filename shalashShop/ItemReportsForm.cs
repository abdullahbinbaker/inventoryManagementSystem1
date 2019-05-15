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
    public partial class ItemReportsForm : Form
    {
        /// <summary>
        /// THE CONNECTION STRING 
        /// </summary>
        string conn1=System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        /// <summary>
        /// a list that contains the datagridview data and it is used to store the datagridview data and then use it in printing the report
        /// </summary>
        List<itemInItemReportForm> listOfItemsInItemReportForms;

        #region the form's original methods
        public ItemReportsForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    if (radioButton1.Checked)
                    {
                        listOfItemsInItemReportForms = new List<itemInItemReportForm>();
                        Number.Text = "";
                        Number1.Text = "";
                        Number2.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("showItemsLessThanZero", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
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
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["price2"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["price3"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[8].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[9].Value = reader["location"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[10].Value = reader["sales"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[11].Value = reader["purchases"].ToString();

                            listOfItemsInItemReportForms.Add(new itemInItemReportForm(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(),
                                dataGridView1.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[8].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[9].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[10].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[11].Value.ToString()));
                            rowIndex++;
                        }
                    }
                    if (radioButton2.Checked)
                    {
                        listOfItemsInItemReportForms = new List<itemInItemReportForm>();
                        Number.Text = "";
                        Number1.Text = "";
                        Number2.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("showItemsEqualToZero", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
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
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["price2"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["price3"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[8].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[9].Value = reader["location"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[10].Value = reader["sales"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[11].Value = reader["purchases"].ToString();
                            listOfItemsInItemReportForms.Add(new itemInItemReportForm(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(),
                           dataGridView1.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[8].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[9].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[10].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[11].Value.ToString()));
                            rowIndex++;
                        }
                    }
                    if (radioButton3.Checked)
                    {
                        listOfItemsInItemReportForms = new List<itemInItemReportForm>();
                        Number.Text = "";
                        Number1.Text = "";
                        Number2.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("showItemsMoreThanZero", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
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
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["price2"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["price3"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[8].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[9].Value = reader["location"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[10].Value = reader["sales"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[11].Value = reader["purchases"].ToString();
                            listOfItemsInItemReportForms.Add(new itemInItemReportForm(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(),
                           dataGridView1.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[8].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[9].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[10].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[11].Value.ToString()));
                            rowIndex++;
                        }
                    }
                    if (radioButton4.Checked)
                    {
                        listOfItemsInItemReportForms = new List<itemInItemReportForm>();
                        Number.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("showItemsBetween", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Number1", Number1.Text);
                        cmd2.Parameters.AddWithValue("@Number2", Number2.Text);
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
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["price2"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["price3"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[8].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[9].Value = reader["location"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[10].Value = reader["sales"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[11].Value = reader["purchases"].ToString();
                            listOfItemsInItemReportForms.Add(new itemInItemReportForm(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(),
                            dataGridView1.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[8].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[9].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[10].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[11].Value.ToString()));
                            rowIndex++;
                        }
                    }

                    if (radioButton5.Checked)
                    {
                        listOfItemsInItemReportForms = new List<itemInItemReportForm>();
                        Number1.Text = "";
                        Number2.Text = "";
                        dataGridView1.Rows.Clear();
                        SqlCommand cmd2 = new SqlCommand("showItemsEqualTo", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Number", Number.Text);
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
                            dataGridView1.Rows[rowIndex].Cells[4].Value = reader["price2"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[5].Value = reader["price3"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[6].Value = reader["currentCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[7].Value = reader["lastCost"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[8].Value = reader["currentInventory"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[9].Value = reader["location"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[10].Value = reader["sales"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[11].Value = reader["purchases"].ToString();
                            listOfItemsInItemReportForms.Add(new itemInItemReportForm(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(),
                            dataGridView1.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[8].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[9].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[10].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[11].Value.ToString()));
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
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            using (ItemReportPrintFrame frame1 = new ItemReportPrintFrame(listOfItemsInItemReportForms as List<itemInItemReportForm>))
            {
                frame1.ShowDialog();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }

}
