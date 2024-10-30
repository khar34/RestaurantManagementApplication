using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TableService
    {
        private readonly RestaurantContextDB _context;

        public TableService()
        {
            _context = new RestaurantContextDB();
        }

        public List<Ban> GetAllTables()
        {
            return _context.Bans.ToList();
        }

        public void AddTable(string tableName)
        {
            var newTable = new Ban { TenBan = tableName, TrangThai = "Trống" };
            _context.Bans.Add(newTable);
            _context.SaveChanges();
        }

        public void UpdateTable(int tableId, string tableName)
        {
            var table = _context.Bans.Find(tableId);
            if (table == null) throw new Exception("Bàn không tồn tại.");
            table.TenBan = tableName;
            _context.SaveChanges();
        }

        public void DeleteTable(int tableId)
        {
            var table = _context.Bans.Find(tableId);
            if (table == null) throw new Exception("Bàn không tồn tại.");
            _context.Bans.Remove(table);
            _context.SaveChanges();
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

        public string GetTableName(int? tableId)
        {
            if (tableId == null)
                return "Unknown";

            try
            {
                var table = _context.Bans.FirstOrDefault(b => b.Id == tableId);
                return table?.TenBan ?? "Unknown";
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Error getting table name: {ex.Message}");
                return "Error";
            }
        }
    }
}
