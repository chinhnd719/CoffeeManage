using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Interfaces
{
    public interface IBangLuongServices
    {
        public void themBangLuong(BangLuongDTO bangluong);

        public void suaBangLuong(BangLuongDTO bangluong);

        public void xoaBangLuong(string maNV);

        public BangLuongDTO GetBangLuong(string maNV);

        IEnumerable<BangLuongDTO> getAll(int pageIndex, int pageSize, out int count);

    }
}
