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
    public partial class frmDoanhThu : Form
    {
        private readonly ReportService reportService = new ReportService();
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        public int Thang { get; set; }
        public int Nam { get; set; }



        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            int thang = Thang;
            int nam = Nam;

            var listDoanhThuReport = reportService.DoanhThuReport(thang, nam);
            var listDonHangReport = reportService.DonHangReport(thang, nam);

            reportViewer1.LocalReport.ReportPath = "rptDoanhThu.rdlc"; 

            var source = new ReportDataSource("DoanhThuDataset", listDoanhThuReport);
            var source1 = new ReportDataSource("DonHangDataset", listDonHangReport);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.DataSources.Add(source1);

            this.reportViewer1.RefreshReport();
        }
    }
}

