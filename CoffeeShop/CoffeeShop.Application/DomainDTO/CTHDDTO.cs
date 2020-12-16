using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeShop.Application.DomainDTO
{
   public class CTHDDTO
    {
        public int ID { get; set; }
        public String MaHD { get; set; }
        public String MaMon { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public String TenMon { get; set; }
        public virtual HoaDonDTO MaHoaDonNavigation { get; set; }
        public virtual MenuDTO MaMonNavigation { get; set; }
    }
}
