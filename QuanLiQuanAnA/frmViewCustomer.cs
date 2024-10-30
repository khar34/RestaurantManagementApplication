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
    public partial class frmViewCustomer : Form
    {
        public frmViewCustomer()
        {
            InitializeComponent();
        }

        private void frmViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIQUANANDBDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qUANLIQUANANDBDataSet.KhachHang);

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
