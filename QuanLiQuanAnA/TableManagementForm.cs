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

namespace QuanLiQuanAnA
{
    public partial class TableManagementForm : Form
    {
        private readonly TableService _tableService;
        private int? _selectedTableId;
        public TableManagementForm()
        {
            InitializeComponent();
            _tableService = new TableService();
        }

        private void TableManagementForm_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {
            try
            {
                dgvTables.DataSource = _tableService.GetAllTables();

                // Đổi tên cột
                dgvTables.Columns["TenBan"].HeaderText = "Tên Bàn"; // Đổi tên cột Tên Bàn
                dgvTables.Columns["DONHANGs"].HeaderText = "Đơn Hàng"; // Đổi tên cột Đơn Hàng

                // Ẩn cột DONHANGs
                if (dgvTables.Columns["DONHANGs"] != null)
                {
                    dgvTables.Columns["DONHANGs"].Visible = false; // Ẩn cột Đơn Hàng
                }

                dgvTables.ClearSelection();
                txtTableName.Clear();
                _selectedTableId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTables.CurrentRow != null)
            {
                _selectedTableId = (int)dgvTables.CurrentRow.Cells["Id"].Value;
                txtTableName.Text = dgvTables.CurrentRow.Cells["TenBan"].Value.ToString();
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = txtTableName.Text.Trim();
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    MessageBox.Show("Vui lòng nhập tên bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _tableService.AddTable(tableName);
                LoadTables();
                MessageBox.Show("Thêm bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (!_selectedTableId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn bàn cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tableName = txtTableName.Text.Trim();
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    MessageBox.Show("Vui lòng nhập tên bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _tableService.UpdateTable(_selectedTableId.Value, tableName);
                LoadTables();
                MessageBox.Show("Sửa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (!_selectedTableId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _tableService.DeleteTable(_selectedTableId.Value);
                LoadTables();
                MessageBox.Show("Xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
