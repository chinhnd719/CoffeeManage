using CoffeeShop.Application.DomainDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class PhanCaView
    {
        public PhanCaDTO phancaDTO { get; set; }
        public PaginatedList<PhanCaDTO> PhanCa { get; set; }
    }
}
