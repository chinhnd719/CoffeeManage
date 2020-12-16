using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Mappings
{
    public static class CTHDMapping
    {
        public static CTHDDTO MappingCTHDDTO(this CTHD cthd) 
        {
            return new CTHDDTO
            {
                ID=cthd.ID,
                MaHD=cthd.MaHD,
                MaMon=cthd.MaMon,
                SoLuong=cthd.SoLuong,
                Gia=cthd.Gia,
                TenMon=cthd.TenMon

            };
        }

        public static CTHD MappingCTHD(this CTHDDTO cthdDTO)
        {
            return new CTHD
            {
                ID = cthdDTO.ID,
                MaHD = cthdDTO.MaHD,
                MaMon = cthdDTO.MaMon,
                SoLuong = cthdDTO.SoLuong,
                Gia = cthdDTO.Gia,
                TenMon = cthdDTO.TenMon
            };
        }

        public static IEnumerable<CTHDDTO> MappingCTHDDTOList(this IEnumerable<CTHD> cthdS)
        {
            foreach (var cthd in cthdS)
            {
                yield return cthd.MappingCTHDDTO();
            }
        }
        public static IEnumerable<CTHDDTO> MappingCTHDDTO1(this IEnumerable<CTHD> cthdS)
        {
            List<CTHDDTO> listreturn = new List<CTHDDTO>();
            foreach (var cthd in cthdS)
            {
                var obnow = cthd.MappingCTHDDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
