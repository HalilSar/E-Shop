using Eshop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Persistence.Configurations
{
    public  class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne<Customer>(u=>u.Customer).WithMany().HasForeignKey(i => i.CustomerId);
            builder.HasOne<Product>(u=> u.Product).WithMany().HasForeignKey(i => i.ProductId);

        }
    }
}
