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
    public partial class ItemReportPrintFrame : Form
    {
        List<itemInItemReportForm> _list;
        ReportDataSource rs1 = new ReportDataSource();
        public ItemReportPrintFrame(List<itemInItemReportForm> list)
        {
            _list = list;
            InitializeComponent();
        }

        private void ItemReportPrintFrame_Load(object sender, EventArgs e)
        {

            rs1.Name = "DataSet2";
            rs1.Value = _list;
            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(rs1);
            reportViewer3.LocalReport.ReportEmbeddedResource = "shalashShop.ItemReportPrintReport.rdlc";

            //Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            //{
            //};
            //this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {

        }
    }
}
