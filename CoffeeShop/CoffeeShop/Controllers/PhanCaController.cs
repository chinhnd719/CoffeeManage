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
    public class PhanCaController : Controller
    {
        private readonly IPhanCaServices _phancaServices;

        public PhanCaController(IPhanCaServices phancaServices) 
        {
            _phancaServices = phancaServices;
        }
        public IActionResult Index(int pageIndex = 1)
        {
            int count;
            int pageSize = 4;
            var list = _phancaServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new PhanCaView()
            {
                PhanCa = new PaginatedList<PhanCaDTO>(list, count, pageIndex, pageSize)
            };
            if (HttpContext.Session.GetString("User") != null)
                return RedirectToAction("PhanQuyen", "User");
            
            return View(indexVM);
        }

        public IActionResult ThemPhanCa()
        {
            return View();
        }
        public IActionResult ThemPhanCaData(PhanCaView phancaView)
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                using (var db = new CoffeeShopDbContext())
                {
                    var update = (from u in db.bangluong where u.MaNV == phancaView.phancaDTO.MaNV select u).Single();
                   if (phancaView.phancaDTO.HeSoLuong==1) update.Luong +=  phancaView.phancaDTO.SoGio*20000;
                    else update.Luong += phancaView.phancaDTO.SoGio * 30000;
                    db.SaveChanges();
                }
                _phancaServices.themPhanCa(phancaView.phancaDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemPhanCa));
                return RedirectToAction("Index", "PhanCa");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemPhanCa));
        }

        public IActionResult SuaPhanCaData(PhanCaView phancaView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _phancaServices.suaPhanCa(phancaView.phancaDTO);
               
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaPhanCa(int id)

        {
            ViewBag.SuaPhanCa = _phancaServices.GetPhanCa(id);
            return View();
        }


        public IActionResult XoaPhanCaData(int id) 
        {
            _phancaServices.xoaPhanCa(id);
            Index();
            return View(nameof(Index)); 

        }
    }
}
