using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace shalashShop
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        public void intiateData(int billNo, string billType, string customerName, string billDate, List<itemInSalesBill> data,decimal discount,decimal billAfterDiscount)
        {
            BillNo.Value=billNo;
            BillDate.Value = billDate;
            CustomerName.Value = customerName;
            BillType.Value = billType;
            discountP.Value = discount;
            salesBillTotalAfterDiscountP.Value = billAfterDiscount;
            objectDataSource3.DataSource = data;
        }
    }
}
