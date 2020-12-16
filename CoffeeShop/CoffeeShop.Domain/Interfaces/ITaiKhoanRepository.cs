using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    public interface ITaiKhoanRepository
    {

        IEnumerable<TaiKhoan> getAll(int pageIndex, int pageSize, out int count);
        public void ThemTaiKhoan(TaiKhoan taikhoan);
        public void SuaTaiKhoan(TaiKhoan taikhoan);
        public void XoaTaiKhoan(int id);

        public TaiKhoan GetTaiKhoan(int id);

    }
}
