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
    public partial class frmMain : Form
    {
        private Point _mouseOffset;
        private Button _activeButton;
        private frmDashboard _dashboardInstance;
        private OrderManagementForm _orderManagementFormInstance;
        private frmPaymentHistory _paymentHistoryInstance;
        private frmManagement _frmManagementInstance;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Check if the dashboard form is already open
            if (_dashboardInstance == null || _dashboardInstance.IsDisposed)
            {
                // If not open, create a new instance
                LoadDashboardInstance();

                // Set the current button as active
                ActivateButton((Button)sender);
            }
            else
            {
                // If already open, bring it to the front
                _dashboardInstance.BringToFront();

                // Set the current button as active
                ActivateButton((Button)sender);
            }
        }

        private void ActivateButton(Button btn)
        {
            // Reset the previous active button's color
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.LavenderBlush; // Reset to default color
            }

            // Set the new active button and change its color
            _activeButton = btn;
            _activeButton.BackColor = Color.Azure; // Change to active color
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadOrderingInstance();
            LoadDashboardInstance();
            
            
            
        }

        private void LoadDashboardInstance()
        {
            _dashboardInstance = new frmDashboard();
            _dashboardInstance.MdiParent = this;
            _dashboardInstance.Dock = DockStyle.Fill;
            _dashboardInstance.Show();

        }

        private void LoadOrderingInstance()
        {
            _orderManagementFormInstance = new OrderManagementForm();
            _orderManagementFormInstance.MdiParent = this;
            _orderManagementFormInstance.Dock = DockStyle.Fill;
            _orderManagementFormInstance.Show();

        }

        private void LoadPaymentHIstoryInstance()
        {
            _paymentHistoryInstance = new frmPaymentHistory();
            _paymentHistoryInstance.MdiParent = this;
            _paymentHistoryInstance.Dock = DockStyle.Fill;
            _paymentHistoryInstance.Show();

        }

        private void LoadManagementInstance()
        {
            _frmManagementInstance = new frmManagement();
            _frmManagementInstance.MdiParent = this;
            _frmManagementInstance.Dock = DockStyle.Fill;
            _frmManagementInstance.Show();

        }


        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Ensure only left click starts the drag
            {
                _mouseOffset = e.Location;
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Get the new position of the form, relative to the screen
                Point newPosition = MousePosition;

                // Calculate the form's new top-left corner by subtracting the mouse offset
                newPosition.Offset(-_mouseOffset.X, -_mouseOffset.Y);

                // Update the form's location
                Location = newPosition;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát", "Đồng ý thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {
            // Check if the dashboard form is already open
            if (_orderManagementFormInstance == null || _orderManagementFormInstance.IsDisposed)
            {

                LoadOrderingInstance();
                // Set the current button as active
                ActivateButton((Button)sender);
            }
            else
            {
                // If already open, bring it to the front
                _orderManagementFormInstance.BringToFront();

                // Set the current button as active
                ActivateButton((Button)sender);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Check if the dashboard form is already open
            if (_paymentHistoryInstance == null || _paymentHistoryInstance.IsDisposed)
            {

                LoadPaymentHIstoryInstance();
                // Set the current button as active
                ActivateButton((Button)sender);
            }
            else
            {
                // If already open, bring it to the front
                _paymentHistoryInstance.BringToFront();

                // Set the current button as active
                ActivateButton((Button)sender);
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            // Check if the dashboard form is already open
            if (_frmManagementInstance == null || _frmManagementInstance.IsDisposed)
            {

                LoadManagementInstance();
                // Set the current button as active
                ActivateButton((Button)sender);
            }
            else
            {
                // If already open, bring it to the front
                _frmManagementInstance.BringToFront();

                // Set the current button as active
                ActivateButton((Button)sender);
            }
        }
    }
}
