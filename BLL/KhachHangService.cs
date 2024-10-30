using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangService
    {
        private readonly RestaurantContextDB _context;

        public KhachHangService()
        {
            _context = new RestaurantContextDB();
        }

        public void AddCustomer(KhachHang khachHang)
        {
            if (khachHang == null)
                throw new ArgumentNullException(nameof(khachHang));

            // Kiểm tra xem khách hàng đã tồn tại chưa
            if (_context.KhachHangs.Any(c => c.SoDienThoai == khachHang.SoDienThoai))
                throw new InvalidOperationException("Khách hàng với số điện thoại này đã tồn tại.");

            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();
        }

        public void UpdateCustomer(KhachHang khachHang)
        {
            if (khachHang == null)
                throw new ArgumentNullException(nameof(khachHang));

            var existingCustomer = _context.KhachHangs.Find(khachHang.Id);
            if (existingCustomer == null)
                throw new InvalidOperationException("Khách hàng không tồn tại.");

            existingCustomer.TenKhach = khachHang.TenKhach;
            existingCustomer.SoDienThoai = khachHang.SoDienThoai;
            existingCustomer.Email = khachHang.Email;

            _context.SaveChanges();
        }

        public KhachHang GetCustomerById(int id)
        {
            var customer = _context.KhachHangs.Find(id);
            if (customer == null)
                throw new InvalidOperationException("Khách hàng không tồn tại.");
            return customer;
        }

        public KhachHang GetCustomerByPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Số điện thoại không hợp lệ.", nameof(phone));

            var customer = _context.KhachHangs.FirstOrDefault(c => c.SoDienThoai == phone);
            if (customer == null)
                throw new InvalidOperationException("Khách hàng không tồn tại với số điện thoại này.");
            return customer;
        }

        public List<KhachHang> GetAllCustomers()
        {
            return _context.KhachHangs.ToList();
        }

        

        public void DeleteCustomer(int id)
        {
            var customer = _context.KhachHangs.Find(id);
            if (customer != null)
            {
                _context.KhachHangs.Remove(customer);
                _context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Khách hàng không tồn tại.");
            }
        }

        // Method to check if a customer exists
        public bool CustomerExists(int customerId)
        {
            return _context.KhachHangs.Any(k => k.Id == customerId);
        }
    }
}
