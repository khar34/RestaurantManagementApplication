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
    public partial class CustomInfoForm : Form
    {
        public int NewCustomerId { get; private set; }
        private readonly KhachHangService _khachHangService;

        public CustomInfoForm()
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var tenKhach = txtTenKhach.Text.Trim();
            var soDienThoai = txtSoDienThoai.Text.Trim();
            var email = txtEmail.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(tenKhach))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var khachHang = new KhachHang
            {
                TenKhach = tenKhach,
                SoDienThoai = soDienThoai, // Always keep the phone number
                Email = string.IsNullOrEmpty(email) ? null : email
            };

            try
            {
                _khachHangService.AddCustomer(khachHang);
                NewCustomerId = khachHang.Id; // Store the new customer ID
                MessageBox.Show("Khách hàng đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Return OK result
                this.Close(); // Close the form
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Lỗi khi lưu khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
