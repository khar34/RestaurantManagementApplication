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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            // Khởi động Timer
            timerClock.Interval = 1000; // 1 giây
            timerClock.Tick += TimerClock_Tick; // Gán sự kiện Tick
            timerClock.Start(); // Bắt đầu Timer
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // Get the current hour
            int currentHour = DateTime.Now.Hour;

            // Determine the greeting based on the time
            if (currentHour >= 6 && currentHour < 12)
            {
                lblGreeting.Text = "Chào buổi sáng ~";
            }
            else if (currentHour >= 12 && currentHour < 18)
            {
                lblGreeting.Text = "Chào buổi chiều ~";
            }
            else
            {
                lblGreeting.Text = "Chào buổi tối ~ ";
            }
        }
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            // Cập nhật giờ hiện tại vào Label
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss"); // Định dạng giờ theo định dạng 24 giờ
        }

    }
}
