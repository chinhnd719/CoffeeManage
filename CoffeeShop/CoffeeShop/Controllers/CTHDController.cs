using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Infrastructure.EF;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class CTHDController : Controller
    {
        private readonly ICTHDServices _cthdServices;

        public CTHDController(ICTHDServices cthdServices)
        {
            _cthdServices = cthdServices;
        }
        public IActionResult Index1(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _cthdServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new CTHDView()
            {
                CTHD = new PaginatedList<CTHDDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _cthdServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new CTHDView()
            {
                CTHD = new PaginatedList<CTHDDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }

        public IActionResult ThemCTHD()
        {
            return View();
        }
        public IActionResult ThemCTHDData(CTHDView cthdView)
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                using (var db = new CoffeeShopDbContext())
                {
                    var update = (from u in db.menu where u.MaMon == cthdView.cthdDTO.MaMon select u).Single();
                    update.SoLuongTon = update.SoLuongTon- cthdView.cthdDTO.SoLuong;
                    db.SaveChanges();
                }
                _cthdServices.themCTHD(cthdView.cthdDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemCTHD));
                return RedirectToAction("Index", "CTHD");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemCTHD));
        }

        public IActionResult SuaCTHDData(CTHDView cthdView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
               
                _cthdServices.suaCTHD(cthdView.cthdDTO);
                Index();
                return RedirectToAction("Index", "CTHD");
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaCTHD(int id)
        {
            ViewBag.SuaCTHD = _cthdServices.GetCTHD(id);
            return View();
        }


        public IActionResult XoaCTHDData(int id) 
        {
            _cthdServices.xoaCTHD(id);
            Index();
            return RedirectToAction("Index", "CTHD");

        }
    }
}
