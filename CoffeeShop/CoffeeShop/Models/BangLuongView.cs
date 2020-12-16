using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class BangLuongView
    {
        public BangLuongDTO bangluongDTO { get; set; }
        public PaginatedList<BangLuongDTO> BangLuong { get; set; }
    }
}
