using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        private readonly CoffeeShopDbContext _conText;
        public TaiKhoanRepository(CoffeeShopDbContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<TaiKhoan> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.taikhoan.Count();

            var query = _conText.taikhoan.AsQueryable();
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public TaiKhoan GetTaiKhoan(int id)
        {

            return _conText.taikhoan.Find(id);
        }

        public void SuaTaiKhoan(TaiKhoan taikhoan)
        {
            _conText.taikhoan.Update(taikhoan);
            _conText.SaveChanges();
        }

        public void ThemTaiKhoan(TaiKhoan taikhoan)
        {
            _conText.taikhoan.Add(taikhoan);
            _conText.SaveChanges();
        }

        public void XoaTaiKhoan(int id)
        {

            var TaiKhoanDaTimThay = _conText.taikhoan.Find(id);
            if (TaiKhoanDaTimThay != null)
            {
                _conText.taikhoan.Remove(TaiKhoanDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
