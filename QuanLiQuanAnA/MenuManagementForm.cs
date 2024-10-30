    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Entities;

namespace QuanLiQuanAnA
{
    public partial class MenuManagementForm : Form
    {
        private MenuService _menuService;
        private int? _selectedFoodId;
        public MenuManagementForm()
        {
            InitializeComponent();
            _menuService = new MenuService();
        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {
            LoadMenu();
            LoadCategories();
        }

        private void LoadMenu()
        {
            try
            {
                var menuItems = _menuService.GetAllMenuItems();

                // Chuyển đổi danh sách vào DataTable để gán cho DataGridView
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("TenSanPham", typeof(string));
                dataTable.Columns.Add("Gia", typeof(decimal));
                dataTable.Columns.Add("LoaiSanPhamId", typeof(int)); // Mã loại sản phẩm
                dataTable.Columns.Add("LoaiSanPhamName", typeof(string)); // Tên loại sản phẩm

                foreach (var item in menuItems)
                {
                    dataTable.Rows.Add(item.Id, item.TenSanPham, item.Gia, item.IdLoai, item.LoaiSanPham?.TenLoai); // Lấy tên loại món
                }

                dgvMenu.DataSource = dataTable;

                // Định dạng giá tiền
                dgvMenu.Columns["Gia"].DefaultCellStyle.Format = "C0";
                dgvMenu.Columns["Gia"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");

                // Ẩn cột Id và LoaiSanPhamId nếu không cần hiển thị
                dgvMenu.Columns["Id"].Visible = false;
                dgvMenu.Columns["LoaiSanPhamId"].Visible = false;

                // Đặt tên cho các cột
                dgvMenu.Columns["TenSanPham"].HeaderText = "Tên Món Ăn";
                dgvMenu.Columns["Gia"].HeaderText = "Giá (VNĐ)";
                dgvMenu.Columns["LoaiSanPhamName"].HeaderText = "Loại Món";

                dgvMenu.ClearSelection();
                txtFoodName.Clear();
                nudPrice.Value = 0;
                _selectedFoodId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                cbFoodCategory.DataSource = _menuService.GetAllCategories();
                cbFoodCategory.DisplayMember = "TenLoai";
                cbFoodCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách loại món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow != null)
            {
                _selectedFoodId = (int)dgvMenu.CurrentRow.Cells["Id"].Value;
                txtFoodName.Text = dgvMenu.CurrentRow.Cells["TenSanPham"].Value.ToString();
                nudPrice.Value = (decimal)dgvMenu.CurrentRow.Cells["Gia"].Value;
                cbFoodCategory.SelectedValue = dgvMenu.CurrentRow.Cells["LoaiSanPhamId"].Value; // Lấy mã loại sản phẩm
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string foodName = txtFoodName.Text.Trim();
                decimal price = nudPrice.Value;
                int categoryId = (int)cbFoodCategory.SelectedValue;

                if (string.IsNullOrWhiteSpace(foodName))
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _menuService.AddMenuItem(foodName, price, categoryId);
                LoadMenu();
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (!_selectedFoodId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string foodName = txtFoodName.Text.Trim();
                decimal price = nudPrice.Value;
                int categoryId = (int)cbFoodCategory.SelectedValue;

                if (string.IsNullOrWhiteSpace(foodName))
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _menuService.UpdateMenuItem(_selectedFoodId.Value, foodName, price, categoryId);
                LoadMenu();
                MessageBox.Show("Sửa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (!_selectedFoodId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _menuService.DeleteMenuItem(_selectedFoodId.Value);
                    LoadMenu();
                    MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Lỗi dữ liệu: {e.Exception.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuManagementForm_MouseClick(object sender, MouseEventArgs e)
        {
            // Hủy việc chọn ô trong DataGridView
            dgvMenu.ClearSelection();
            _selectedFoodId = null; // Reset ID khi không có món ăn được chọn
            ClearScreen();
        }

        private void ClearScreen()
        {
            txtFoodName.Clear();
            cbFoodCategory.SelectedIndex = 0;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
