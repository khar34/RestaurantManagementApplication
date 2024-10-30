using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class OrderService
    {
        private readonly RestaurantContextDB _context;

        public OrderService()
        {
            _context = new RestaurantContextDB();
        }

        

        public void AddOrder(DonHang donHang, List<ChiTietDonHang> orderDetails, int tableId)
        {
            if (donHang == null)
                throw new ArgumentNullException(nameof(donHang));

            if (orderDetails == null || !orderDetails.Any())
                throw new ArgumentException("Chi tiết đơn hàng không được để trống.", nameof(orderDetails));

            // Khởi tạo đơn hàng
            donHang.NgayLap = DateTime.Now; // Cập nhật ngày lập đơn hàng
            donHang.ChiTietDonHangs = orderDetails.Select(d => new ChiTietDonHang
            {
                IdSanPham = d.IdSanPham,
                SoLuong = d.SoLuong,
                Gia = d.Gia
            }).ToList();

            // Thêm đơn hàng vào cơ sở dữ liệu
            _context.DonHangs.Add(donHang);
            _context.SaveChanges();

            // Cập nhật trạng thái bàn sau khi đặt đơn hàng
            UpdateTableStatus(tableId, "Có người");
        }

        public void UpdateTableStatus(int tableId, string status)
        {
            var table = _context.Bans.Find(tableId);
            if (table != null)
            {
                table.TrangThai = status;
                _context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Bàn không tồn tại.");
            }
        }

        public DonHang GetOrderByTableId(int tableId)
        {
            return _context.DonHangs
                .Include("KhachHang") 
                .Include("ChiTietDonHangs") 
                .FirstOrDefault(d => d.IdBan == tableId);
        }

        public bool ProcessPayment(int orderId, decimal amount, string paymentMethod)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                   
                    var order = _context.DonHangs.Find(orderId);
                    if (order == null)
                    {
                        throw new Exception("Không tìm thấy đơn hàng.");
                    }

                    
                    var totalAmount = CalculateTotalAmount(orderId);
                    if (amount != totalAmount)
                    {
                        throw new Exception("Thanh toán không đủ.");
                    }

                    
                    order.Status = "Paid";
                    _context.SaveChanges();

                    
                    var payment = new ThanhToan
                    {
                        IdDonHang = orderId,
                        NgayThanhToan = DateTime.Now,
                        SoTien = amount,
                        HinhThucThanhToan = paymentMethod
                    };
                    _context.ThanhToans.Add(payment);
                    _context.SaveChanges();

                    
                    UpdateTableStatus(order.IdBan ?? 0, "Trống");

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Payment processing failed: {ex.Message}");
                }
            }
        }
        public decimal CalculateTotalAmount(int orderId)
        {
            
            var orderDetails = _context.ChiTietDonHangs.Where(od => od.IdDonHang == orderId);
            return orderDetails.Sum(od => od.SoLuong * od.Gia); 
        }

        

        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            var order = _context.DonHangs.Find(orderId);
            if (order != null)
            {
                order.Status = newStatus; 
                _context.SaveChanges(); 
            }
            else
            {
                throw new Exception("Đơn hàng không tồn tại."); 
            }
        }
        public DonHang GetOrderById(int orderId)
        {
            try
            {
                return _context.DonHangs
                    .Include("KhachHang") 
                    .Include("ChiTietDonHangs") 
                    .Include("ChiTietDonHangs.SanPham") 
                    .FirstOrDefault(d => d.Id == orderId);
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Lỗi: {ex.Message}");
                throw new Exception($"Không tìm thấy ID{orderId}", ex);
            }
        }
        public bool RecordPayment(int orderId, decimal amount, string paymentMethod)
        {
            try
            {
                
                var payment = new ThanhToan
                {
                    IdDonHang = orderId,
                    SoTien = amount,
                    HinhThucThanhToan = paymentMethod,
                    NgayThanhToan = DateTime.Now
                };

                
                _context.ThanhToans.Add(payment);

                
                var order = _context.DonHangs.Find(orderId);
                if (order != null)
                {
                    order.Status = "Paid"; 
                }

                
                _context.SaveChanges();

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi lưu thông tin thanh toán: {ex.Message}");
                return false; 
            }
        }

        public void UpdateOrderTableId(int orderId)
        {
            try
            {
                var order = _context.DonHangs.Find(orderId);
                if (order != null)
                {
                    order.IdBan = null; // Xóa ID bàn
                    _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật ID bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
