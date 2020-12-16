using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Infrastructure.Persistence
{
    public class NhanVienRepository : INhanVienRepository 
    {
        private readonly CoffeeShopDbContext _conText;
        public NhanVienRepository(CoffeeShopDbContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<NhanVien> getAll(int pageIndex, int pageSize,out int count)
        {  
            count=_conText.nhanvien.Count();

            var query = _conText.nhanvien.AsQueryable(); 
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public NhanVien GetNhanVien(string maNV)
        {

            return _conText.nhanvien.Find(maNV); 
        }

        public void SuaNhanVien(NhanVien nhanvien)
        {
            _conText.nhanvien.Update(nhanvien);
            _conText.SaveChanges();
        }

        public void ThemNhanVien(NhanVien nhanvien)
        {
            _conText.nhanvien.Add(nhanvien);
            _conText.SaveChanges();
        }

        public void XoaNhanVien(string maNV)
        {
            
            var nhanvienDaTimThay = _conText.nhanvien.Find(maNV);
            if (nhanvienDaTimThay != null)
            {
                _conText.nhanvien.Remove(nhanvienDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
