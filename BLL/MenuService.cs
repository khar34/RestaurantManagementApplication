using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuService
    {
        private readonly RestaurantContextDB _context;

        public MenuService()
        {
            _context = new RestaurantContextDB();
        }
        

        public void AddMenuItem(string foodName, decimal price, int categoryId)
        {
            using (var context = new RestaurantContextDB())
            {
                var newItem = new SanPham
                {
                    TenSanPham = foodName,
                    Gia = price,
                    IdLoai = categoryId
                };
                context.SanPhams.Add(newItem);
                context.SaveChanges();
            }
        }

        public void UpdateMenuItem(int id, string foodName, decimal price, int categoryId)
        {
            using (var context = new RestaurantContextDB())
            {
                var item = context.SanPhams.Find(id);
                if (item != null)
                {
                    item.TenSanPham = foodName;
                    item.Gia = price;
                    item.IdLoai = categoryId;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteMenuItem(int id)
        {
            using (var context = new RestaurantContextDB())
            {
                var item = context.SanPhams.Find(id);
                if (item != null)
                {
                    context.SanPhams.Remove(item);
                    context.SaveChanges();
                }
            }
        }

        // Lấy tất cả các loại sản phẩm (Loại Sản Phẩm)
        public List<LoaiSanPham> GetAllCategories()
        {
            return _context.LoaiSanPhams.ToList();
        }

        // Lấy danh sách món ăn theo loại sản phẩm
        public List<SanPham> GetMenuItemsByCategoryId(int categoryId)
        {
            return _context.SanPhams
                .Where(sp => sp.IdLoai == categoryId)
                .ToList();
        }

        // Lấy tên sản phẩm theo Id (phục vụ cho DataGridView)
        public string GetProductNameById(int productId)
        {
            var product = _context.SanPhams.Find(productId);
            return product != null ? product.TenSanPham : "N/A";
        }

        // Lấy tất cả sản phẩm (dùng cho việc tải toàn bộ món ăn nếu cần)
        public List<SanPham> GetAllMenuItems()
        {
            return _context.SanPhams.ToList();
        }
    }
}
