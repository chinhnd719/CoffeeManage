using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Infrastructure.Configurations
{
    public class BangLuongConfiguration : IEntityTypeConfiguration<BangLuong>
    {
        public void Configure(EntityTypeBuilder<BangLuong> builder)
        {
            throw new NotImplementedException();
        }
    }
}
