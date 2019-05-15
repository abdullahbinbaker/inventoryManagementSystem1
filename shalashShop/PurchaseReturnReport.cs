using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;


namespace shalashShop
{
    public partial class PurchaseReturnReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PurchaseReturnReport()
        {
            InitializeComponent();
        }
        public void intiateData(string billNo, string billType, string supplierName, string billDate, List<itemInSalesBill> data)
        {
            BillNoP.Value = billNo;
            BillDateP.Value = billDate;
            SupplierNameP.Value = supplierName;
            BillTypeP.Value = billType;
            objectDataSource1.DataSource = data;
        }

    }
}
