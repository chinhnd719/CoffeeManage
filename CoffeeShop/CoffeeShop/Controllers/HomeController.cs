using CoffeeShop.Infrastructure.EF;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {   
       
        public IActionResult Index()
        {
            
                 if (HttpContext.Session.GetString("Admin") == null)
                     return RedirectToAction("Login", "Admin");
           else
            {
                using (var db = new CoffeeShopDbContext())
                {
                    ViewBag.Product = new HomeView()
                    {
                        soluong = db.hoadon.Count(),
                        tongtien= db.cthd.Sum(cthd=>cthd.Gia)
                        
                    };

                };
                return View();
            }
        }
        
      
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ThongTin()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
