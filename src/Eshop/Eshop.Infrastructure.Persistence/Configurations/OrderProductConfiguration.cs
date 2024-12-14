using Eshop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infrastructure.Persistence.Configurations
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
	// parameter EntityTypeBuilder<OrderProduct> builder    
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne<Customer>(x=>x.Customer).WithMany(x=>x.OrderProducts).HasForeignKey(i => i.CustomerId);
            builder.HasOne<Order>(x=>x.Order).WithMany(x=>x.OrderProducts).HasForeignKey(i => i.OrderId).HasConstraintName("FK_OrderProduct_Order").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Product>(x=>x.Product).WithMany(x=>x.OrderProducts).HasForeignKey(i => i.ProductId).HasConstraintName("FK_OrderProduct_Product");
        }
    }
}
