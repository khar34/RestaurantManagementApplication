using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        private readonly RestaurantContextDB _context;

        public UserService()
        {
            _context = new RestaurantContextDB();
        }

        public bool Login(string username, string password)
        {
            // Kiểm tra thông tin đăng nhập
            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            return user != null;
        }
    }
}
