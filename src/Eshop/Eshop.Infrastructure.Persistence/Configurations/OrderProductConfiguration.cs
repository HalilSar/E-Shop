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
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne<Customer>().WithMany().HasForeignKey(i => i.CustomerId);
            builder.HasOne<Order>().WithMany().HasForeignKey(i => i.OrderId);
            builder.HasOne<Product>().WithMany().HasForeignKey(i => i.ProductId);

        }
    }
}
