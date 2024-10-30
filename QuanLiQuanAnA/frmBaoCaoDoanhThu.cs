using BLL;
using DAL.Entities;
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
    public partial class frmBaoCaoDoanhThu : Form
    {
        private readonly ReportService reportService = new ReportService();
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int thang = (int)numThang.Value;
            int nam = (int)numNam.Value;

            // Check if the report already exists
            var existingReport = reportService.DoanhThuReport(thang, nam);
            if (existingReport.Any())
            {
                MessageBox.Show("Báo cáo cho tháng và năm đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Calculate total revenue for the month
            var listDonHang = reportService.DonHangReport(thang, nam);
            decimal tongDoanhThu = listDonHang.Sum(dh => dh.TongTien);

            // Create a new revenue report
            BaoCaoDoanhThu baoCao = new BaoCaoDoanhThu
            {
                Thang = thang,
                Nam = nam,
                TongDoanhThu = tongDoanhThu
            };

            reportService.AddBaoCao(baoCao);

            MessageBox.Show("Báo cáo đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            int thang = (int)numThang.Value;
            int nam = (int)numNam.Value;

            // Open the report form and pass the selected month and year
            frmDoanhThu frm = new frmDoanhThu { Thang = thang, Nam = nam };
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
