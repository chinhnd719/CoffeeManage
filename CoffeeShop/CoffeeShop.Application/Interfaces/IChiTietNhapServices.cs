using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Interfaces
{
    public interface IChiTietNhapServices
    {
        public void themChiTietNhap(ChiTietNhapDTO chitietnhap);

        public void suaChiTietNhap(ChiTietNhapDTO chitietnhap);

        public void xoaChiTietNhap(string maNhap);

        public ChiTietNhapDTO GetChiTietNhap(string maNhap);

        IEnumerable<ChiTietNhapDTO> getAll(int pageIndex, int pageSize, out int count);

    }
}
