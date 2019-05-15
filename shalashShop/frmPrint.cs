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
    public partial class frmPrint : Form
    {
        List<itemInSalesBill> _List;
        public frmPrint(List<itemInSalesBill> List)
        {
            InitializeComponent();
            _List = List;
        }
        private void frmPrint_Load(object sender, EventArgs e)
        {
            //for crystal report===================================================================================

            //invoiceReport21.SetDataSource(_List);

            
            //for (int i = 0; i < _List.Count; i++)
            //{
            //    invoiceReport21.SetParameterValue("itemNoP", _List[i].itemNo);
            //    invoiceReport21.SetParameterValue("itemPriceUnitP", _List[i].itemPriceInTheBill);
            //    invoiceReport21.SetParameterValue("itemTotalPriceP", _List[i].itemTotalPriceInTheBill);
            //    invoiceReport21.SetParameterValue("quantityP", _List[i].itemQuantityInTheBill);
            
            //}
            //invoiceReport21.SetParameterValue("billNo", salesBill.BillNo);
            //invoiceReport21.SetParameterValue("billTypeP", salesBill.BillType);
            //invoiceReport21.SetParameterValue("billDateP", salesBill.BillDate);
            //invoiceReport21.SetParameterValue("customerNameP", salesBill.CustomerName);
            
            //crystalReportViewer1.ReportSource = invoiceReport21;
            //crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
