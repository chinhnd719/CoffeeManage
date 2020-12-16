using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    public interface ICTHDRepository
    {

        IEnumerable<CTHD> getAll(int pageIndex, int pageSize, out int count);
        public void ThemCTHD(CTHD  cthd);
        public void SuaCTHD(CTHD cthd);
        public void XoaCTHD(int id);

        public CTHD GetCTHD(int id);

    }
}
