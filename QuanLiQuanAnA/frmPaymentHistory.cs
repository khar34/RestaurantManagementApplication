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
    }
}
