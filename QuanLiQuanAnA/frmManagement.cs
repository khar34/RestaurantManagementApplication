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
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }

        private void btnQuanLiMenu_Click(object sender, EventArgs e)
        {
            MenuManagementForm frmMenu = new MenuManagementForm();
            frmMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableManagementForm frmTable = new TableManagementForm();
            frmTable.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu BaoCaoDoanhThu = new frmBaoCaoDoanhThu();
            BaoCaoDoanhThu.ShowDialog();
        }

        private void btnViewKH_Click(object sender, EventArgs e)
        {
            frmViewCustomer viewCustomer = new frmViewCustomer();
            viewCustomer.ShowDialog();
        }
    }
}
