
using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Domain.Entities;
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
    public class NhanVienController : Controller
    {
        private readonly INhanVienServices _nhanvienServices;

        public NhanVienController(INhanVienServices nhanvienServices) 
        {
            _nhanvienServices = nhanvienServices;
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _nhanvienServices.getAll(pageIndex,pageSize,out count);
            var indexVM = new NhanVienView()
            {
                NhanVien = new PaginatedList<NhanVienDTO>(list,count, pageIndex, pageSize)
            };
            if (HttpContext.Session.GetString("User") != null)
                return RedirectToAction("PhanQuyen", "User");
            return View(indexVM);
        }
        [HttpPost]
        public IActionResult SearchNhanVien(string term)
        {
            int count;
            int pageIndex = 1;
            int pageSize = 4;
            var list = _nhanvienServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new NhanVienView()
            {
                NhanVien = new PaginatedList<NhanVienDTO>(list, count, pageIndex, pageSize)
            };
            ViewBag.Product = new NhanVienView()
            {
                search = term
            };

            return View(indexVM);
        }
        

        public IActionResult ThemNhanVien()
        { 
           return View();
         }
        public IActionResult ThemNhanVienData(NhanVienView nhanvienView)
        {
            ViewBag.Error = "1";
            if(ModelState.IsValid)
            { 
                _nhanvienServices.themNhanVien(nhanvienView.nhanvienDTO);
                 ViewBag.Success = "Đã thêm thành công";
                using (var db = new CoffeeShopDbContext())
                {
                    var taikhoan = new TaiKhoan
                    {
                        UserName = nhanvienView.nhanvienDTO.MaNV.ToString(),
                        PassWord = "123456"
                    };
                    db.taikhoan.Add(taikhoan);
                    var luong = new BangLuong
                    {
                        MaNV = nhanvienView.nhanvienDTO.MaNV.ToString(),
                        TienThuong = 0,
                        TamUng = 0,
                        Luong = 0

                    };
                    db.bangluong.Add(luong);
                    db.SaveChanges();
                }
                 
                //return Redirect(nameof(ThemNhanVien));
                return RedirectToAction("Index", "NhanVien");
            }
           ViewBag.Error = "0";
            return View(nameof(ThemNhanVien));
       }

        public IActionResult SuaNhanVienData(NhanVienView nhanvienView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _nhanvienServices.suaNhanVien(nhanvienView.nhanvienDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaNhanVien(string id)
            
        {
            ViewBag.SuaNhanVien = _nhanvienServices.GetNhanVien(id);
            return View();
        }
        


        public IActionResult XoaNhanVienData(string id) 
        {
            _nhanvienServices.xoaNhanVien(id);
            Index();
            return View(nameof(Index)); 

        }
    }
}
