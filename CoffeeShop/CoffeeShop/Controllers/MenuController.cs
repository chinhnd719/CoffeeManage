using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuServices _menuServices;

        public MenuController(IMenuServices menuServices) 
        {
            _menuServices = menuServices;
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _menuServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new MenuView()
            {
                Menu = new PaginatedList<MenuDTO>(list, count, pageIndex, pageSize)
            };
            if (HttpContext.Session.GetString("User") != null)
                return RedirectToAction("PhanQuyen", "User");
           
            return View(indexVM);
        }
      
        public IActionResult ThemMenu()
        {
            return View();
        }
        public IActionResult ThemMenuData(MenuView menuView)
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _menuServices.themMenu(menuView.menuDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemMenu));
                return RedirectToAction("Index", "Menu");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemMenu));
        }

        public IActionResult SuaMenuData(MenuView menuView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _menuServices.suaMenu(menuView.menuDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaMenu(string id)
        {
            ViewBag.SuaMenu = _menuServices.GetMenu(id);
            return View();
        }


        public IActionResult XoaMenuData(string id) 
        {
            _menuServices.xoaMenu(id);
            return View(nameof(Index)); 

        }
    }
}
