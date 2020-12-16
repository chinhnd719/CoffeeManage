using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
    public class BangLuong
    {
        public BangLuong()
        {

        }
        [Key]
        public String MaNV { get; set; }
        public int TienThuong { get; set; }
        public int TamUng { get; set; }
        public int Luong { get; set; }
        public virtual ICollection<PhanCa> PhanCa { get; set; }

    }
}
