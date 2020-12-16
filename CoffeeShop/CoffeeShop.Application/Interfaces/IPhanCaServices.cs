using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Interfaces
{
    public interface IPhanCaServices
    {
        public void themPhanCa(PhanCaDTO phanca);

        public void suaPhanCa(PhanCaDTO phanca);

        public void xoaPhanCa(int id);

        public PhanCaDTO GetPhanCa(int id);

        IEnumerable<PhanCaDTO> getAll(int pageIndex, int pageSize, out int count);
    }
}
