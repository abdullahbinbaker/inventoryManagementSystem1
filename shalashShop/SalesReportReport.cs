using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace shalashShop
{
    public partial class SalesReportReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SalesReportReport()
        {
            InitializeComponent();
        }

        public void intiateData(List<BillShortInformation> data)
        {
            objectDataSource1.DataSource = data;
        }
    }
}
