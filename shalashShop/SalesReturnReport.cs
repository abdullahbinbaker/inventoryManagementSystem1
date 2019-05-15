using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;


namespace shalashShop
{
    public partial class SalesReturnReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SalesReturnReport()
        {
            InitializeComponent();
        }
        public void intiateData(string billNo, string billType, string customerName, string billDate, List<itemInSalesBill> data)
        {
            BillNoP.Value = billNo;
            BillDateP.Value = billDate;
            CustomerNameP.Value = customerName;
            BillTypeP.Value = billType;
            objectDataSource1.DataSource = data;
        }

    }
}
