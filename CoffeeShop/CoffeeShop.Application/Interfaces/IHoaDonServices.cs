using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Interfaces
{
    public interface IHoaDonServices
    {
        public void themHoaDon(HoaDonDTO hoadon);

        public void suaHoaDon(HoaDonDTO hoadon);

        public void xoaHoaDon(string maHD);

        public HoaDonDTO GetHoaDon(string maHD);

        IEnumerable<HoaDonDTO> getAll(int pageIndex, int pageSize, out int count);

    }
}
