using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class ChiTietNhapRepository : IChiTietNhapRepository 
    {
        private readonly CoffeeShopDbContext _conText;
        public ChiTietNhapRepository(CoffeeShopDbContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<ChiTietNhap> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.chitietnhap.Count();

            var query = _conText.chitietnhap.AsQueryable();
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public ChiTietNhap GetChiTietNhap(string maNhap)
        {

            return _conText.chitietnhap.Find(maNhap);
        }

        public void SuaChiTietNhap(ChiTietNhap chitietnhap)
        {
            _conText.chitietnhap.Update(chitietnhap);
            _conText.SaveChanges();
        }

        public void ThemChiTietNhap(ChiTietNhap chitietnhap)
        {
            _conText.chitietnhap.Add(chitietnhap);
            _conText.SaveChanges();
        }

        public void XoaChiTietNhap(string maNhap)
        {

            var chitietnhapDaTimThay = _conText.chitietnhap.Find(maNhap);
            if (chitietnhapDaTimThay != null)
            {
                _conText.chitietnhap.Remove(chitietnhapDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
