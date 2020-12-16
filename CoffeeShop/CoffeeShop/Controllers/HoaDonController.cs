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
    public class HoaDonController : Controller
    {
        private readonly IHoaDonServices _hoadonServices;
        public HoaDonController(IHoaDonServices hoadonServices) 
        {
            _hoadonServices = hoadonServices;
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _hoadonServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new HoaDonView()
            {
                HoaDon = new PaginatedList<HoaDonDTO>(list, count, pageIndex, pageSize)
            };
            if (HttpContext.Session.GetString("User") != null)
                return RedirectToAction("PhanQuyen", "User");
          
            return View(indexVM);
            
        }

        public IActionResult ThemHoaDon()
        {
            return View();
        }
        public IActionResult ThemHoaDonData(HoaDonView hoadonView)
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                //string[] formattedStrings = now.GetDateTimeFormats('T');
                //char[] formats = { 'd', 't' };
                //Console.WriteLine("Now is " + formattedStrings[0]  );
               String date = String.Format("{0:d/M/yyyy}", now);
               String time = String.Format("{0:T}", now);
                hoadonView.hoadonDTO.NgayLapHD = date;
                hoadonView.hoadonDTO.ThoiGian = time;
                _hoadonServices.themHoaDon(hoadonView.hoadonDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemHoaDon));
                return RedirectToAction("Index", "HoaDon");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemHoaDon));
        }

        public IActionResult SuaHoaDonData(HoaDonView hoadonView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _hoadonServices.suaHoaDon(hoadonView.hoadonDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaHoaDon(string id)
        {
            ViewBag.SuaHoaDon = _hoadonServices.GetHoaDon(id);
            return View();
        }


        public IActionResult XoaHoaDonData(string id)
        {
            _hoadonServices.xoaHoaDon(id);
            Index();
            return View(nameof(Index));

        }
    }
}
