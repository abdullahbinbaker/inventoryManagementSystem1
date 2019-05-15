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
using DevExpress.XtraEditors;

namespace shalashShop
{
    public partial class AddingExpensesForm : Form
    {
        #region the form's original methods
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        /// <summary>
        /// it is an attribute to save the expenses id which it icrement automatically in DB and then we retrieve it from database
        /// </summary>
        long expensesId;

        public AddingExpensesForm()
        {
            InitializeComponent();
        }
        private void Expenses_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("insertExpensesNo", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                        expensesId = Convert.ToInt64(reader["expensesId"]);
                    expensesId++;
                    expensesNo.Text = expensesId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SavingButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("createExpenses", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@ExpensesName ", expensesName.Text);
                    cmd2.Parameters.AddWithValue("@price", expensesPrice.Text);
                    cmd2.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToShortDateString());
                    cmd2.ExecuteNonQuery();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            refresh();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region helping methods
        public void refresh()
        {
            expensesName.Text = "";
            expensesPrice.Text = "";
        }


        #endregion

       
    }
}

