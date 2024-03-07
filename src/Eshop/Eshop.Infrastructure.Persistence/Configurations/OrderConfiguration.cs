using Eshop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
            builder.HasOne<Customer>().WithMany().HasForeignKey(i => i.CustomerId).HasConstraintName("FK_OrderProducts_Customers_CustomerId").OnDelete(DeleteBehavior.Restrict);

        }
    }
}
