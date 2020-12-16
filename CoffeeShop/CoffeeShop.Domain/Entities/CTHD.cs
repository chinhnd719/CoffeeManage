using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
   public class CTHD
    {
        public CTHD()
        {

        }
        [Key]
        public int ID { get; set; }
        public String MaHD { get; set; } 
        public String MaMon { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public String TenMon { get; set; }
        public virtual HoaDon MaHoaDonNavigation { get; set; }
        public virtual Menu MaMonNavigation { get; set; }
    }
}
