using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeShop.Application.DomainDTO { 
    public class TaiKhoanDTO
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String PassWord { get; set; }
        public virtual NhanVienDTO UsernameNavigation { get; set; }
}
}
