using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Interfaces
{
    public interface ICTHDServices
    {
        public void themCTHD(CTHDDTO cthd);

        public void suaCTHD(CTHDDTO cthd);

        public void xoaCTHD(int id);

        public CTHDDTO GetCTHD(int id);

        IEnumerable<CTHDDTO> getAll(int pageIndex, int pageSize, out int count);

    }
}
