using Eshop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(i => i.Title).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Description).IsRequired().HasMaxLength(400);
            builder.HasOne<Category>().WithMany(x=>x.Products).HasForeignKey(u => u.CategoryId).IsRequired();
        }
    }
}
