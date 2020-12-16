using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Infrastructure.EF;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class ChiTietNhapController : Controller
    {
        private readonly IChiTietNhapServices _chitietnhapServices;
        public ChiTietNhapController(IChiTietNhapServices chitietnhapServices) 
        {
            _chitietnhapServices = chitietnhapServices;
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _chitietnhapServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new ChiTietNhapView()
            {
                ChiTietNhap = new PaginatedList<ChiTietNhapDTO>(list, count, pageIndex, pageSize)
            };
            if (HttpContext.Session.GetString("User") != null)
                return RedirectToAction("PhanQuyen", "User");
          
            return View(indexVM);
        }

        public IActionResult ThemChiTietNhap()
        {
            return View();
        }
        public IActionResult ThemChiTietNhapData(ChiTietNhapView chitietnhapView)
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                using (var db = new CoffeeShopDbContext())
                {
                    var update = (from u in db.menu where u.MaMon == chitietnhapView.chitietnhapDTO.MaMon select u).Single();
                    update.SoLuongTon += chitietnhapView.chitietnhapDTO.SoLuong;
                    db.SaveChanges();
                }
                DateTime now = DateTime.Now;
                String date = String.Format("{0:d/M/yyyy}", now);
                String time = String.Format("{0:T}", now);
                chitietnhapView.chitietnhapDTO.Ngay = date;
         
                _chitietnhapServices.themChiTietNhap(chitietnhapView.chitietnhapDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemChiTietNhap));
                return RedirectToAction("Index", "ChiTietNhap");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemChiTietNhap));
        }

        public IActionResult SuaChiTietNhapData(ChiTietNhapView chitietnhapView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _chitietnhapServices.suaChiTietNhap(chitietnhapView.chitietnhapDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaChiTietNhap(string id)
        {
            ViewBag.SuaChiTietNhap = _chitietnhapServices.GetChiTietNhap(id);
            return View();
        }


        public IActionResult XoaChiTietNhapData(string id)
        {
            _chitietnhapServices.xoaChiTietNhap(id);
            Index();
            return View(nameof(Index)); 

        }
    }
}
