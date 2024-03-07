﻿using Eshop.Core.Domain.Entities;
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
            builder.HasOne<Customer>().WithMany().HasForeignKey(i => i.CustomerId).HasConstraintName("FK_CartItems_Customers_CustomerId").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Product>().WithMany().HasForeignKey(i => i.ProductId).HasConstraintName("FK_CartItems_Products_ProductId").OnDelete(DeleteBehavior.Restrict);

        }
    }
}
