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
using DAL.Entities;
using System.Data.Entity.Infrastructure;
using System.Drawing.Printing;
using System.IO;

namespace QuanLiQuanAnA
{

    public partial class OrderManagementForm : Form
    {
        private readonly TableService _tableService;
        private readonly MenuService _menuService;
        private readonly OrderService _orderService;
        private int? _selectedTableId;
        private List<ChiTietDonHang> _orderDetails;
        private readonly KhachHangService _khachHangService;
        private int _currentOrderId;

        public OrderManagementForm()
        {
            InitializeComponent();
            _tableService = new TableService();
            _menuService = new MenuService();
            _orderService = new OrderService();
            _orderDetails = new List<ChiTietDonHang>();
            _khachHangService = new KhachHangService();
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            LoadTables();
            LoadCategories();
            dgvOrderDetails.AutoGenerateColumns = false;
            SetupOrderDetailsGrid();
        }

        private void LoadTables()
        {
            try
            {
                var tables = _tableService.GetAllTables();
                flpTables.Controls.Clear(); // Clear existing buttons

                foreach (var table in tables)
                {
                    Button btnTable = new Button
                    {
                        Text = table.TenBan, // Display table name
                        Tag = table.Id, // Store table ID in the button's Tag property
                        Width = 145,
                        Height = 145,
                        Font = new Font("SVN-Product Sans", 14.25f, FontStyle.Bold),
                        BackColor = table.TrangThai == "Trống" ? Color.LightGoldenrodYellow : Color.LightCoral // Green for available, Red for occupied
                    };
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "table.png");
                    btnTable.BackgroundImage = Image.FromFile(imagePath); // Tải hình ảnh từ file
                    btnTable.BackgroundImageLayout = ImageLayout.Zoom;
                    btnTable.Click += BtnTable_Click; // Attach click event handler
                    flpTables.Controls.Add(btnTable); // Add button to FlowLayoutPanel
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int tableId = (int)clickedButton.Tag;
                var currentOrder = _orderService.GetOrderByTableId(tableId);

                _selectedTableId = tableId;

                // Xóa thông tin đơn hàng trước đó
                txtOrderId.Text = string.Empty;
                txtCustomerName.Text = string.Empty;
                txtKhachHangId.Text = string.Empty;
                _orderDetails.Clear(); // Thêm dòng này để xóa danh sách chi tiết đơn hàng cũ

                if (currentOrder != null) // Nếu bàn đã có người
                {
                    // Hiển thị thông tin đơn hàng hiện tại
                    txtOrderId.Text = currentOrder.Id.ToString();
                    txtCustomerName.Text = currentOrder.KhachHang.TenKhach;
                    txtKhachHangId.Text = currentOrder.IdKhachHang.ToString();

                    // Cập nhật danh sách chi tiết đơn hàng
                    _orderDetails = currentOrder.ChiTietDonHangs.ToList();

                    // Refresh DataGridView
                    RefreshOrderDetailsGrid();

                    // Cập nhật tổng tiền
                    CalculateTotalAmount();
                }
                else // Nếu bàn trống
                {
                    dgvOrderDetails.DataSource = null;
                    using (CustomInfoForm customInfoForm = new CustomInfoForm())
                    {
                        if (customInfoForm.ShowDialog() == DialogResult.OK)
                        {
                            int newCustomerId = customInfoForm.NewCustomerId;
                            txtKhachHangId.Text = newCustomerId.ToString();

                        }
                    }
                }
            }

        }
            
        
        private void LoadCategories()
        {
            try
            {
                var categories = _menuService.GetAllCategories();
                cbFoodCategories.DataSource = categories;
                cbFoodCategories.DisplayMember = "TenLoai";
                cbFoodCategories.ValueMember = "Id";
                cbFoodCategories.SelectedIndexChanged += (s, e) => LoadFoodItemsByCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách loại sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadFoodItemsByCategory()
        {
            try
            {
                if (cbFoodCategories.SelectedValue is int selectedCategoryId)
                {
                    var foodItems = _menuService.GetMenuItemsByCategoryId(selectedCategoryId);
                    cbFoodItems.DataSource = foodItems;
                    cbFoodItems.DisplayMember = "TenSanPham";
                    cbFoodItems.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn theo loại: {ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetupOrderDetailsGrid()
        {
            
            dgvOrderDetails.Columns.Clear(); // Clear existing columns

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenSanPham",
                HeaderText = "Tên Món Ăn",
                Width = 150
            });

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuong",
                HeaderText = "Số Lượng",
                Width = 80
            });

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gia",
                HeaderText = "Giá (VNĐ)",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C0",
                    FormatProvider = new System.Globalization.CultureInfo("vi-VN")
                }
            });

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ThanhTien",
                HeaderText = "Thành Tiền (VNĐ)",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C0",
                    FormatProvider = new System.Globalization.CultureInfo("vi-VN")
                }
            });
        }

        

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (_selectedTableId == null)
            {
                MessageBox.Show("Vui lòng chọn bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(cbFoodItems.SelectedItem is SanPham selectedFood))
            {
                MessageBox.Show("Vui lòng chọn món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quantity = (int)nudQuantity.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orderDetail = _orderDetails.FirstOrDefault(d => d.IdSanPham == selectedFood.Id);
            if (orderDetail == null)
            {
                orderDetail = new ChiTietDonHang
                {
                    IdSanPham = selectedFood.Id,
                    SoLuong = quantity,
                    Gia = selectedFood.Gia,
                };
                _orderDetails.Add(orderDetail);
            }
            else
            {
                orderDetail.SoLuong += quantity;
            }
            

            RefreshOrderDetailsGrid();
            CalculateTotalAmount();

        }

        private void RefreshOrderDetailsGrid()
        {
            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = _orderDetails.Select(d => new
            {
                TenSanPham = _menuService.GetProductNameById(d.IdSanPham ?? 0),
                d.SoLuong,
                d.Gia,
                ThanhTien = d.Gia * d.SoLuong
            }).ToList();

        }

        private void CalculateTotalAmount()
        {
            var totalAmount = _orderDetails.Sum(d => d.Gia * d.SoLuong);
            lblTotalAmount.Text = totalAmount.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedTableId == null)
                {
                    MessageBox.Show("Vui lòng chọn bàn trước khi lưu đơn hàng.", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var currentOrder = _orderService.GetOrderByTableId(_selectedTableId.Value);

                if (currentOrder != null) // Table already has an order
                {
                    int customerId = currentOrder.IdKhachHang.Value; // Get existing customer ID
                    SaveOrder(customerId);
                }
                else // Table is free
                {
                    int customerId = int.Parse(txtKhachHangId.Text); // Always use the customer ID input
                    SaveOrder(customerId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }


        }
        private void SaveOrder(int customerId)
        {
            if (_selectedTableId == null)
            {
                MessageBox.Show("Chưa chọn bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_orderDetails == null || !_orderDetails.Any())
            {
                MessageBox.Show("Chi tiết đơn hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the customer exists
            if (!_khachHangService.CustomerExists(customerId)) // Use _khachHangService here
            {
                MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create the order object with status set to Pending
            DonHang donHang = new DonHang
            {
                IdKhachHang = customerId,
                IdBan = _selectedTableId.Value,
                TongTien = _orderDetails.Sum(d => d.Gia * d.SoLuong),
                NgayLap = DateTime.Now,
                Status = "Pending" // Set default status to Pending
            };

            try
            {
                Console.WriteLine($"Saving order: IdKhachHang={donHang.IdKhachHang}, IdBan={donHang.IdBan}, TongTien={donHang.TongTien}, TrangThai={donHang.Status}");

                _orderService.AddOrder(donHang, _orderDetails, _selectedTableId.Value);
                _tableService.UpdateTableStatus(_selectedTableId.Value, "Đang phục vụ");

                MessageBox.Show("Đơn hàng đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTables();
            }
            catch (DbUpdateException dbEx)
            {
                var innerExceptionMessage = dbEx.InnerException?.Message ?? dbEx.Message;
                MessageBox.Show($"Lỗi khi lưu đơn hàng: {innerExceptionMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (_selectedTableId == null || string.IsNullOrEmpty(txtOrderId.Text))
            {
                MessageBox.Show("Vui lòng chọn bàn và lưu đơn hàng trước khi thanh toán.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_orderDetails.Any())
            {
                MessageBox.Show("Không có món ăn nào trong đơn hàng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var paymentMethod = rbCash.Checked ? "Cash" : "MoMo";
            ProcessPayment(paymentMethod);
        }
        private void ProcessPayment(string paymentMethod)
        {
            try
            {
                if (paymentMethod == "Cash")
                {
                    CompleteOrder("Cash");
                }
                else if (paymentMethod == "MoMo")
                {
                    // Lấy thông tin đơn hàng
                    var orderId = txtOrderId.Text;
                    var amount = _orderDetails.Sum(d => d.Gia * d.SoLuong);

                    // Tạo nội dung thanh toán MoMo
                    var momoData = CreateMomoPaymentData(orderId, amount);
                    ShowQrCode(momoData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý thanh toán: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CreateMomoPaymentData(string orderId, decimal amount)
        {
            const string MOMO_PHONE = "0353343110"; // Thay bằng số điện thoại MoMo của bạn

            // Format: phone=<số điện thoại>&amount=<số tiền>&note=<nội dung>
            return $"2|99|{MOMO_PHONE}|{MOMO_PHONE}|doncuahang{orderId}|0|0|{amount}";
        }

        private void CompleteOrder(string paymentMethod)
        {
            
            try
            {
                var orderId = int.Parse(txtOrderId.Text);
                var totalAmount = _orderDetails.Sum(d => d.Gia * d.SoLuong);

                bool paymentSuccess = _orderService.ProcessPayment(orderId, totalAmount, paymentMethod);

                if (paymentSuccess)
                {
                    // Update table status to available
                    _tableService.UpdateTableStatus(_selectedTableId.Value, "Trống");
                    // Update order status to Paid
                    _orderService.UpdateOrderStatus(orderId, "Paid");

                    // Record the payment in ThanhToan table
                    var payment = new ThanhToan
                    {
                        IdDonHang = orderId,
                        SoTien = totalAmount,
                        HinhThucThanhToan = paymentMethod,
                        NgayThanhToan = DateTime.Now
                    };
                    _orderService.RecordPayment(orderId,totalAmount,paymentMethod);

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetOrder();
                    LoadTables(); // Refresh the table list to reflect changes
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hoàn tất đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowQrCode(string qrCodeData)
        {
            using (var qrCodeForm = new QrCodeForm(qrCodeData))
            {
                if (qrCodeForm.ShowDialog() == DialogResult.OK)
                {
                    // Người dùng xác nhận đã thanh toán
                    CompleteOrder("MoMo");
                }
                else
                {
                    MessageBox.Show("Thanh toán chưa hoàn thành.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ResetOrder()
        {
           
            txtOrderId.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtKhachHangId.Text = string.Empty;
            _orderDetails.Clear();
            dgvOrderDetails.DataSource = null;
            lblTotalAmount.Text = "0 VNĐ"; 
            _selectedTableId = null; 
        }


        private void btnPrintReceipt_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNhapMaDonHang.Text))
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng cần in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int orderId = int.Parse(txtNhapMaDonHang.Text);
                var order = _orderService.GetOrderById(orderId);
                if (order == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmHoaDon frm = new frmHoaDon();
                frm.IdDonHang = int.Parse(txtNhapMaDonHang.Text);
                frm.ShowDialog();
                // Cập nhật ID bàn sau khi in hóa đơn
                _orderService.UpdateOrderTableId(order.Id);
                lblTotalAmount.Text = "0 VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị bản in: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
