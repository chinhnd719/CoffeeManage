using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Interfaces
{
    public interface INhanVienRepository
    {
       
        IEnumerable<NhanVien> getAll(int pageIndex, int pageSize, out int count);
        public void ThemNhanVien(NhanVien nhanvien);
        public void SuaNhanVien(NhanVien nhanvien);
        public void XoaNhanVien(string maNV);

        public NhanVien GetNhanVien(string maNV);

    }
}
