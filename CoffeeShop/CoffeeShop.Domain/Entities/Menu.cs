using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
 
    public class Menu
    {
        public Menu()
        {

        }
        [Key]
        public String MaMon { set; get; }
        public String TenMon { set; get; }
        public int DonGia { set; get; }
        public int SoLuongTon { set; get; }

        public virtual ICollection<ChiTietNhap> ChiTietNhap { get; set; }
        public virtual ICollection<CTHD> CTHD { get; set; }
    }
}
