using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class BangLuongRepository : IBangLuongRepository 
    {
        private readonly CoffeeShopDbContext _conText;
        public BangLuongRepository(CoffeeShopDbContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<BangLuong> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.bangluong.Count();

            var query = _conText.bangluong.AsQueryable();
                return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public BangLuong GetBangLuong(string maNV)
        {

            return _conText.bangluong.Find(maNV);
        }

        public void SuaBangLuong(BangLuong bangluong)
        {
            _conText.bangluong.Update(bangluong);
            _conText.SaveChanges();
        }

        public void ThemBangLuong(BangLuong bangluong)
        {
            _conText.bangluong.Add(bangluong);
            _conText.SaveChanges();
        }

        public void XoaBangLuong(string maNV)
        {

            var bangluongDaTimThay = _conText.bangluong.Find(maNV);
            if (bangluongDaTimThay != null)
            {
                _conText.bangluong.Remove(bangluongDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
