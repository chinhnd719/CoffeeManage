using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class CTHDView
    {
        public CTHDDTO cthdDTO { get; set; }
        public PaginatedList<CTHDDTO> CTHD { get; set; }

        public MenuDTO menuDTO { get; set; }
    }
}
