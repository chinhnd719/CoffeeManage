using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class MenuRepository : IMenuRepository 
    {
        private readonly CoffeeShopDbContext _conText;
        public MenuRepository(CoffeeShopDbContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<Menu> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.menu.Count();

            var query = _conText.menu.AsQueryable();
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public Menu GetMenu(string maMon)
        {

            return _conText.menu.Find(maMon);
        }

        public void SuaMenu(Menu menu)
        {
            _conText.menu.Update(menu);
            _conText.SaveChanges();
        }

        public void ThemMenu(Menu menu)
        {
            _conText.menu.Add(menu);
            _conText.SaveChanges();
        }

        public void XoaMenu(string maMon)
        {

            var menuDaTimThay = _conText.menu.Find(maMon);
            if (menuDaTimThay != null)
            {
                _conText.menu.Remove(menuDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
