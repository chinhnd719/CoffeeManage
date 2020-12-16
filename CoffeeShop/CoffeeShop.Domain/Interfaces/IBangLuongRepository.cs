using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    public interface IBangLuongRepository
    {

        IEnumerable<BangLuong> getAll(int pageIndex, int pageSize, out int count);
        public void ThemBangLuong(BangLuong bangluong);
        public void SuaBangLuong(BangLuong bangluong);
        public void XoaBangLuong(string maNV);

        public BangLuong GetBangLuong(string maNV);

    }
}
