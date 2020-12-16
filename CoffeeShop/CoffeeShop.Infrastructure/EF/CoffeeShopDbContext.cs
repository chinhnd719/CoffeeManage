using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoffeeShop.Infrastructure.EF
{
    public class CoffeeShopDbContext : DbContext
    {
        public CoffeeShopDbContext()
        {
        }
        public CoffeeShopDbContext(DbContextOptions options) : base(options)
        {
        }
       
        public DbSet<Menu> menu { set; get; }
        public DbSet<BangLuong> bangluong{ set; get; }
        public DbSet<ChiTietNhap>chitietnhap{ set; get; }  
        public DbSet<CTHD> cthd{ set; get; }
        public DbSet<HoaDon> hoadon{ set; get; }
        public DbSet<NhanVien> nhanvien{ set; get; }
        public DbSet<PhanCa> phanca{ set; get; }
        public DbSet<TaiKhoan> taikhoan{ set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=CoffeeManage;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ChiTietNhap>(entity =>
            {
                entity.HasOne(d => d.MaMonNavigation)
                    .WithMany(p => p.ChiTietNhap)
                    .HasForeignKey(d => d.MaMon)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Menu_ChiTietNhap");
            });
            modelBuilder.Entity<CTHD>(entity =>
            {
           
                entity.Property(e => e.TenMon).HasMaxLength(20);
            });
            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasOne(d => d.MaNVNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.MaNV)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("NhanVien_HoaDon");
            });
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.TenMon).HasMaxLength(20);
            });
            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.TenNV).HasMaxLength(20);
                entity.Property(e => e.HoNV).HasMaxLength(20);
                entity.Property(e => e.GioiTinh).HasMaxLength(20);
            });
            modelBuilder.Entity<PhanCa>(entity =>
            {
                entity.HasOne(d => d.MaNVNavigationBL)
                    .WithMany(p => p.PhanCa)
                    .HasForeignKey(d => d.MaNV)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("BangLuong_PhanCa");
                entity.HasOne(d => d.MaNVNavigationNV)
                    .WithMany(p => p.PhanCa)
                    .HasForeignKey(d => d.MaNV)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("NhanVien_PhanCa");
            });
            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("NhanVien_TaiKhoan");
            });
            base.OnModelCreating(modelBuilder);
        }
       
    }
}
