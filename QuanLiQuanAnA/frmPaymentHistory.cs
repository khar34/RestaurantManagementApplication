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
    public partial class frmPaymentHistory : Form
    {
        public frmPaymentHistory()
        {
            InitializeComponent();
        }

        private void frmPaymentHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIQUANANDBDataSet.ChiTietDonHang' table. You can move, or remove it, as needed.
            this.chiTietDonHangTableAdapter.Fill(this.qUANLIQUANANDBDataSet.ChiTietDonHang);
            // TODO: This line of code loads data into the 'qUANLIQUANANDBDataSet.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this.qUANLIQUANANDBDataSet.DonHang);
            // TODO: This line of code loads data into the 'qUANLIQUANANDBDataSet.ThanhToan' table. You can move, or remove it, as needed.
            this.thanhToanTableAdapter.Fill(this.qUANLIQUANANDBDataSet.ThanhToan);

        }

        private void dtpStart1_ValueChanged(object sender, EventArgs e)
        {
            FilterThanhToanData();
        }

        private void dtpEnd1_ValueChanged(object sender, EventArgs e)
        {
            FilterThanhToanData();
        }

        private void dtpStart2_ValueChanged(object sender, EventArgs e)
        {
            FilterDonHangData();
        }

        private void dtpEnd2_ValueChanged(object sender, EventArgs e)
        {
            FilterDonHangData();
        }

        private void FilterThanhToanData()
        {
            DateTime startDate = dtpStart1.Value.Date;
            DateTime endDate = dtpEnd1.Value.Date.AddDays(1).AddTicks(-1); // Kết thúc ngày hiện tại

            // Lọc dữ liệu trong nguồn dữ liệu "ThanhToan"
            thanhToanBindingSource.Filter = $"NgayThanhToan >= #{startDate}# AND NgayThanhToan <= #{endDate}#";
        }

        private void FilterDonHangData()
        {
            DateTime startDate = dtpStart2.Value.Date;
            DateTime endDate = dtpEnd2.Value.Date.AddDays(1).AddTicks(-1); // Kết thúc ngày hiện tại

            // Lọc dữ liệu trong nguồn dữ liệu "DonHang"
            donHangBindingSource1.Filter = $"NgayLap >= #{startDate}# AND NgayLap <= #{endDate}#";
        }
    }
}
