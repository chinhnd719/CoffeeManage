using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
    public class ChiTietNhap
    {
        public ChiTietNhap()
        {

        }
        [Key]
        public String MaNhap { get; set; }
         public String DVT { get; set; }
         public String Ngay{ get; set; }
         public int TongTien{ get; set;}
         public int SoLuong{ get; set; }
         public String MaMon { get; set; }
         public virtual Menu MaMonNavigation { get; set; }
    }
}
