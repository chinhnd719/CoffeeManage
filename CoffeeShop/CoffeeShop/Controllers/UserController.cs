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
    public class UserController : Controller
    {
        private readonly INhanVienServices _nhanvienServices;

        public UserController(INhanVienServices nhanvienServices) 
        {
            _nhanvienServices = nhanvienServices;
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _nhanvienServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new NhanVienView()
            {
                NhanVien = new PaginatedList<NhanVienDTO>(list, count, pageIndex, pageSize)
            };
            var userName = HttpContext.Session.GetString("User");
            ViewBag.User = new UserView()
            {
                username = userName
            };

            return View(indexVM);
        }
        public IActionResult ThongTin(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _nhanvienServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new NhanVienView()
            {
                NhanVien = new PaginatedList<NhanVienDTO>(list, count, pageIndex, pageSize)
            };
            var userName = HttpContext.Session.GetString("User");
            ViewBag.User = new UserView()
            {
                username = userName
            };

            return View(indexVM);
        }
        public IActionResult SuaNhanVienData(NhanVienView nhanvienView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                // _nhanvienServices.suaNhanVien(nhanvienView.nhanvienDTO);
                using (var db = new CoffeeShopDbContext())
                {
                    var update = (from u in db.taikhoan where u.UserName == HttpContext.Session.GetString("User")  select u).Single();
                    update.PassWord = nhanvienView.nhanvienDTO.TenNV;
                    db.SaveChanges();
                }
                return RedirectToAction("ThongTin", "User");
                //return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }
        public IActionResult ThayDoiThongTinData(NhanVienView nhanvienView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _nhanvienServices.suaNhanVien(nhanvienView.nhanvienDTO);
               
                return RedirectToAction("ThongTin", "User");
                //return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }
        public IActionResult ThayDoiThongTin(String id)                                  

        {
            var userName = HttpContext.Session.GetString("User");
            ViewBag.User = new UserView()
            {
                username = userName
            };
            ViewBag.SuaNhanVien = _nhanvienServices.GetNhanVien(id);
            return View();
        }
        public IActionResult SuaNhanVien(String id)                         

        {
            var userName = HttpContext.Session.GetString("User");
            ViewBag.User = new UserView()
            {
                username = userName
            };
            ViewBag.SuaNhanVien = _nhanvienServices.GetNhanVien(id);
            return View();
        }
        public IActionResult PhanQuyen()
        {
            var userName = HttpContext.Session.GetString("User");
            ViewBag.User = new UserView()
            {
                username = userName
            };
            return View();
        }

    }
}
