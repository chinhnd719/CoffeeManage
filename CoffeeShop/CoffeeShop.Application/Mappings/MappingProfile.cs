using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;

namespace CoffeeShop.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<BangLuong, BangLuongDTO>();
            CreateMap<BangLuongDTO, BangLuong>();

            CreateMap<ChiTietNhap, ChiTietNhapDTO>();
            CreateMap<ChiTietNhapDTO, ChiTietNhap>();

            CreateMap<CTHD, CTHDDTO>();
            CreateMap<CTHDDTO, CTHD>();

            CreateMap<HoaDon, HoaDonDTO>();
            CreateMap<HoaDonDTO, HoaDon>();

            CreateMap<Menu, MenuDTO>();
            CreateMap<MenuDTO, Menu>();

            CreateMap<NhanVien, NhanVienDTO>();
            CreateMap<NhanVienDTO, NhanVien>();

            CreateMap<PhanCa, PhanCaDTO>();
            CreateMap<PhanCaDTO, PhanCa>();

            CreateMap<TaiKhoan, TaiKhoanDTO>();
            CreateMap<TaiKhoanDTO,TaiKhoan>();
        }
    }
}
