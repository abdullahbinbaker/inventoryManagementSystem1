using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shalashShop
{
    public partial class theMainPageForm : Form
    {
        public theMainPageForm()
        {
            InitializeComponent();
        }

        private void theMain_Load(object sender, EventArgs e)
        {

        }

        private void معلوماتالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new itemInformation().Show();
        }

        private void فاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new salesBillForm().Show();

        }

        private void فاتورةمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new purchasesBillForm().Show();
        }

        private void سندمردودبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new sellingReturnsForm().Show();
        }

        private void مردودمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new purchasesReturnForm().Show();
        }

       

        private void اضافةموردToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new suppliersForm().Show();
        }

        private void العملاءوالموردينToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void قائمةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchForSuppliersForm().Show();
        }

        private void قائمةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchForCustomersForm().Show();
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddingSuppliersInfoForm().Show();
        }

        private void كشفمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PurchasesReportForm().Show();
        }

        private void كشفالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new salesReportForm().Show();
        }

        private void معلوماتالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddingExpensesForm().Show();
        }

        private void كشفارباحوخسائرالفترةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalculatingTheProfitsForm().Show();

        }

        private void سدادفواتيرالمبيعاتالآجلةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ChangeBillTypeForm type= new ChangeBillTypeForm();
           type.radioButton2.Checked = true;
           type.radioButton1.Enabled = true;
           type.Show();

           //salesReport sal= new salesReport();
           //sal.radioButton1.Hide();
           //sal.radioButton2.Hide();
           //sal.radioButton3.Hide();
           //sal.button2.Hide();
           //sal.billID.Show();
           //sal.radioButton4.Checked=true;
           
           //sal.Show();


        }

        private void سدادفواتيرالمشترياتالآجلةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBillTypeForm type1 = new ChangeBillTypeForm();
            type1.radioButton1.Checked = true;
            type1.radioButton2.Enabled = true;
            type1.Show();
        }

        private void تقريرمصاريفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExpensesReportForm().Show();
        }

        private void كشفحركةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ItemReportsForm().Show();
        }

        private void كشفالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void بدءعمليةالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new JardPage1().Show();
        }

        private void insertDatatFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertDataFromExcelSheetForm().Show();
        }

        private void البدائلToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new Badeel().Show();
        }
    }
}

