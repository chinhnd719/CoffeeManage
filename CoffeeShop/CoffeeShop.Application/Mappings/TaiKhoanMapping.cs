using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Mappings
{
    public static class TaiKhoanMapping
    {
        public static TaiKhoanDTO MappingTaiKhoanDTO(this TaiKhoan taikhoan)
        {
            return new TaiKhoanDTO
            {
                Id = taikhoan.Id,
                UserName = taikhoan.UserName,
                PassWord = taikhoan.PassWord


            };
        }

        public static TaiKhoan MappingTaiKhoan(this TaiKhoanDTO taikhoanDTO)
        {
            return new TaiKhoan
            {
                Id = taikhoanDTO.Id,
                UserName = taikhoanDTO.UserName,
                PassWord = taikhoanDTO.PassWord

            };
        }

        public static IEnumerable<TaiKhoanDTO> MappingTaiKhoanDTOList(this IEnumerable<TaiKhoan> taikhoanS)
        {
            foreach (var taikhoan in taikhoanS)
            {
                yield return taikhoan.MappingTaiKhoanDTO();
            }
        }
        public static IEnumerable<TaiKhoanDTO> MappingTaiKhoanDTO1(this IEnumerable<TaiKhoan> taikhoanS)
        {
            List<TaiKhoanDTO> listreturn = new List<TaiKhoanDTO>();
            foreach (var taikhoan in taikhoanS)
            {
                var obnow = taikhoan.MappingTaiKhoanDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
