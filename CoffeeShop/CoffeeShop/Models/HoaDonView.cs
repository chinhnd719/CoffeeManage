using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class HoaDonView
    {
        public HoaDonDTO hoadonDTO { get; set; }
        public PaginatedList<HoaDonDTO> HoaDon { get; set; }

    }
}
