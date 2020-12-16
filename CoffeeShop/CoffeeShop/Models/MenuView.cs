using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MenuView
    {
        public MenuDTO menuDTO { get; set; }
        public PaginatedList<MenuDTO> Menu { get; set; }

    }
}
