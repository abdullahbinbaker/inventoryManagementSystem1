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
    public partial class BadeelForm : Form
    {
        #region the form's original methods 
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public BadeelForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string itemNo3 = itemInformation.itemNo2.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("retreiveIfTheItemIsExist", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@itemNo", BadeelNo.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        SqlCommand cmd2 = new SqlCommand("updateBadeel", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@originalNo", itemNo3);
                        cmd2.Parameters.AddWithValue("@badeelNo", BadeelNo.Text);
                        cmd2.ExecuteNonQuery();
                        BadeelNo.Text = "";
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(" الصنف" + BadeelNo.Text + "غير موجود يجب اضافته اولا ");
                    }
                    conn.Close();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(" هل ترغب بازالة الرقم" + BadeelNo.Text + " من قائمة البدائل  ", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(conn1))
                    {
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand("removeBadeelNo", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@badeelNo", BadeelNo.Text);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        BadeelNo.Text = "";
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

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
