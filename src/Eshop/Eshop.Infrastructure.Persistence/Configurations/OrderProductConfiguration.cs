﻿using Eshop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infrastructure.Persistence.Configurations
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne<Customer>().WithMany().HasForeignKey(i => i.CustomerId).HasConstraintName("FK_OrderProducts_Customers_CustomerId");
            builder.HasOne<Order>().WithMany().HasForeignKey(i => i.OrderId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_OrderProducts_Orders_OrderId");
            builder.HasOne<Product>().WithMany().HasForeignKey(i => i.ProductId).HasConstraintName("FK_OrderProducts_Products_ProductId");
        }
    }
}
