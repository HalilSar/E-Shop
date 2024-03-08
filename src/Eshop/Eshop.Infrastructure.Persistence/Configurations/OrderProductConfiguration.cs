using Eshop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infrastructure.Persistence.Configurations
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne<Customer>(x=>x.Customer).WithMany().HasForeignKey(i => i.CustomerId);
            builder.HasOne<Order>(x=>x.Order).WithMany().HasForeignKey(i => i.OrderId).HasConstraintName("FK_OrderProduct_Order").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Product>(x=>x.Product).WithMany().HasForeignKey(i => i.ProductId).HasConstraintName("FK_OrderProduct_Product");
        }
    }
}
