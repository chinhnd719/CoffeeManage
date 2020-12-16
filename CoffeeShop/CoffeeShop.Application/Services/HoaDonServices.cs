using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        private readonly IHoaDonRepository _hoadonRepository;
        public HoaDonServices(IHoaDonRepository hoadonRepository)
        {
            _hoadonRepository = hoadonRepository;
        }

        public IEnumerable<HoaDonDTO> getAll(int pageIndex, int pageSize, out int count)
        {
            return _hoadonRepository.getAll(pageIndex, pageSize, out count).MappingHoaDonDTO1();
        }

        public HoaDonDTO GetHoaDon(string maHD)
        {
            return _hoadonRepository.GetHoaDon(maHD).MappingHoaDonDTO();

        }

        public void suaHoaDon(HoaDonDTO hoadonDTO)
        {
            _hoadonRepository.SuaHoaDon(hoadonDTO.MappingHoaDon());
        }

        public void themHoaDon(HoaDonDTO hoadonDTO)
        {
            _hoadonRepository.ThemHoaDon(hoadonDTO.MappingHoaDon());
        }


        public void xoaHoaDon(string maHD)
        {
            _hoadonRepository.XoaHoaDon(maHD);
        }
    }
}
