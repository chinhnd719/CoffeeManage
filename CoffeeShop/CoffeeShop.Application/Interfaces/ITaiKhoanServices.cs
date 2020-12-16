using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Interfaces
{
    
        public interface ITaiKhoanServices
        {
            public void themTaiKhoan(TaiKhoanDTO taikhoan);

            public void suaTaiKhoan(TaiKhoanDTO taikhoan);

            public void xoaTaiKhoan(int id);

            public TaiKhoanDTO GetTaiKhoan(int id);

            IEnumerable<TaiKhoanDTO> getAll(int pageIndex, int pageSize, out int count);
        }
    
}
