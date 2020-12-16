using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
    public class HoaDon
    {
        public HoaDon()
        {

        }
        [Key]
        public String MaHD { get; set; }
        public String NgayLapHD { get; set; }
        public String ThoiGian { get; set; }
        public String SoLuong { get; set; }
        public String MaNV { get; set; }
        public virtual NhanVien MaNVNavigation { get; set; }
        public virtual ICollection<CTHD> CTHD { get; set; }
    }
}
