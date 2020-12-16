using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
    public class NhanVien
    {
        public NhanVien()
        {

        }
        [Key]
        public String MaNV { get; set; }
        public String TenNV { get; set; }
        public String HoNV { get; set; }
        public String SDT { get; set; }
        public String GioiTinh { get; set; }
        public virtual ICollection<PhanCa> PhanCa { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }

    }
}
