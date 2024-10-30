using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Datasets;
using System.Runtime.Remoting.Contexts;

namespace BLL
{
    public class ReportService
    {
        public List<BaoCaoDoanhThu> DoanhThuReport(int thang, int nam)
        {
            RestaurantContextDB context = new RestaurantContextDB();
            return context.BaoCaoDoanhThus.Where(p => p.Thang == thang && p.Nam == nam).ToList();
        }
        public List<DonHang> DonHangReport(int thang, int nam)
        {
            RestaurantContextDB context = new RestaurantContextDB();
            return context.DonHangs.Where(d => d.NgayLap.Month == thang && d.NgayLap.Year == nam).ToList();
        }
        public void AddBaoCao(BaoCaoDoanhThu baoCao)
        {
            RestaurantContextDB context = new RestaurantContextDB();
            context.BaoCaoDoanhThus.Add(baoCao);
            context.SaveChanges();
        }
        public List<ChiTietDonHang> ChiTietReport(int soDonHang)
        {
            RestaurantContextDB context = new RestaurantContextDB();
            return context.ChiTietDonHangs.Where(c => c.IdDonHang == soDonHang).ToList();
        }

        public List<ChiTietReport> ListChiTietReport(int soDonHang)
        {
            var listChiTiet = ChiTietReport(soDonHang);

            List<ChiTietReport> listReport = new List<ChiTietReport>();
            foreach (ChiTietDonHang chiTiet in listChiTiet)
            {
                ChiTietReport temp = new ChiTietReport();
                temp.TenSanPham = chiTiet.SanPham.TenSanPham;
                temp.SoLuong = chiTiet.SoLuong;
                temp.Gia = chiTiet.SanPham.Gia;
                temp.ThanhTien = chiTiet.Gia;
                listReport.Add(temp);
            }
            return listReport;
        }

        public DonHang DonHangReport(int soDonHang)
        {
            RestaurantContextDB context = new RestaurantContextDB();
            return context.DonHangs.FirstOrDefault(d => d.Id == soDonHang);
        }

        public List<HoaDonReport> ListDonHangReport(int soDonHang)
        {
            var donHang = DonHangReport(soDonHang);

            List<HoaDonReport> listReport = new List<HoaDonReport>();
            HoaDonReport temp = new HoaDonReport();
            temp.soDonHang = donHang.Id;
            temp.NgayLap = donHang.NgayLap;
            temp.TongTien = donHang.TongTien;
            listReport.Add(temp);
            return listReport;
        }
    }
}
