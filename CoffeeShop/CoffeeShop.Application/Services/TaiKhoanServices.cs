using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class TaiKhoanServices : ITaiKhoanServices
    {
        private readonly ITaiKhoanRepository _taikhoanRepository;
        public TaiKhoanServices(ITaiKhoanRepository taikhoanRepository)
        {
            _taikhoanRepository = taikhoanRepository;
        }

        public IEnumerable<TaiKhoanDTO> getAll(int pageIndex, int pageSize, out int count)
        {
            return _taikhoanRepository.getAll(pageIndex, pageSize, out count).MappingTaiKhoanDTO1();
        }

        public TaiKhoanDTO GetTaiKhoan(int id)
        {
            return _taikhoanRepository.GetTaiKhoan(id).MappingTaiKhoanDTO();

        }

        public void suaTaiKhoan(TaiKhoanDTO taikhoanDTO)
        {
            _taikhoanRepository.SuaTaiKhoan(taikhoanDTO.MappingTaiKhoan());
        }

        public void themTaiKhoan(TaiKhoanDTO taikhoanDTO)
        {
            _taikhoanRepository.ThemTaiKhoan(taikhoanDTO.MappingTaiKhoan());
        }


        public void xoaTaiKhoan(int id)
        {
            _taikhoanRepository.XoaTaiKhoan(id);
        }
    }
}
