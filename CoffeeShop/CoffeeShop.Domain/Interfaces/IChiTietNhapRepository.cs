using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    public interface IChiTietNhapRepository
    {

        IEnumerable<ChiTietNhap> getAll(int pageIndex, int pageSize, out int count);
        public void ThemChiTietNhap(ChiTietNhap chitietnhap);
        public void SuaChiTietNhap(ChiTietNhap chitietnhap);
        public void XoaChiTietNhap(string maNhap);

        public ChiTietNhap GetChiTietNhap(string maNhap);

    }
}
