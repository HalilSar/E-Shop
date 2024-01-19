using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Core.Application.Interfaces.Context;
using Microsoft.EntityFrameworkCore;
using Eshop.Core.Domain.Entities;
namespace Eshop.Infrastructure.Persistence.DbContexts
{
    public  class ApplicationDbContext:DbContext,IApplicationDbContext
    {
        // IConfiguration configuration;
        //public ApplicationDbContext()
        //{

        //}
        protected  void OnConfiguring(DbContextOptionsBuilder<ApplicationDbContext> options)
        {
            options.UseSqlServer("Your Connection String");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Title = "CategoryA" },
                new Category { Title = "CategoryB" },
                new Category { Title = "CategoryC" },
                new Category { Title = "CategoryD" },
                new Category { Title = "CategoryE" },
                new Category { Title = "CategoryF" },
                new Category { Title = "CategoryG" }
                );
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}
