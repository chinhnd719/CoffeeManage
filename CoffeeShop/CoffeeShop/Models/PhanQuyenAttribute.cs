using CoffeeShop.Infrastructure.EF;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoffeeShop.Models
{
    public class PhanQuyenAttribute : AuthorizeAttribute
    {
        

    }
}
