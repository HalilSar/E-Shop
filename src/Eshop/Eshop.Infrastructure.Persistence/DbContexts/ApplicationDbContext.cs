using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Core.Application.Interfaces.Context;
using Microsoft.EntityFrameworkCore;
using Eshop.Core.Domain.Entities;
using Eshop.Infrastructure.Persistence.Configurations;
using Microsoft.Extensions.Configuration;

namespace Eshop.Infrastructure.Persistence.DbContexts
{
    public  class ApplicationDbContext:DbContext,IApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions dbContextOption):base(dbContextOption)
        {          
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category {Id=1, Title = "CategoryA" },
                new Category { Id=2,Title = "CategoryB" },
                new Category {Id=3, Title = "CategoryC" },
                new Category {Id=4, Title = "CategoryD" },
                new Category { Id = 5, Title = "CategoryE" },
                new Category { Id = 6, Title = "CategoryF" },
                new Category { Id = 7, Title = "CategoryG" }
                );
            builder.Entity<Product>().HasData(
               new Product { Title = "Product1", Detail = "rem Ipsum is simply dummy text of the printing and typesetting industry. " +
               "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of " +
               "type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic " +
               "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
               "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                   Amount = 20, Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. ", CategoryId = 1,
                   Image = "http://localhost:5000/wwwroot/img/pexels-math-90946.jpg", CreatedDate = DateTime.Now,Price=20.0
               },
                              new Product
                              {
                                  Title = "Product1.5",
                                  Detail = "rem Ipsum is simply dummy text of the printing and typesetting industry. " +
               "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of " +
               "type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic " +
               "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
               "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                                  Amount = 20,
                                  Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. ",
                                  CategoryId = 1,
                                  Image = "http://localhost:5000/wwwroot/img/pexels-math-90946.jpg",
                                  CreatedDate = DateTime.Now,
                                  Price = 20.0
                              },
                              new Product
                              {
                                  Title = "Product2",
                                  Detail = "rem Ipsum is simply dummy text of the printing and typesetting industry. " +
               "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of " +
               "type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic " +
               "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
               "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                                  Amount = 20,
                                  Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. ",
                                  CategoryId = 1,
                                  Image = "http://localhost:5000/wwwroot/img/pexels-math-90946.jpg",
                                  CreatedDate = DateTime.Now,
                                  Price = 20.0
                              },
                              new Product
                              {
                                  Title = "Product3",
                                  Detail = "rem Ipsum is simply dummy text of the printing and typesetting industry. " +
               "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of " +
               "type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic " +
               "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
               "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                                  Amount = 20,
                                  Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. ",
                                  CategoryId = 1,
                                  Image = "http://localhost:5000/wwwroot/img/pexels-math-90946.jpg",
                                  CreatedDate = DateTime.Now,
                                  Price = 20.0

                              },
                              new Product
                               {
                                   Title = "Product4",
                                   Detail = "rem Ipsum is simply dummy text of the printing and typesetting industry. " +
               "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of " +
               "type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic " +
               "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
               "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                                   Amount = 20,
                                   Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. ",
                                   CategoryId = 1,
                                   Image = "http://localhost:5000/wwwroot/img/pexels-math-90946.jpg",
                                   CreatedDate = DateTime.Now,
                                   Price = 20.0

                               },
                              new Product
                             {
                                 Title = "Product5",
                                 Detail = "rem Ipsum is simply dummy text of the printing and typesetting industry. " +
               "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of " +
               "type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic " +
               "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
               "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                                 Amount = 20,
                                 Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. ",
                                 CategoryId = 1,
                                 Image = "http://localhost:5000/wwwroot/img/pexels-math-90946.jpg",
                                 CreatedDate = DateTime.Now,
                                 Price = 20.0

                             }

               ) ;
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new OrderProductConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new CartItemConfiguration());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}
