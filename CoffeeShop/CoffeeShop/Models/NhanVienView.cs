using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Application.DomainDTO;

namespace CoffeeShop.Models
{
    public class NhanVienView
    {
        public NhanVienDTO nhanvienDTO { get; set; }
        public PaginatedList<NhanVienDTO> NhanVien { get; set; }

        public string search { get; set; }
}
}
