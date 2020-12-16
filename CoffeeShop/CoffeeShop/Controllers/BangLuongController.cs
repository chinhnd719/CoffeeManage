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
    public class BangLuongController : Controller
    {
        private readonly IBangLuongServices _bangluongServices;

        public BangLuongController(IBangLuongServices bangluongServices)
        {
            _bangluongServices = bangluongServices;
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _bangluongServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new BangLuongView()
            {
                BangLuong = new PaginatedList<BangLuongDTO>(list, count, pageIndex, pageSize)
            };
            if (HttpContext.Session.GetString("User") != null)
                return RedirectToAction("PhanQuyen", "User");
            
            return View(indexVM);
        }

        public IActionResult ThemBangLuong()
        {
            return View();
        }
        public IActionResult ThemBangLuongData(BangLuongView bangluongView)
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _bangluongServices.themBangLuong(bangluongView.bangluongDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemBangLuong));
                return RedirectToAction("Index", "BangLuong");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemBangLuong));
        }

        public IActionResult SuaBangLuongData(BangLuongView bangluongView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                int x = 0;
                x= bangluongView.bangluongDTO.Luong - bangluongView.bangluongDTO.TamUng + bangluongView.bangluongDTO.TienThuong;
                bangluongView.bangluongDTO.Luong = x;
                _bangluongServices.suaBangLuong(bangluongView.bangluongDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaBangLuong(string id)
        {
            ViewBag.SuaBangLuong = _bangluongServices.GetBangLuong(id);
            return View();
        }


        public IActionResult XoaBangLuongData(string id) 
        {
            _bangluongServices.xoaBangLuong(id);
            Index();
            return View(nameof(Index)); 

        }
    }
}
