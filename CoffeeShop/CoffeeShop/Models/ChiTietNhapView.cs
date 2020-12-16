using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class ChiTietNhapView
    {
        public ChiTietNhapDTO chitietnhapDTO { get; set; }
        public PaginatedList<ChiTietNhapDTO> ChiTietNhap { get; set; }
    }
}
