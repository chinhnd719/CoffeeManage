using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Application.DomainDTO
{
    public class HoaDonDTO
    {
        public String MaHD { get; set; }
        public String NgayLapHD { get; set; }
        public String ThoiGian { get; set; }
        public String SoLuong { get; set; }
        public String MaNV { get; set; }
        public virtual NhanVienDTO MaNVNavigation { get; set; }
    }
}
