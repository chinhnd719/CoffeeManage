using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
   public class PhanCa
    {
        public PhanCa()
        {

        }
        [Key]
        public int Id { get; set; }
        public String MaNV { get; set; }
        public int HeSoLuong { get; set; }
        public int SoGio { get; set; }
        public virtual BangLuong MaNVNavigationBL { get; set; }
        public virtual NhanVien MaNVNavigationNV { get; set; }
    }
}
