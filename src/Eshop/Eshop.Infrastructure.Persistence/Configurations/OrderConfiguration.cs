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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(i => i.Name).IsRequired().HasMaxLength(20);
            builder.Property(i => i.SurName).IsRequired().HasMaxLength(20);
            builder.Property(i => i.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Adress).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Total).IsRequired().HasMaxLength(20);
            builder.HasOne<Customer>().WithMany().HasForeignKey(i => i.CustomerId);

        }
    }
}