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
    public partial class AddingSuppliersInfoForm : Form
    {
        #region the form's orgiginal methods
        /// <summary>
        /// the connection string
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public AddingSuppliersInfoForm()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            long customerID = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("selectCustomerID", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                        customerID = Convert.ToInt64(reader["customerID"]);
                    customerID++;
                    supplierID.Text = customerID.ToString();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("insertCustomer", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@customerName", supplierName.Text);
                    cmd2.Parameters.AddWithValue("@customerPhone", supplierPhone.Text);
                    cmd2.Parameters.AddWithValue("@customerAddress", supplierAddress.Text);
                    cmd2.ExecuteNonQuery();
                    long SupplierID = 0;
                    SqlCommand cmd = new SqlCommand("selectCustomerID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        SupplierID = Convert.ToInt64(reader["customerID"]);
                    SupplierID++;
                    supplierID.Text = SupplierID.ToString();
                    supplierName.Text = "";
                    supplierPhone.Text = "";
                    supplierPhone.Text = "";
                    supplierAddress.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            supplierName.Text = "";
            supplierPhone.Text = "";
            supplierPhone.Text = "";
            supplierAddress.Text = "";
        }
        #endregion
    }
}
