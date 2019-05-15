using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace shalashShop
{
    public partial class PurchaseReportReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PurchaseReportReport()
        {
            InitializeComponent();
        }

        public void intiateData(List<BillShortInformation> data)
        {
            objectDataSource4.DataSource = data;
        }
    }
}
