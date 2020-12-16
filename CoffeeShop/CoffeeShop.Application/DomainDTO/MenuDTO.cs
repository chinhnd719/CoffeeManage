using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeShop.Application.DomainDTO
{
 
    public class MenuDTO
    {
        public String MaMon { set; get; }
        public String TenMon { set; get; }
        public int DonGia { set; get; }
        public int SoLuongTon { set; get; }
    }
}
