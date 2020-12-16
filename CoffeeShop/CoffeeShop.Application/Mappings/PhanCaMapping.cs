using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Mapping
{
    public static class PhanCaMapping
    {
        public static PhanCaDTO MappingPhanCaDTO(this PhanCa phanca)
        {
            return new PhanCaDTO
            {
                Id = phanca.Id,
                MaNV = phanca.MaNV,
                HeSoLuong = phanca.HeSoLuong,
                SoGio = phanca.SoGio,


            };
        }

        public static PhanCa MappingPhanCa(this PhanCaDTO phancaDTO)
        {
            return new PhanCa
            {
                Id = phancaDTO.Id,
                MaNV = phancaDTO.MaNV,
                HeSoLuong = phancaDTO.HeSoLuong,
                SoGio = phancaDTO.SoGio,
            };
        }

        public static IEnumerable<PhanCaDTO> MappingPhanCaDTOList(this IEnumerable<PhanCa> phancaS)
        {
            foreach (var phanca in phancaS)
            {
                yield return phanca.MappingPhanCaDTO();
            }
        }
        public static IEnumerable<PhanCaDTO> MappingPhanCaDTO1(this IEnumerable<PhanCa> phancaS)
        {
            List<PhanCaDTO> listreturn = new List<PhanCaDTO>();
            foreach (var phanca in phancaS)
            {
                var obnow = phanca.MappingPhanCaDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
