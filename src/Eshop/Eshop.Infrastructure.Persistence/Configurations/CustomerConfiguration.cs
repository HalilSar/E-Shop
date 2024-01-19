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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(i => i.Firstname).IsRequired().HasMaxLength(20);
            builder.Property(i => i.LastName).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(50);
            builder.Property(i => i.Password).IsRequired().HasMaxLength(23);

        }
    }
}
