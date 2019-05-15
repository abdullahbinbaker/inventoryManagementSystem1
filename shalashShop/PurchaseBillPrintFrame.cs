using Microsoft.Reporting.WinForms;
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
    public partial class PurchaseBillPrintFrame : Form
    {
        string _billNo, _billType, _billDate, _supplierName, _totalPriceBeforeDiscount, _discount, _totalPriceAfterDiscount;

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        List<itemInPurchaseBill> _list;
        ReportDataSource rs1 = new ReportDataSource();
        public PurchaseBillPrintFrame(List<itemInPurchaseBill> list, string billNo, string billType, string billDate, string supplierName, string totalPriceBeforeDiscount, string discount, string totalPriceAfterDiscount)
        {
            InitializeComponent();
            _list = list;
            _billNo = billNo;
            _billType = billType;
            _billDate = billDate;
            _supplierName = supplierName;
            _totalPriceBeforeDiscount = totalPriceBeforeDiscount;
            _discount = discount;
            _totalPriceAfterDiscount = totalPriceAfterDiscount;
        }

        private void PurchaseBillPrintFrame_Load(object sender, EventArgs e)
        {
            rs1.Name = "DataSet2";
            rs1.Value = _list;
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rs1);
            reportViewer2.LocalReport.ReportEmbeddedResource = "shalashShop.purchaseBillPrintReport.rdlc";

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("BillNumber",_billNo),
                new Microsoft.Reporting.WinForms.ReportParameter("BillType",_billType),
                new Microsoft.Reporting.WinForms.ReportParameter("BillDate",_billDate),
                new Microsoft.Reporting.WinForms.ReportParameter("SupplierName",_supplierName),
                new Microsoft.Reporting.WinForms.ReportParameter("Total",_totalPriceBeforeDiscount),
                new Microsoft.Reporting.WinForms.ReportParameter("discount",_discount),
                new Microsoft.Reporting.WinForms.ReportParameter("totalAfterDiscount",_totalPriceAfterDiscount),
                
            };
            this.reportViewer2.LocalReport.SetParameters(para);
            this.reportViewer2.RefreshReport();
        }
    }
}
