using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace shalashShop
{
    public partial class DevFrmPrint : DevExpress.XtraEditors.XtraForm
    {
        public DevFrmPrint()
        {
            InitializeComponent();
        }
        public void PrintInvoice(List<itemInSalesBill> data)
        {
            InvoiceReport report = new InvoiceReport();
            // report.intiateData(1, salesBill.BillNo, salesBill.BillType, salesBill.CustomerName, salesBill.BillDate, data);
            report.intiateData(Convert.ToInt32(salesBillForm.BillNo), salesBillForm.BillType, salesBillForm.CustomerName, salesBillForm.BillDate, data,salesBillForm.Discount,salesBillForm.SalesBillTotalAfterDiscount);     
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void PrintPurchaseBill(List<itemInPurchaseBill> data)
        {
            PurchaseBillReport report = new PurchaseBillReport();
            // report.intiateData(1, salesBill.BillNo, salesBill.BillType, salesBill.CustomerName, salesBill.BillDate, data);
            report.intiateData(purchasesBillForm.PurchaseBillNo, purchasesBillForm.PurchaseBillType, purchasesBillForm.PurchasesupplierName, purchasesBillForm.PurchaseBillDate, data, purchasesBillForm.PurchaseBillTotalAfterDiscount, purchasesBillForm.OriginalPurchaseBillNo,purchasesBillForm.Discount);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintPurchaseReoprt(List<BillShortInformation> data)
        {
            PurchaseReportReport report = new PurchaseReportReport();
            // report.intiateData(1, salesBill.BillNo, salesBill.BillType, salesBill.CustomerName, salesBill.BillDate, data);
            report.intiateData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintSalesReoprt(List<BillShortInformation> data)
        {
            SalesReportReport report = new SalesReportReport();
            // report.intiateData(1, salesBill.BillNo, salesBill.BillType, salesBill.CustomerName, salesBill.BillDate, data);
            report.intiateData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintPurchaseReturn(List<itemInSalesBill> data)
        {
            PurchaseReturnReport report = new PurchaseReturnReport();
            // report.intiateData(1, salesBill.BillNo, salesBill.BillType, salesBill.CustomerName, salesBill.BillDate, data);
            report.intiateData(purchasesReturnForm.BillNo,purchasesReturnForm.BillType,purchasesReturnForm.SupplierName,purchasesReturnForm.BillDate,data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }


        public void PrintSalesReturn(List<itemInSalesBill> data)
        {
            SalesReturnReport report = new SalesReturnReport();
            // report.intiateData(1, salesBill.BillNo, salesBill.BillType, salesBill.CustomerName, salesBill.BillDate, data);
            report.intiateData(sellingReturnsForm.BillNo, sellingReturnsForm.BillType, sellingReturnsForm.CustomerName, sellingReturnsForm.BillDate, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}