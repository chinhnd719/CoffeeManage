USE [master]
GO
/****** Object:  Database [CoffeeManage]    Script Date: 17/12/2020 3:05:21 ******/
CREATE DATABASE [CoffeeManage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeManage', FILENAME = N'F:\Program Files\SQL Sever\MSSQL12.MSSQLSERVER\MSSQL\DATA\CoffeeManage.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CoffeeManage_log', FILENAME = N'F:\Program Files\SQL Sever\MSSQL12.MSSQLSERVER\MSSQL\DATA\CoffeeManage_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CoffeeManage] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeManage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeManage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeManage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeManage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeManage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeManage] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeManage] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CoffeeManage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeManage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeManage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeManage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeManage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeManage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeManage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeManage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeManage] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CoffeeManage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeManage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeManage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeManage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeManage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeManage] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [CoffeeManage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeManage] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoffeeManage] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeManage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeManage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeManage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeManage] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CoffeeManage] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CoffeeManage]
GO
/****** Object:  Table [dbo].[bangluong]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bangluong](
	[MaNV] [nvarchar](450) NOT NULL,
	[TienThuong] [int] NOT NULL,
	[TamUng] [int] NOT NULL,
	[Luong] [int] NOT NULL,
 CONSTRAINT [PK_bangluong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietnhap]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietnhap](
	[MaNhap] [nvarchar](450) NOT NULL,
	[DVT] [nvarchar](max) NULL,
	[Ngay] [nvarchar](max) NULL,
	[TongTien] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaMon] [nvarchar](450) NULL,
 CONSTRAINT [PK_chitietnhap] PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cthd]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cthd](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [nvarchar](max) NULL,
	[MaMon] [nvarchar](max) NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [int] NOT NULL,
	[TenMon] [nvarchar](20) NULL,
	[MaHoaDonNavigationMaHD] [nvarchar](450) NULL,
	[MaMonNavigationMaMon] [nvarchar](450) NULL,
 CONSTRAINT [PK_cthd] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[MaHD] [nvarchar](450) NOT NULL,
	[NgayLapHD] [nvarchar](max) NULL,
	[ThoiGian] [nvarchar](max) NULL,
	[SoLuong] [nvarchar](max) NULL,
	[MaNV] [nvarchar](450) NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[menu]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[MaMon] [nvarchar](450) NOT NULL,
	[TenMon] [nvarchar](20) NULL,
	[DonGia] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[MaNV] [nvarchar](450) NOT NULL,
	[TenNV] [nvarchar](20) NULL,
	[HoNV] [nvarchar](20) NULL,
	[SDT] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](20) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phanca]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phanca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](450) NULL,
	[HeSoLuong] [int] NOT NULL,
	[SoGio] [int] NOT NULL,
 CONSTRAINT [PK_phanca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 17/12/2020 3:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](450) NULL,
	[PassWord] [nvarchar](max) NULL,
 CONSTRAINT [PK_taikhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[bangluong] ([MaNV], [TienThuong], [TamUng], [Luong]) VALUES (N'MaNV001', 1000000, 0, 8500000)
INSERT [dbo].[bangluong] ([MaNV], [TienThuong], [TamUng], [Luong]) VALUES (N'MaNV002', 0, 0, 7500000)
INSERT [dbo].[bangluong] ([MaNV], [TienThuong], [TamUng], [Luong]) VALUES (N'MaNV003', 100000, 500000, 2600000)
INSERT [dbo].[chitietnhap] ([MaNhap], [DVT], [Ngay], [TongTien], [SoLuong], [MaMon]) VALUES (N'MN001', N'Ly', N'10/10/2020', 2000000, 100, N'MaMon001')
INSERT [dbo].[chitietnhap] ([MaNhap], [DVT], [Ngay], [TongTien], [SoLuong], [MaMon]) VALUES (N'MN002', N'Ly', N'10/10/2020', 2500000, 100, N'MaMon002')
INSERT [dbo].[chitietnhap] ([MaNhap], [DVT], [Ngay], [TongTien], [SoLuong], [MaMon]) VALUES (N'MN003', N'Ly', N'10/10/2020', 2500000, 100, N'MaMon003')
INSERT [dbo].[chitietnhap] ([MaNhap], [DVT], [Ngay], [TongTien], [SoLuong], [MaMon]) VALUES (N'MN004', N'Ly', N'13/12/2020', 2500000, 100, N'MaMon004')
INSERT [dbo].[chitietnhap] ([MaNhap], [DVT], [Ngay], [TongTien], [SoLuong], [MaMon]) VALUES (N'MN005', N'Ly', N'14/12/2020', 2500000, 100, N'MaMon005')
SET IDENTITY_INSERT [dbo].[cthd] ON 

INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (2, N'MaHD102', N'MaMon004', 1, 25000, N'Ca Cao Đá', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (3, N'MaHD102', N'MaMon002', 2, 50000, N'Bạc Xỉu', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (4, N'MaHD102', N'MaMon003', 2, 50000, N'Coffee Sữa Đá', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (6, N'MaHD101', N'MaMon001', 1, 20000, N'Coffee Ðá', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (15, N'MaHD103', N'MaMon001', 1, 20000, N'Coffee Ðá', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (17, N'MaHD103', N'MaMon001', 1, 20000, N'Coffee Sữa Ðá', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (18, N'MaHD104', N'MaMon001', 1, 20000, N'Coffee Ðá', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (28, N'MaHD103', N'MaMon005', 3, 75000, N'Ca Cao Nóng', NULL, NULL)
INSERT [dbo].[cthd] ([ID], [MaHD], [MaMon], [SoLuong], [Gia], [TenMon], [MaHoaDonNavigationMaHD], [MaMonNavigationMaMon]) VALUES (29, N'MaHD105', N'MaMon001', 3, 60000, N'Coffee Ðá', NULL, NULL)
SET IDENTITY_INSERT [dbo].[cthd] OFF
INSERT [dbo].[hoadon] ([MaHD], [NgayLapHD], [ThoiGian], [SoLuong], [MaNV]) VALUES (N'MaHD101', N'12/12/2020', N'19:05', N'1', N'MaNV001')
INSERT [dbo].[hoadon] ([MaHD], [NgayLapHD], [ThoiGian], [SoLuong], [MaNV]) VALUES (N'MaHD102', N'13/12/2020', N'19:05', N'5', N'MaNV002')
INSERT [dbo].[hoadon] ([MaHD], [NgayLapHD], [ThoiGian], [SoLuong], [MaNV]) VALUES (N'MaHD103', N'13/12/2020', N'17:02:51', N'1', N'MaNV001')
INSERT [dbo].[hoadon] ([MaHD], [NgayLapHD], [ThoiGian], [SoLuong], [MaNV]) VALUES (N'MaHD104', N'14/12/2020', N'12:17:50', N'3', N'MaNV001')
INSERT [dbo].[hoadon] ([MaHD], [NgayLapHD], [ThoiGian], [SoLuong], [MaNV]) VALUES (N'MaHD105', N'17/12/2020', N'2:19:27', N'3', N'MaNV003')
INSERT [dbo].[menu] ([MaMon], [TenMon], [DonGia], [SoLuongTon]) VALUES (N'MaMon001', N'Coffee Ðá', 20000, 93)
INSERT [dbo].[menu] ([MaMon], [TenMon], [DonGia], [SoLuongTon]) VALUES (N'MaMon002', N'Bạc Xỉu', 25000, 98)
INSERT [dbo].[menu] ([MaMon], [TenMon], [DonGia], [SoLuongTon]) VALUES (N'MaMon003', N'Coffee Sữa Đá', 25000, 98)
INSERT [dbo].[menu] ([MaMon], [TenMon], [DonGia], [SoLuongTon]) VALUES (N'MaMon004', N'Ca Cao Đá', 25000, 99)
INSERT [dbo].[menu] ([MaMon], [TenMon], [DonGia], [SoLuongTon]) VALUES (N'MaMon005', N'Ca Cao Nóng', 20000, 97)
INSERT [dbo].[nhanvien] ([MaNV], [TenNV], [HoNV], [SDT], [GioiTinh]) VALUES (N'MaNV001', N'Chinh', N'Nguyễn', N'0346429223', N'Nam')
INSERT [dbo].[nhanvien] ([MaNV], [TenNV], [HoNV], [SDT], [GioiTinh]) VALUES (N'MaNV002', N'Phát', N'Nguyễn Duy', N'0422123213', N'Nam')
INSERT [dbo].[nhanvien] ([MaNV], [TenNV], [HoNV], [SDT], [GioiTinh]) VALUES (N'MaNV003', N'Hòa', N'Bùi Ngọc', N'0346429393', N'Nữ')
SET IDENTITY_INSERT [dbo].[phanca] ON 

INSERT [dbo].[phanca] ([Id], [MaNV], [HeSoLuong], [SoGio]) VALUES (1, N'MaNV001', 2, 250)
INSERT [dbo].[phanca] ([Id], [MaNV], [HeSoLuong], [SoGio]) VALUES (13, N'MaNV002', 2, 250)
INSERT [dbo].[phanca] ([Id], [MaNV], [HeSoLuong], [SoGio]) VALUES (15, N'MaNV003', 2, 100)
SET IDENTITY_INSERT [dbo].[phanca] OFF
SET IDENTITY_INSERT [dbo].[taikhoan] ON 

INSERT [dbo].[taikhoan] ([Id], [UserName], [PassWord]) VALUES (4, N'MaNV001', N'123456')
INSERT [dbo].[taikhoan] ([Id], [UserName], [PassWord]) VALUES (7, N'MaNV002', N'123456')
INSERT [dbo].[taikhoan] ([Id], [UserName], [PassWord]) VALUES (8, N'MaNV003', N'123456')
SET IDENTITY_INSERT [dbo].[taikhoan] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_chitietnhap_MaMon]    Script Date: 17/12/2020 3:05:21 ******/
CREATE NONCLUSTERED INDEX [IX_chitietnhap_MaMon] ON [dbo].[chitietnhap]
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_cthd_MaHoaDonNavigationMaHD]    Script Date: 17/12/2020 3:05:21 ******/
CREATE NONCLUSTERED INDEX [IX_cthd_MaHoaDonNavigationMaHD] ON [dbo].[cthd]
(
	[MaHoaDonNavigationMaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_cthd_MaMonNavigationMaMon]    Script Date: 17/12/2020 3:05:21 ******/
CREATE NONCLUSTERED INDEX [IX_cthd_MaMonNavigationMaMon] ON [dbo].[cthd]
(
	[MaMonNavigationMaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_hoadon_MaNV]    Script Date: 17/12/2020 3:05:21 ******/
CREATE NONCLUSTERED INDEX [IX_hoadon_MaNV] ON [dbo].[hoadon]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_phanca_MaNV]    Script Date: 17/12/2020 3:05:21 ******/
CREATE NONCLUSTERED INDEX [IX_phanca_MaNV] ON [dbo].[phanca]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_taikhoan_UserName]    Script Date: 17/12/2020 3:05:21 ******/
CREATE NONCLUSTERED INDEX [IX_taikhoan_UserName] ON [dbo].[taikhoan]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[chitietnhap]  WITH CHECK ADD  CONSTRAINT [Menu_ChiTietNhap] FOREIGN KEY([MaMon])
REFERENCES [dbo].[menu] ([MaMon])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[chitietnhap] CHECK CONSTRAINT [Menu_ChiTietNhap]
GO
ALTER TABLE [dbo].[cthd]  WITH CHECK ADD  CONSTRAINT [FK_cthd_hoadon_MaHoaDonNavigationMaHD] FOREIGN KEY([MaHoaDonNavigationMaHD])
REFERENCES [dbo].[hoadon] ([MaHD])
GO
ALTER TABLE [dbo].[cthd] CHECK CONSTRAINT [FK_cthd_hoadon_MaHoaDonNavigationMaHD]
GO
ALTER TABLE [dbo].[cthd]  WITH CHECK ADD  CONSTRAINT [FK_cthd_menu_MaMonNavigationMaMon] FOREIGN KEY([MaMonNavigationMaMon])
REFERENCES [dbo].[menu] ([MaMon])
GO
ALTER TABLE [dbo].[cthd] CHECK CONSTRAINT [FK_cthd_menu_MaMonNavigationMaMon]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [NhanVien_HoaDon] FOREIGN KEY([MaNV])
REFERENCES [dbo].[nhanvien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [NhanVien_HoaDon]
GO
ALTER TABLE [dbo].[phanca]  WITH CHECK ADD  CONSTRAINT [BangLuong_PhanCa] FOREIGN KEY([MaNV])
REFERENCES [dbo].[bangluong] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[phanca] CHECK CONSTRAINT [BangLuong_PhanCa]
GO
ALTER TABLE [dbo].[phanca]  WITH CHECK ADD  CONSTRAINT [NhanVien_PhanCa] FOREIGN KEY([MaNV])
REFERENCES [dbo].[nhanvien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[phanca] CHECK CONSTRAINT [NhanVien_PhanCa]
GO
ALTER TABLE [dbo].[taikhoan]  WITH CHECK ADD  CONSTRAINT [NhanVien_TaiKhoan] FOREIGN KEY([UserName])
REFERENCES [dbo].[nhanvien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[taikhoan] CHECK CONSTRAINT [NhanVien_TaiKhoan]
GO
USE [master]
GO
ALTER DATABASE [CoffeeManage] SET  READ_WRITE 
GO
