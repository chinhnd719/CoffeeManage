using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Application.Interfaces
{
    public interface INhanVienServices
    {
        public void themNhanVien(NhanVienDTO nhanvien);

        public void suaNhanVien(NhanVienDTO nhanvien);

        public void xoaNhanVien(string maNV);

        public NhanVienDTO GetNhanVien(string maNV);
        
        IEnumerable<NhanVienDTO> getAll(int pageIndex, int pageSize,out int count);

    }
}
