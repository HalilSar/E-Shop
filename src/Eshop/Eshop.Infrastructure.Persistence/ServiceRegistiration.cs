using Eshop.Core.Application;
using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Infrastructure.Persistence.DbContexts;
using Eshop.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Eshop.Infrastructure.Persistence
{
    static public class ServiceRegistiration
    {
        public static  void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddApplicationServices();
            service.AddDbContext<ApplicationDbContext>();
            service.AddTransient<ICustomerRepository, CustomerRepository>();
            service.AddTransient<ICategoryRepository, CategoryRepository>();
            service.AddTransient<IProductRepository, ProductRepository>();
            service.AddTransient<IOrderRepository, OrderRepository>();
            service.AddTransient<IOrderProductRepository, OrderProductRepository>();
            service.AddTransient<ICartItemRepository, CartItemRepository>();
          
            
        }
    }
}
