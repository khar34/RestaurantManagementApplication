using BLL;
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
    public partial class LoginForm : Form
    {
        public Point mouseLocation;
        private readonly UserService _userService;
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
            var posi = this.PointToScreen(topPanel.Location);
            posi = panel1.PointToClient(posi);
            topPanel.Parent = panel1;
            topPanel.Location = posi;
            topPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var username = mtxtLoginID.Text;
            var password = mtxtPassword.Text;

            if (_userService.Login(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở form chính ở đây, ví dụ:
                var frmMain = new frmMain();
                frmMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
