using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace shalashShop
{
    public partial class PurchaseBillReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PurchaseBillReport()
        {
            InitializeComponent();
        }

        public void intiateData(string billNo, string billType, string supplierName, string billDate, List<itemInPurchaseBill> data, decimal PurchaseBillTotalAfterDiscount, decimal originalPurchaseBillNo, decimal Discount)
        {
            PurchaseBillNoP.Value = billNo;
            BillDateP.Value = billDate;
            SupplierNameP.Value = supplierName;
            BillTypeP.Value = billType;
            totalPriceAfterDiscountP.Value = PurchaseBillTotalAfterDiscount;
            originalPurchaseBillNoP.Value = originalPurchaseBillNo;
            DiscountP.Value = Discount;
            objectDataSource1.DataSource = data;
        }
    }
}
