using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoffeeShop.Infrastructure.Repository
{
    public class PhanCaRepository : IPhanCaRepository 
    {
        private readonly CoffeeShopDbContext _conText;
        public PhanCaRepository(CoffeeShopDbContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<PhanCa> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.phanca.Count();

            var query = _conText.phanca.AsQueryable(); 
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public PhanCa GetPhanCa(int id)
        {

            return _conText.phanca.Find(id);
        }

        public void SuaPhanCa(PhanCa phanca)
        {
            _conText.phanca.Update(phanca);
            _conText.SaveChanges();
        }

        public void ThemPhanCa(PhanCa phanca)
        {
            _conText.phanca.Add(phanca);
            _conText.SaveChanges();
        }

        public void XoaPhanCa(int id)
        {

            var phancaDaTimThay = _conText.phanca.Find(id);
            if (phancaDaTimThay != null)
            {
                _conText.phanca.Remove(phancaDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
