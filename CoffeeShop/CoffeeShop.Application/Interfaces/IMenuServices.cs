using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Interfaces
{
    public interface IMenuServices
    {
        public void themMenu(MenuDTO menu);

        public void suaMenu(MenuDTO menu);

        public void xoaMenu(string maMon);

        public MenuDTO GetMenu(string maMon);

        IEnumerable<MenuDTO> getAll(int pageIndex, int pageSize, out int count);

    }
}
