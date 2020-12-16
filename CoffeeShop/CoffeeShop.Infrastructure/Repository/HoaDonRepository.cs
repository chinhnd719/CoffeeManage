using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class HoaDonRepository : IHoaDonRepository 
    {
        private readonly CoffeeShopDbContext _conText;
        public HoaDonRepository(CoffeeShopDbContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<HoaDon> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.hoadon.Count();

            var query = _conText.hoadon.AsQueryable();
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public HoaDon GetHoaDon(string maHD)
        {

            return _conText.hoadon.Find(maHD);
        }

        public void SuaHoaDon(HoaDon hoadon)
        {
            _conText.hoadon.Update(hoadon);
            _conText.SaveChanges();
        }

        public void ThemHoaDon(HoaDon hoadon)
        {
            _conText.hoadon.Add(hoadon);
            _conText.SaveChanges();
        }

        public void XoaHoaDon(string maHD)
        {

            var hoadonDaTimThay = _conText.hoadon.Find(maHD);
            if (hoadonDaTimThay != null)
            {
                _conText.hoadon.Remove(hoadonDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
