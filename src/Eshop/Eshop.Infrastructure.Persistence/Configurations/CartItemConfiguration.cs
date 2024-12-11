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
	// Parameter: EntityTypeBuilder<CartItem> builder    
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne<Customer>(u=>u.Customer).WithMany(u => u.CartItems).HasForeignKey(i => i.CustomerId);
            builder.HasOne<Product>(u=> u.Product).WithMany(u=>u.CartItems).HasForeignKey(i => i.ProductId);

        }
    }
}
