using BLL;
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

namespace QuanLiQuanAnA
{
    public partial class frmHoaDon : Form
    {
        public int IdDonHang { get; set; }
        private readonly ReportService reportService = new ReportService();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            int soDonHang = IdDonHang;

            var listReport = reportService.ListChiTietReport(soDonHang);

            var listReport1 = reportService.ListDonHangReport(soDonHang);

            reportViewer1.LocalReport.ReportPath = "rptHoaDon.rdlc";

            var source = new ReportDataSource("ChiTietDataset", listReport);
            var source1 = new ReportDataSource("DatasetDonHang", listReport1);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.DataSources.Add(source1);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
