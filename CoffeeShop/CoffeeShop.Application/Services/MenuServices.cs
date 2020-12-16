using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class MenuServices : IMenuServices
    {
        private readonly IMenuRepository _menuRepository;
        public MenuServices(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public IEnumerable<MenuDTO> getAll(int pageIndex, int pageSize, out int count)
        {
            return _menuRepository.getAll(pageIndex, pageSize, out count).MappingMenuDTO1();
        }

        public MenuDTO GetMenu(string maMon)
        {
            return _menuRepository.GetMenu(maMon).MappingMenuDTO();

        }

        public void suaMenu(MenuDTO menuDTO)
        {
            _menuRepository.SuaMenu(menuDTO.MappingMenu());
        }

        public void themMenu(MenuDTO menuDTO)
        {
            _menuRepository.ThemMenu(menuDTO.MappingMenu());
        }


        public void xoaMenu(string maMon)
        {
            _menuRepository.XoaMenu(maMon);
        }
    }
}
