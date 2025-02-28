﻿using Eshop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infrastructure.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        //parameter EntityTypeBuilder<Order> builder
	public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(i => i.Name).IsRequired().HasMaxLength(20);
            builder.Property(i => i.SurName).IsRequired().HasMaxLength(20);
            builder.Property(i => i.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Adress).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Total).IsRequired().HasMaxLength(20);
            builder.HasOne<Customer>(u=>u.Customer).WithMany(x=>x.Orders).HasForeignKey(i => i.CustomerId);

        }
    }
}
