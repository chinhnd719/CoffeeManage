using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Application.DomainDTO
{
   public class PhanCaDTO
    {
        public int Id { get; set; }
        public String MaNV { get; set; }
        public int HeSoLuong { get; set; }
        public int SoGio { get; set; }

        public virtual BangLuongDTO MaNVNavigationBL { get; set; }
        public virtual NhanVienDTO MaNVNavigationNV { get; set; }
    }
}
