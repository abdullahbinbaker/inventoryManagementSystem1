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
    public partial class suppliersForm : Form
    {
        public suppliersForm()
        {
            InitializeComponent();
        }
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private void suppliers_Load(object sender, EventArgs e)
        {
            long SupplierID=0;

            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("selectSupplierID", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                    SupplierID = Convert.ToInt64(reader["supplierID"]);
                SupplierID++;
                supplierID.Text = SupplierID.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("insertSupplier", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@supplierName", supplierName.Text);
                cmd2.Parameters.AddWithValue("@supplierPhone", supplierPhone.Text);
                cmd2.Parameters.AddWithValue("@supplierAddress", supplierAddress.Text);
                cmd2.ExecuteNonQuery();
                long SupplierID = 0;
                SqlCommand cmd = new SqlCommand("selectSupplierID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    SupplierID = Convert.ToInt64(reader["supplierID"]);
                SupplierID++;
                supplierID.Text = SupplierID.ToString();
                supplierName.Text = "";
                supplierPhone.Text = "";
                supplierPhone.Text = "";
                supplierAddress.Text = "";
            }

        }

       

       
        private void button2_Click(object sender, EventArgs e)
        {
            supplierName.Text = "";
            supplierPhone.Text = "";
            supplierPhone.Text="";
            supplierAddress.Text = "";
        }

       

    }
}
