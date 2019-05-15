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
    public partial class updateAndSearchForExpensesForm : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public updateAndSearchForExpensesForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();

                SqlCommand cmd2 = new SqlCommand("updateExpenses", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@expensesId ", expensesNo.Text);
                cmd2.Parameters.AddWithValue("@ExpensesName ", expensesName.Text);
                cmd2.Parameters.AddWithValue("@price", expensesPrice.Text);
                cmd2.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToShortDateString());
                cmd2.ExecuteNonQuery();
                conn.Close();
                DialogResult result = MessageBox.Show("تم تعديل المعلومات");
                this.Close();
            }
           
        }
    }
}
