﻿// <auto-generated />
using CoffeeShop.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeShop.Infrastructure.Migrations
{
    [DbContext(typeof(CoffeeShopDbContext))]
    partial class CoffeeShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeShop.Domain.Entities.BangLuong", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Luong")
                        .HasColumnType("int");

                    b.Property<int>("TamUng")
                        .HasColumnType("int");

                    b.Property<int>("TienThuong")
                        .HasColumnType("int");

                    b.HasKey("MaNV");

                    b.ToTable("bangluong");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.CTHD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaHoaDonNavigationMaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaMon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaMonNavigationMaMon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenMon")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.HasIndex("MaHoaDonNavigationMaHD");

                    b.HasIndex("MaMonNavigationMaMon");

                    b.ToTable("cthd");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.ChiTietNhap", b =>
                {
                    b.Property<string>("MaNhap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DVT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaMon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ngay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.HasKey("MaNhap");

                    b.HasIndex("MaMon");

                    b.ToTable("chitietnhap");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.HoaDon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NgayLapHD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoLuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThoiGian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHD");

                    b.HasIndex("MaNV");

                    b.ToTable("hoadon");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.Menu", b =>
                {
                    b.Property<string>("MaMon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenMon")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("MaMon");

                    b.ToTable("menu");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("HoNV")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNV")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("MaNV");

                    b.ToTable("nhanvien");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.PhanCa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeSoLuong")
                        .HasColumnType("int");

                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoGio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaNV");

                    b.ToTable("phanca");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName");

                    b.ToTable("taikhoan");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.CTHD", b =>
                {
                    b.HasOne("CoffeeShop.Domain.Entities.HoaDon", "MaHoaDonNavigation")
                        .WithMany("CTHD")
                        .HasForeignKey("MaHoaDonNavigationMaHD");

                    b.HasOne("CoffeeShop.Domain.Entities.Menu", "MaMonNavigation")
                        .WithMany("CTHD")
                        .HasForeignKey("MaMonNavigationMaMon");
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.ChiTietNhap", b =>
                {
                    b.HasOne("CoffeeShop.Domain.Entities.Menu", "MaMonNavigation")
                        .WithMany("ChiTietNhap")
                        .HasForeignKey("MaMon")
                        .HasConstraintName("Menu_ChiTietNhap")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.HoaDon", b =>
                {
                    b.HasOne("CoffeeShop.Domain.Entities.NhanVien", "MaNVNavigation")
                        .WithMany("HoaDon")
                        .HasForeignKey("MaNV")
                        .HasConstraintName("NhanVien_HoaDon")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.PhanCa", b =>
                {
                    b.HasOne("CoffeeShop.Domain.Entities.BangLuong", "MaNVNavigationBL")
                        .WithMany("PhanCa")
                        .HasForeignKey("MaNV")
                        .HasConstraintName("BangLuong_PhanCa")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoffeeShop.Domain.Entities.NhanVien", "MaNVNavigationNV")
                        .WithMany("PhanCa")
                        .HasForeignKey("MaNV")
                        .HasConstraintName("NhanVien_PhanCa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoffeeShop.Domain.Entities.TaiKhoan", b =>
                {
                    b.HasOne("CoffeeShop.Domain.Entities.NhanVien", "UsernameNavigation")
                        .WithMany("TaiKhoan")
                        .HasForeignKey("UserName")
                        .HasConstraintName("NhanVien_TaiKhoan")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}