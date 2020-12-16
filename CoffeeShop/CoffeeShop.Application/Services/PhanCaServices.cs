using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mapping;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class PhanCaServices : IPhanCaServices
    {
        private readonly IPhanCaRepository _phancaRepository;
        public PhanCaServices(IPhanCaRepository phancaRepository)
        {
            _phancaRepository = phancaRepository;
        }

        public IEnumerable<PhanCaDTO> getAll(int pageIndex, int pageSize, out int count)
        {
            return _phancaRepository.getAll(pageIndex, pageSize, out count).MappingPhanCaDTO1();
        }

        public PhanCaDTO GetPhanCa(int id)
        {
            return _phancaRepository.GetPhanCa(id).MappingPhanCaDTO();

        }

        public void suaPhanCa(PhanCaDTO phancaDTO)
        {
            _phancaRepository.SuaPhanCa(phancaDTO.MappingPhanCa());
        }

        public void themPhanCa(PhanCaDTO phancaDTO)
        {
            _phancaRepository.ThemPhanCa(phancaDTO.MappingPhanCa());
        }


        public void xoaPhanCa(int id)
        {
            _phancaRepository.XoaPhanCa(id);
        }
    }
}
