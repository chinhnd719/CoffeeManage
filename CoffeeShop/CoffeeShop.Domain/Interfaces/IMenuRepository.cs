using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    public interface IMenuRepository
    {

        IEnumerable<Menu> getAll(int pageIndex, int pageSize, out int count);
        public void ThemMenu(Menu menu);
        public void SuaMenu(Menu menu);
        public void XoaMenu(string maMon);

        public Menu GetMenu(string maMon);

    }
}
