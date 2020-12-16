using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Infrastructure.EF;
using CoffeeShop.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class AdminController : Controller
    {
        ISession session;
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

     
        public IActionResult Login(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }

            bool isAuthenticated = false;
            if (userName!=" "&& password!=" ") { 
                    if (userName == "admin" && password == "chinhnd719")
                    {
                        isAuthenticated = true;
                        HttpContext.Session.SetString("Admin", "admin");
                        return RedirectToAction("Index", "Home");
                    }
                    
                        using (var db = new CoffeeShopDbContext())
                        {
                              
                            if (userName==null) return RedirectToAction("Login");
                             var update = (from u in db.taikhoan where u.UserName == userName select u).FirstOrDefault();
                             if (update==null) return RedirectToAction("Login");
                            if (update.PassWord == password)
                                    {
                                        isAuthenticated = true;
                                        HttpContext.Session.SetString("User", userName);
                                        return RedirectToAction("ThongTin", "User");

                                    }

                                }
            }
            else return RedirectToAction("Login");
            if (isAuthenticated)
                    {
                        //var principal = new ClaimsPrincipal(identity);

                        //var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                        return RedirectToAction("Login", "Admin");
                    }
                    return View();
               }
        public IActionResult ThongTin()
        {
            var userName = HttpContext.Session.GetString("User");
            ViewBag.User = new UserView()
            {
                username = userName
                           };


            return View();
        }
        public IActionResult Logout()
        {
            //var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
           
        }
    }
}