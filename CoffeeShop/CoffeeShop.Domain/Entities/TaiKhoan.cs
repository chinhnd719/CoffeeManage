using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Domain.Entities
{
    public class TaiKhoan
    {
        public TaiKhoan()
        {

        }
        [Key]
        public int Id { get; set; }
        public String UserName { get; set; }
        public String PassWord { get; set; }
        public virtual NhanVien UsernameNavigation { get; set; }
    }
}
