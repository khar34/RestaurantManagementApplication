using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class RestaurantContextDB : DbContext
    {
        public RestaurantContextDB()
            : base("name=RestaurantContextDB")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<BaoCaoDoanhThu> BaoCaoDoanhThus { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.DonHangs)
                .WithOptional(e => e.Ban)
                .HasForeignKey(e => e.IdBan);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithOptional(e => e.DonHang)
                .HasForeignKey(e => e.IdDonHang);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ThanhToans)
                .WithOptional(e => e.DonHang)
                .HasForeignKey(e => e.IdDonHang);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DonHangs)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.IdKhachHang);

            modelBuilder.Entity<LoaiSanPham>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.LoaiSanPham)
                .HasForeignKey(e => e.IdLoai);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithOptional(e => e.SanPham)
                .HasForeignKey(e => e.IdSanPham);
        }
    }
}
