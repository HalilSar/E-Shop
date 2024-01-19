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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(i => i.Title).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Description).IsRequired().HasMaxLength(400);
            builder.HasOne<Category>().WithMany().HasForeignKey(u => u.CategoryId);
        }
    }
}