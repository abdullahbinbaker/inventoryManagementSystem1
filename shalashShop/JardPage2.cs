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
    public partial class JardPage2 : Form
    {
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        #region the form's original methods
        public JardPage2()
        {
            InitializeComponent();
        }

        private void JardPage2_Load(object sender, EventArgs e)
        {
            
            double totalPlus = 0;
            double totalMinuse = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();

                    dataGridView1.Rows.Clear();
                    SqlCommand cmd = new SqlCommand("JardLoadItemsForPage2 ", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader1 = cmd.ExecuteReader();
                    int rowIndex = 0;

                    while (reader1.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Rows[rowIndex].Cells[0].Value = reader1["itemNo"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader1["itemNameArabic"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader1["location"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader1["currentInventory"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[4].Value = reader1["jardInventory"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[5].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[4].Value) - Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value);
                        dataGridView1.Rows[rowIndex].Cells[6].Value = reader1["currentCost"].ToString();
                        double different = 0;
                        different = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[5].Value) * Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[6].Value);
                        if (different < 0)
                        {
                            dataGridView1.Rows[rowIndex].Cells[7].Value = different.ToString();
                            totalMinuse += different;
                        }
                        if (different > 0)
                        {
                            dataGridView1.Rows[rowIndex].Cells[8].Value = different.ToString();
                            totalPlus += different;
                        }
                        if (different == 0)
                        {
                            dataGridView1.Rows[rowIndex].Cells[7].Value = 0;
                            dataGridView1.Rows[rowIndex].Cells[8].Value = 0;
                        }
                        rowIndex++;
                    }
                    reader1.Close();
                    Pluses.Text = totalPlus.ToString();
                    TotalDifferences.Text = totalMinuse.ToString();
                }
            }catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        #endregion

    }
}
