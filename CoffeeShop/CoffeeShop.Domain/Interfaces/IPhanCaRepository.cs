using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Domain.Interfaces
{
    public interface IPhanCaRepository
    {

        IEnumerable<PhanCa> getAll(int pageIndex, int pageSize, out int count);
        public void ThemPhanCa(PhanCa phanca);
        public void SuaPhanCa(PhanCa phanca);
        public void XoaPhanCa(int id);

        public PhanCa GetPhanCa(int id);

    }
}
