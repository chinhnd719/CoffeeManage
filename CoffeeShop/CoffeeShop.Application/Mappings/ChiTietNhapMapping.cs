using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Mappings
{
    public static class ChiTietNhapMapping
    {
        public static ChiTietNhapDTO MappingChiTietNhapDTO(this ChiTietNhap chitietnhap)
        {
            return new ChiTietNhapDTO
            {
                MaNhap=chitietnhap.MaNhap,
                MaMon=chitietnhap.MaMon,
                DVT=chitietnhap.DVT,
                Ngay=chitietnhap.Ngay,
                TongTien=chitietnhap.TongTien,
                SoLuong=chitietnhap.SoLuong

            };
        }

        public static ChiTietNhap MappingChiTietNhap(this ChiTietNhapDTO chitietnhapDTO)
        {
            return new ChiTietNhap
            {
                MaNhap = chitietnhapDTO.MaNhap,
                MaMon = chitietnhapDTO.MaMon,
                DVT = chitietnhapDTO.DVT,
                Ngay = chitietnhapDTO.Ngay,
                TongTien = chitietnhapDTO.TongTien,
                SoLuong = chitietnhapDTO.SoLuong
            };
        }

        public static IEnumerable<ChiTietNhapDTO> MappingChiTietNhapDTOList(this IEnumerable<ChiTietNhap> chitietnhapS)
        {
            foreach (var chitietnhap in chitietnhapS)
            {
                yield return chitietnhap.MappingChiTietNhapDTO();
            }
        }
        public static IEnumerable<ChiTietNhapDTO> MappingChiTietNhapDTO1(this IEnumerable<ChiTietNhap> chitietnhapS)
        {
            List<ChiTietNhapDTO> listreturn = new List<ChiTietNhapDTO>();
            foreach (var chitietnhap in chitietnhapS)
            {
                var obnow = chitietnhap.MappingChiTietNhapDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
