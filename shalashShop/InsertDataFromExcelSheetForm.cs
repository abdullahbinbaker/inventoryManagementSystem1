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
using System.IO;
using System.Data.OleDb;


namespace shalashShop

{
    public partial class InsertDataFromExcelSheetForm : Form
    {
        /// <summary>
        /// list that contains the items of the excel sheet 
        /// </summary>
        List<itemInDataFormExcelSheet> itemInTheExcelList;
        /// <summary>
        /// the connection string 
        /// </summary>
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        #region the original methos of the form
        public InsertDataFromExcelSheetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadButton.Enabled = true;
            try
            {
                String name = sheetNameTextBox.Text;
                String constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + directory.Text + ";Extended Properties='Excel 8.0;;IMEX=1;HDR=NO;';";
                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                con.Dispose();
                con.Close();
                oconn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemInTheExcelList = new List<itemInDataFormExcelSheet>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                itemInTheExcelList.Add(new itemInDataFormExcelSheet(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), dataGridView1.Rows[i].Cells[6].Value.ToString(), dataGridView1.Rows[i].Cells[7].Value.ToString(), dataGridView1.Rows[i].Cells[8].Value.ToString(), dataGridView1.Rows[i].Cells[9].Value.ToString()));
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(conn1))
                {
                    conn.Open();
                    for (int i = 2; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        SqlCommand cmd2 = new SqlCommand("addItemInforation2", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@itemNo", itemInTheExcelList[i].itemNo);
                        cmd2.Parameters.AddWithValue("@itemNameArabic", itemInTheExcelList[i].itemNameArabic);
                        cmd2.Parameters.AddWithValue("@itemNameEnglish", itemInTheExcelList[i].itemNameEngish);
                        cmd2.Parameters.AddWithValue("@price1", itemInTheExcelList[i].price1);
                        cmd2.Parameters.AddWithValue("@price2", itemInTheExcelList[i].price2);
                        cmd2.Parameters.AddWithValue("@price3", itemInTheExcelList[i].price3);
                        cmd2.Parameters.AddWithValue("@currentCost", itemInTheExcelList[i].currentCost);
                        cmd2.Parameters.AddWithValue("@lastCost", itemInTheExcelList[i].lastCost);
                        cmd2.Parameters.AddWithValue("@currentInventory", itemInTheExcelList[i].currentInventory);
                        cmd2.Parameters.AddWithValue("@location", itemInTheExcelList[i].location);
                        cmd2.Parameters.AddWithValue("@itemNo2", itemInTheExcelList[i].itemNo);

                        cmd2.ExecuteNonQuery();

                    }

                    conn.Close();

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        #endregion
    }

    #region item in data form the excel sheet class
    public class itemInDataFormExcelSheet
    {
        public itemInDataFormExcelSheet(string itemNo)
        {
            this.itemNo = itemNo;
        }
        public itemInDataFormExcelSheet(string itemNo, string itemNameArabic, string itemNameEngish, string price1, string price2, string price3, string currentCost, string lastCost, string currentInventory, string location)
        {
            this.itemNo = itemNo;
            this.itemNameArabic = itemNameArabic;
            this.itemNameEngish = itemNameEngish;
            this.price1 = price1;
            this.price2 = price2;
            this.price3 = price3;
            this.currentCost = currentCost;
            this.lastCost = lastCost;
            this.currentInventory = currentInventory;
            this.location = location;
        }
        public string itemNo { get; set; }
        public string itemNameArabic { get; set; }
        public string itemNameEngish { get; set; }
        public string price1 { get; set; }
        public string price2 { get; set; }
        public string price3 { get; set; }
        public string currentCost { get; set; }
        public string lastCost { get; set; }
        public string currentInventory { get; set; }
        public string location { get; set; }
    }
}
#endregion