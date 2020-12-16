using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    public interface IHoaDonRepository
    {

        IEnumerable<HoaDon> getAll(int pageIndex, int pageSize, out int count);
        public void ThemHoaDon(HoaDon hoadon);
        public void SuaHoaDon(HoaDon hoadon);
        public void XoaHoaDon(string maHD);

        public HoaDon GetHoaDon(string maHD);

    }
}
