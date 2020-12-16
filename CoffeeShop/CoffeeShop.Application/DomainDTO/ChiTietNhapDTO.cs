using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CoffeeShop.Domain.Entities;

namespace CoffeeShop.Application.DomainDTO
{
    public class ChiTietNhapDTO
    {
         public String MaNhap { get; set; }
         public String DVT { get; set; }
         public String Ngay{ get; set; }
         public int TongTien{ get; set;}
         public int SoLuong{ get; set; }
         public String MaMon { get; set; }
         public virtual MenuDTO MaMonNavigation { get; set; }
    }
}
