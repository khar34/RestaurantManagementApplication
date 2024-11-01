-- Tạo cơ sở dữ liệu
CREATE DATABASE QUANLIQUANANDB;
GO

USE QUANLIQUANANDB;
GO

-- Bảng loại sản phẩm
CREATE TABLE LoaiSanPham (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TenLoai NVARCHAR(100) NOT NULL
);

-- Bảng sản phẩm
CREATE TABLE SanPham (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TenSanPham NVARCHAR(100) NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    IdLoai INT,
    CONSTRAINT FK_SanPham_LoaiSanPham FOREIGN KEY (IdLoai) REFERENCES LoaiSanPham(Id)
);

-- Bảng bàn
CREATE TABLE Ban (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TenBan NVARCHAR(50) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL DEFAULT ('Trống') -- Trống, Đang phục vụ
);

-- Bảng khách hàng
CREATE TABLE KhachHang (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TenKhach NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) NULL
);

-- Bảng đơn hàng
CREATE TABLE DonHang (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdBan INT,
    IdKhachHang INT,
    NgayLap DATETIME NOT NULL DEFAULT (GETDATE()),
    TongTien DECIMAL(18, 2) NOT NULL DEFAULT (0.0),
    Status NVARCHAR(50) NOT NULL DEFAULT 'Pending',
    CONSTRAINT FK_DonHang_Ban FOREIGN KEY (IdBan) REFERENCES Ban(Id),
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (IdKhachHang) REFERENCES KhachHang(Id)
);

-- Bảng chi tiết đơn hàng
CREATE TABLE ChiTietDonHang (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdDonHang INT,
    IdSanPham INT,
    SoLuong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    CONSTRAINT FK_ChiTietDonHang_DonHang FOREIGN KEY (IdDonHang) REFERENCES DonHang(Id),
    CONSTRAINT FK_ChiTietDonHang_SanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id)
);

-- Bảng thanh toán
CREATE TABLE ThanhToan (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdDonHang INT,
    HinhThucThanhToan NVARCHAR(50) NOT NULL, -- Tiền mặt, Thẻ, Online
    NgayThanhToan DATETIME NOT NULL DEFAULT (GETDATE()),
    SoTien DECIMAL(18, 2) NOT NULL,
    CONSTRAINT FK_ThanhToan_DonHang FOREIGN KEY (IdDonHang) REFERENCES DonHang(Id)
);

-- Bảng báo cáo doanh thu
CREATE TABLE BaoCaoDoanhThu (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Thang INT NOT NULL,
    Nam INT NOT NULL,
    TongDoanhThu DECIMAL(18, 2) NOT NULL,
    CONSTRAINT UQ_BaoCaoDoanhThu UNIQUE(Thang, Nam)
);

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL, -- Mật khẩu nên được mã hóa
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL DEFAULT ('Staff'), -- Chức vụ người dùng (Admin, Staff, v.v.)
    CreateAt DATETIME NOT NULL DEFAULT (GETDATE())
);