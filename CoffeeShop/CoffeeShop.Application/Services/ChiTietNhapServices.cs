using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class ChiTietNhapServices : IChiTietNhapServices
    {
        private readonly IChiTietNhapRepository _chitietnhapRepository;
        public ChiTietNhapServices(IChiTietNhapRepository chitietnhapRepository)
        {
            _chitietnhapRepository = chitietnhapRepository;
        }

        public IEnumerable<ChiTietNhapDTO> getAll(int pageIndex, int pageSize, out int count)
        {
            return _chitietnhapRepository.getAll(pageIndex, pageSize, out count).MappingChiTietNhapDTO1();
        }

        public ChiTietNhapDTO GetChiTietNhap(string maNhap)
        {
            return _chitietnhapRepository.GetChiTietNhap(maNhap).MappingChiTietNhapDTO();

        }

        public void suaChiTietNhap(ChiTietNhapDTO chitietnhapDTO)
        {
            _chitietnhapRepository.SuaChiTietNhap(chitietnhapDTO.MappingChiTietNhap());
        }

        public void themChiTietNhap(ChiTietNhapDTO chitietnhapDTO)
        {
            _chitietnhapRepository.ThemChiTietNhap(chitietnhapDTO.MappingChiTietNhap());
        }


        public void xoaChiTietNhap(string maNhap)
        {
            _chitietnhapRepository.XoaChiTietNhap(maNhap);
        }
    }
}
