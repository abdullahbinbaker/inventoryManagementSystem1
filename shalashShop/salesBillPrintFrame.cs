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
    public partial class salesBillPrintFrame : Form
    {
        string _billNo, _billType, _billDate, _customerName,_totalPriceBeforeDiscount,_discount,_totalPriceAfterDiscount;
        List<itemInSalesBill> _list;

     

        public salesBillPrintFrame(List<itemInSalesBill> list, string billNo,string billType,string billDate,string customerName,string totalPriceBeforeDiscount,string discount,string totalPriceAfterDiscount)
        {
            InitializeComponent();
            _list = list;
            _billNo = billNo;
            _billType = billType;
            _billDate = billDate;
            _customerName = customerName;
            _totalPriceBeforeDiscount = totalPriceBeforeDiscount;
            _discount = discount;
            _totalPriceAfterDiscount = totalPriceAfterDiscount;
        
        }
        ReportDataSource rs = new ReportDataSource();
        private void salesBillPrintFrame_Load(object sender, EventArgs e)
        {
            rs.Name = "DataSet1";
            rs.Value = _list;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);
            reportViewer1.LocalReport.ReportEmbeddedResource = "shalashShop.SalesBillPrintReport.rdlc";
            
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("BillNumber",_billNo),
                new Microsoft.Reporting.WinForms.ReportParameter("BillType",_billType),
                new Microsoft.Reporting.WinForms.ReportParameter("BillDate",_billDate),
                new Microsoft.Reporting.WinForms.ReportParameter("CustomerName",_customerName),
                new Microsoft.Reporting.WinForms.ReportParameter("total",_totalPriceBeforeDiscount),
                new Microsoft.Reporting.WinForms.ReportParameter("discount",_discount),
                new Microsoft.Reporting.WinForms.ReportParameter("totalAfterDiscount",_totalPriceAfterDiscount),

                //new Microsoft.Reporting.WinForms.ReportParameter("itemNo",_list[0].itemNo),
                //new Microsoft.Reporting.WinForms.ReportParameter("itemName",_list[0].itemNameInArabic),
                //new Microsoft.Reporting.WinForms.ReportParameter("quantity",_list[0].itemQuantityInTheBill.ToString()),
                //new Microsoft.Reporting.WinForms.ReportParameter("price",_list[0].itemPriceInTheBill.ToString()),
                //new Microsoft.Reporting.WinForms.ReportParameter("totalPrice",_list[0].itemTotalPriceInTheBill.ToString())

            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        
    }
}
