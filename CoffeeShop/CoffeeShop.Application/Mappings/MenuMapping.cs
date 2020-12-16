using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Mappings
{
    public static class MenuMapping
    {
        public static MenuDTO MappingMenuDTO(this Menu menu) 
        {
            return new MenuDTO
            {
                MaMon=menu.MaMon,
                TenMon=menu.TenMon,
                DonGia=menu.DonGia,
                SoLuongTon=menu.SoLuongTon
             };
        }

        public static Menu MappingMenu(this MenuDTO menuDTO)
        {
            return new Menu
            {
                MaMon = menuDTO.MaMon,
                TenMon = menuDTO.TenMon,
                DonGia = menuDTO.DonGia,
                SoLuongTon = menuDTO.SoLuongTon
            };
        }

        public static IEnumerable<MenuDTO> MappingMenuDTOList(this IEnumerable<Menu> menuS)
        {
            foreach (var menu in menuS)
            {
                yield return menu.MappingMenuDTO();
            }
        }
        public static IEnumerable<MenuDTO> MappingMenuDTO1(this IEnumerable<Menu> menuS)
        {
            List<MenuDTO> listreturn = new List<MenuDTO>();
            foreach (var menu in menuS)
            {
                var obnow = menu.MappingMenuDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
